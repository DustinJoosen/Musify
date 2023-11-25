using Musify.MVVM.Models;
using Musify.MVVM.Utility;
using Musify.MVVM.Views.Albums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Musify.MVVM.ViewModels.Albums
{
    public enum AlbumSortCriteria
    {
        None,
        Title,
        ReleaseYear,
    }

    public class AlbumSearchViewModel : Album
    {
        // Commands
        public ICommand OnDetailBtn { get; set; }
        public ICommand OnEditBtn { get; set; }
        public ICommand OnDeleteBtn { get; set; }
        public ICommand OnCreate { get; set; }
        public ICommand OnSort { get; set; }
        public ICommand OpenFilterWindow { get; set; }
        public ICommand OnRefresh { get; set; }

        // Pagination Commands
        public ICommand OnPaginationNext { get; set; }
        public ICommand OnPaginationPrev { get; set; }
        public ICommand OnPaginationStart { get; set; }
        public ICommand OnPaginationEnd { get; set; }
        public bool PaginationCanGoLeft => this._paginator.CanDecreasePage();
        public bool PaginationCanGoRight => this._paginator.CanIncreasePage();

        // Properties
        private ICollectionView _albumsView;
        public ICollectionView AlbumsView
        {
            get => this._albumsView;
            set
            {
                this._albumsView = value;
                RaisePropertyChanged(nameof(AlbumsView));
            }
        }

        private ObservableCollection<object> _albums;
        public ObservableCollection<object> Albums
        {
            get => this._albums;
            set
            {
                this._albums = value;
                RaisePropertyChanged(nameof(Albums));

                this._albumsView = CollectionViewSource.GetDefaultView(value);
            }
        }

        private string _searchText = string.Empty;
        public string SearchText
        {
            get => this._searchText;
            set
            {
                this._searchText = value;
                RaisePropertyChanged(nameof(SearchText));
             
                // Search criteria applied. Refresh the contents.
                this.Refresh();
            }
        }

        private IEnumerable<AlbumSortCriteria> _sortCategoryItems;
        public IEnumerable<AlbumSortCriteria> SortingCategoryItems
        {
            get => this._sortCategoryItems;
            set
            {
                this._sortCategoryItems = value;
                RaisePropertyChanged(nameof(SortingCategoryItems));
            }
        }

        private AlbumSortCriteria _sortingCategorySelected;
        public AlbumSortCriteria SortingCategorySelected
        {
            get => this._sortingCategorySelected;
            set
            {
                this._sortingCategorySelected = value;
                RaisePropertyChanged(nameof(SortingCategorySelected));
            }
        }


        private AlbumSearchFilterWindow _filterWindow;
        // Pagination fields

        private Paginator<Album> _paginator;
        public string CurrentMaxPage => $"{1 + this._paginator.GetCurrentPage()} / {this._paginator.GetMaxAmountOfPages()}";

        // Methods
        public AlbumSearchViewModel(Action<object> goToCreate, Action<object> goToDetails, Action<object> goToEdit)
        {
            Action<object> action = (obj) => MessageBox.Show(obj.ToString());

            this.OnCreate = new RelayCommand(goToCreate);
            this.OnDetailBtn = new RelayCommand(goToDetails);
            this.OnEditBtn = new RelayCommand(goToEdit);
            this.OnDeleteBtn = new RelayCommand(action);

            Action<object> refresh = (obj) => Refresh();
            this.OnRefresh = new RelayCommand(refresh);
            this.OnSort = new RelayCommand(refresh);

            this.OnPaginationNext = new RelayCommand((obj) => { this._paginator?.AddCurrentPage(1); });
            this.OnPaginationPrev = new RelayCommand((obj) => { this._paginator?.AddCurrentPage(-1); });
            this.OnPaginationStart = new RelayCommand((obj) => { this._paginator?.SetCurrentPage(0); });
            this.OnPaginationEnd = new RelayCommand((obj) => { this._paginator?.SetCurrentPage(this._paginator.GetMaxAmountOfPages() - 1);});

            this.OpenFilterWindow = new RelayCommand((obj) =>
            {
                this._filterWindow?.Close();
                this._filterWindow = new AlbumSearchFilterWindow(Refresh);
                this._filterWindow.Show();
            });

            this.SortingCategoryItems = Enum.GetValues<AlbumSortCriteria>();
            this.SortingCategorySelected = AlbumSortCriteria.None;

            this._paginator = new(JsonHandler.GetAll<Album>(), Refresh, itemsPerPage: PageSize.Three);
            this.Refresh();
        }

        public void Refresh()
        {
            // Retrieve a new part of all albums
            var albums = JsonHandler.GetAll<Album>();

            // Apply search criteria, if it exists.
            if (!string.IsNullOrEmpty(this.SearchText))
            {
                albums = albums.Where(album => album.Title.ToLower().Contains(this.SearchText.ToLower())).ToList();
            }

            // Sorting
            this.ApplySorting(ref albums);

            // Filtering
            this._filterWindow?.ApplyFilters(ref albums);

            // Assign the searched, ordered, filtered albums to the paginator.
            this._paginator.Items = albums;
            
            // Get the paginazied items to display.
            var items = this._paginator?.GetItems().Select(album => new
            {
                Image = new Image()
                {
                    Width = 40,
                    Height = 40,
                    Source = this.LoadImage(album.CoverImage)
                },
                Title = album.Title,
                ReleaseYear = album.ReleaseYear,
                DetailBtn = new Button()
                {
                    Content = "Details",
                    Command = this.OnDetailBtn,
                    CommandParameter = album.Id,
                    Background = new SolidColorBrush(Color.FromRgb(100, 100, 220)),
                },
                EditBtn = new Button()
                {
                    Content = "Edit",
                    Command = this.OnEditBtn,
                    CommandParameter = album.Id,
                    Background = new SolidColorBrush(Color.FromRgb(100, 220, 100))
                },
                DeleteBtn = new Button()
                {
                    Content = "Delete",
                    Command = this.OnDeleteBtn,
                    CommandParameter = album.Id,
                    Background = new SolidColorBrush(Color.FromRgb(220, 100, 100))
                }
            });

            this.Albums = new(items);

            // Make sure 'search' won't leave you at page 4/1.
            if (this._paginator.GetCurrentPage() > this._paginator.GetMaxAmountOfPages())
                this._paginator.SetCurrentPage(0, false);

            // Raise property change event on all pagination fields
            RaisePropertyChanged(nameof(CurrentMaxPage));
            RaisePropertyChanged(nameof(PaginationCanGoLeft));
            RaisePropertyChanged(nameof(PaginationCanGoRight));
            RaisePropertyChanged(nameof(AlbumsView));
        }

        public void ApplySorting(ref List<Album> albums)
        {
            if (this.SortingCategorySelected == AlbumSortCriteria.None)
            {
                // Default sorting.
                albums = albums
                    .OrderBy(album => album.Title)
                    .ThenByDescending(album => album.ReleaseYear)
                    .ToList();

                return;
            }

            switch (this.SortingCategorySelected)
            {
                case AlbumSortCriteria.Title:
                    albums = albums.OrderBy(album => album.Title).ToList();
                    break;
                case AlbumSortCriteria.ReleaseYear:
                    albums = albums.OrderBy(album => album.ReleaseYear).ToList();
                    break;
            }
        }

        public BitmapImage LoadImage(string fileName)
        {
            BitmapImage bitmap = new();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri($"../../Lib/Uploads/{fileName}", UriKind.RelativeOrAbsolute);
            bitmap.EndInit();

            return bitmap;
        }
    }

}