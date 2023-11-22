using Musify.Models;
using Musify.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Musify.Utility
{
    public enum PageSize
    {
        Three=3,
        Five=5,
        Ten=10,
        Twenty=20,
        Fifty=50
    };

    public class Paginator<T>
    {
        public delegate void Callback();
        public event Callback CallbackChangePage;

        private int _itemsPerPage;
        private int _currentPage;

        public IEnumerable<T> Items { get; set; }

        public Paginator(IEnumerable<T> items, Callback callbackChangePage, PageSize itemsPerPage=PageSize.Three)
        {
            this.Items = items;
            this.CallbackChangePage += callbackChangePage;

            this._itemsPerPage = (int)itemsPerPage;
            this._currentPage = 0;
        }

        public IEnumerable<T> GetItems()
        {
            return this.Items
                .Skip(this._currentPage * this._itemsPerPage)
                .Take(this._itemsPerPage);
        }

        public int GetCurrentPage() => 
            this._currentPage;

        public int GetPageSize() =>
            this._itemsPerPage;

        public void SetPageSize(PageSize size) =>
            this._itemsPerPage = (int)size;

        /// <returns>minimum of 1, even if there are no items found.</returns>
        public int GetMaxAmountOfPages() =>
            Math.Max(1, (int) Math.Ceiling((double)this.Items.Count() / this._itemsPerPage));
        
        public bool CanDecreasePage() =>
            this._currentPage > 0;

        public bool CanIncreasePage() =>
            this._currentPage + 1 < this.GetMaxAmountOfPages();

        public void AddCurrentPage(int n)
        {
            if (n != 1 && n != -1)
                throw new ArgumentException("given number needs to be either 1 or -1");

            // If you want to lower, but you can't stop it.
            if (n == -1 && !this.CanDecreasePage())
                return;

            if (n == 1 && !this.CanIncreasePage())
                return;

            this.SetCurrentPage(this._currentPage + n);
        }
        public void SetCurrentPage(int page, bool invokeCallback=true)
        {
            this._currentPage = page;

            if (invokeCallback)
                this.CallbackChangePage?.Invoke();
        }

    }
}