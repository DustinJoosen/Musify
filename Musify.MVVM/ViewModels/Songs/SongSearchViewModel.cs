using Musify.MVVM.Models;
using Musify.MVVM.Utility;
using Musify.MVVM.ViewModels.Albums;
using Musify.MVVM.Views.Albums;
using Musify.MVVM.Views.Songs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Musify.MVVM.ViewModels.Songs
{
    public enum SongSortCriteria
    {
        None,
        Title,
        Artist,
        Genre,
        ReleaseDate,
        Duration
    }

    public class SongSearchViewModel : Song
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

        // Properties
        private ICollectionView _songsView;
        public ICollectionView SongsView
        {
            get => this._songsView;
            set
            {
                this._songsView = value;
                RaisePropertyChanged(nameof(SongsView));
            }
        }

        private ObservableCollection<object> _songs;
        public ObservableCollection<object> Songs
        {
            get => this._songs;
            set
            {
                this._songs = value;
                RaisePropertyChanged(nameof(Songs));

                this._songsView = CollectionViewSource.GetDefaultView(value);
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

        private IEnumerable<SongSortCriteria> _sortCategoryItems;
        public IEnumerable<SongSortCriteria> SortingCategoryItems
        {
            get => this._sortCategoryItems;
            set
            {
                this._sortCategoryItems = value;
                RaisePropertyChanged(nameof(SortingCategoryItems));
            }
        }

        private SongSortCriteria _sortingCategorySelected;
        public SongSortCriteria SortingCategorySelected
        {
            get => this._sortingCategorySelected;
            set
            {
                this._sortingCategorySelected = value;
                RaisePropertyChanged(nameof(SortingCategorySelected));
            }
        }

        // TODO: song filter.
        private SongSearchFilterWindow _filterWindow;

        // Pagination fields
        private Paginator<Song> _paginator;
        public string CurrentMaxPage => $"{1 + this._paginator.GetCurrentPage()} / {this._paginator.GetMaxAmountOfPages()}";
        public bool PaginationCanGoLeft => this._paginator.CanDecreasePage();
        public bool PaginationCanGoRight => this._paginator.CanIncreasePage();

        public SongSearchViewModel(Action<object> goToCreate, Action<object> goToDetails, 
            Action<object> goToEdit, Action<object> goToDelete)
        {
            this.OnCreate = new RelayCommand(goToCreate);
            this.OnDetailBtn = new RelayCommand(goToDetails);
            this.OnEditBtn = new RelayCommand(goToEdit);
            this.OnDeleteBtn = new RelayCommand(goToDelete);

            Action<object> refresh = (obj) => Refresh();
            this.OnRefresh = new RelayCommand(refresh);
            this.OnSort = new RelayCommand(refresh);

            this.OnPaginationNext = new RelayCommand((obj) => { this._paginator?.AddCurrentPage(1); });
            this.OnPaginationPrev = new RelayCommand((obj) => { this._paginator?.AddCurrentPage(-1); });
            this.OnPaginationStart = new RelayCommand((obj) => { this._paginator?.SetCurrentPage(0); });
            this.OnPaginationEnd = new RelayCommand((obj) => { this._paginator?.SetCurrentPage(this._paginator.GetMaxAmountOfPages() - 1); });

            this.OpenFilterWindow = new RelayCommand((obj) =>
            {
                this._filterWindow?.Close();
                this._filterWindow = new SongSearchFilterWindow(Refresh);
                this._filterWindow.Show();
            });

            this.SortingCategoryItems = Enum.GetValues<SongSortCriteria>();
            this.SortingCategorySelected = SongSortCriteria.None;

            this._paginator = new(JsonHandler.GetAll<Song>(), Refresh, itemsPerPage: PageSize.Ten);
            this.Refresh();
        }

        public void Refresh()
        {
            // Retrieve all songs
            var songs = JsonHandler.GetAll<Song>();

            // Apply search criteria, if they exist.
            if (!string.IsNullOrEmpty(this.SearchText))
            {
                songs = songs.Where(song => song.Title.ToLower().Contains(this.SearchText.ToLower())).ToList();
            }

            // Sorting
            this.ApplySorting(ref songs);

            // Filtering
            this._filterWindow?.ApplyFilters(ref songs);

            // Assign the searched, ordered, filtered songs to the paginator.
            this._paginator.Items = songs;

            // Make sure 'search' won't leave you at page 4/1.
            if (this._paginator.GetCurrentPage() > this._paginator.GetMaxAmountOfPages())
                this._paginator.SetCurrentPage(0, false);

            // Get the (paginized) itms to display in the datagrid.
            var items = this._paginator?.GetItems().Select(song => new
            {
                Title = song.Title,
                Artist = song.Artist,
                DetailBtn = new Button()
                {
                    Content = "Details",
                    Command = this.OnDetailBtn,
                    CommandParameter = song.Id,
                    Background = new SolidColorBrush(Color.FromRgb(100, 100, 220)),
                },
                EditBtn = new Button()
                {
                    Content = "Edit",
                    Command = this.OnEditBtn,
                    CommandParameter = song.Id,
                    Background = new SolidColorBrush(Color.FromRgb(100, 220, 100))
                },
                DeleteBtn = new Button()
                {
                    Content = "Delete",
                    Command = this.OnDeleteBtn,
                    CommandParameter = song.Id,
                    Background = new SolidColorBrush(Color.FromRgb(220, 100, 100))
                }
            });

            // Assigns items to datagrid.
            this.Songs = new(items);

            // Raise property change event on all pagination fields
            RaisePropertyChanged(nameof(CurrentMaxPage));
            RaisePropertyChanged(nameof(PaginationCanGoLeft));
            RaisePropertyChanged(nameof(PaginationCanGoRight));
            RaisePropertyChanged(nameof(SongsView));
        }

        public void ApplySorting(ref List<Song> songs)
        {
            switch (this.SortingCategorySelected)
            {
                case SongSortCriteria.Title:
                case SongSortCriteria.None:
                    songs = songs.OrderBy(song => song.Title).ToList();
                    break;
                case SongSortCriteria.Artist:
                    songs = songs.OrderBy(song => song.Artist).ThenBy(song => song.Title).ToList();
                    break;
                case SongSortCriteria.Genre:
                    songs = songs.OrderBy(song => song.Genre).ThenBy(song => song.Title).ToList();
                    break;
                case SongSortCriteria.ReleaseDate:
                    songs = songs.OrderBy(song => song.ReleaseDate).ThenBy(song => song.Title).ToList();
                    break;
                case SongSortCriteria.Duration:
                    songs = songs.OrderBy(song => song.Duration).ThenBy(song => song.Title).ToList();
                    break;
            }
        }
    }
}
