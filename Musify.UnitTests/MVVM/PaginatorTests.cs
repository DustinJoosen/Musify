using Musify.MVVM.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify.UnitTests.MVVM
{
    [TestClass]
    public class PaginatorTests
    {
        [TestMethod]
        public void TestPaginatorPageSizeValid()
        {
            List<string> items = new List<string> {
                "Alice",
                "Bob",
                "Crystal",
                "Dave",
                "Edward",
                "Fred",
                "Greg",
                "Han"
            };

            var paginator = new Paginator<string>(items, null, PageSize.Three);
            paginator.AddCurrentPage(1);

            Assert.AreEqual(1, paginator.GetCurrentPage());
        }

        [TestMethod]
        public void TestPaginatorPageSizeInvalid()
        {
            List<string> items = new List<string> {
                "Alice",
                "Bob",
                "Crystal",
                "Dave",
                "Edward",
                "Fred",
                "Greg",
                "Han"
            };

            var paginator = new Paginator<string>(items, null, PageSize.Three);
            paginator.AddCurrentPage(1);
            paginator.AddCurrentPage(1);

            Assert.AreNotEqual(1, paginator.GetCurrentPage());
        }

        [TestMethod]
        public void TestPaginatorGetItems()
        {
            List<string> items = new List<string> {
                "Alice",
                "Bob",
                "Crystal",
                "Dave",
                "Edward",
                "Fred",
                "Greg",
                "Han"
            };

            var paginator = new Paginator<string>(items, null, PageSize.Three);
            paginator.AddCurrentPage(1);

            IEnumerable<string> actual = paginator.GetItems();
            Assert.AreEqual("Dave", actual.First());
        }
    }

}
