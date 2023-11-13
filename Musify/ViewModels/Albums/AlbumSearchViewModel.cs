using Musify.Models;
using Musify.Utility;
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
using System.Windows.Media.Imaging;

namespace Musify.ViewModels.Albums
{
    public class AlbumSearchViewModel : Album
    {
        // Commands
        public ICommand OnSearch { get; set; }
        public ICommand OnDetailBtn { get; set; }
        public ICommand OnEditBtn { get; set; }
        public ICommand OnDeleteBtn { get; set; }
        public ICommand OnCreate { get; set; }
        public ICommand OnDetails { get; set; }

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

        // Pagination fields
        private Paginator<Album> _paginator;
        public string CurrentPage => (1 + this._paginator.GetCurrentPage()).ToString();
        public string MaxPages => $"/{this._paginator.GetMaxAmountOfPages()}";

        // Methods
        public AlbumSearchViewModel(Action<object> goToCreate, Action<object> goToDetails)
        {
            Action<object> action = (obj) => MessageBox.Show(obj.ToString());

            this.OnCreate = new RelayCommand(goToCreate);
            this.OnDetailBtn = new RelayCommand(goToDetails);
            this.OnEditBtn = new RelayCommand(action);
            this.OnDeleteBtn = new RelayCommand(action);

            this.OnSearch = new RelayCommand((obj) => { this.Albums.RemoveAt(0); });

            this.OnPaginationNext = new RelayCommand((obj) => { this._paginator?.AddCurrentPage(1); });
            this.OnPaginationPrev = new RelayCommand((obj) => { this._paginator?.AddCurrentPage(-1); });
            this.OnPaginationStart = new RelayCommand((obj) => { this._paginator?.SetCurrentPage(0); });
            this.OnPaginationEnd = new RelayCommand((obj) => { this._paginator?.SetCurrentPage(this._paginator.GetMaxAmountOfPages() - 1);});

            var albums = JsonHandler.GetAll<Album>();
            this._paginator = new(albums, Refresh, itemsPerPage: 4);

            this.Refresh();

        }

        public void Refresh()
        {
            // Refresh the paginator data


            // Get the specified objects.
            var items = this._paginator?.GetItems().Select(album => new
            {
                CoverImage = new BitmapImage(new Uri($"../../Lib/Uploads/{album.CoverImage}", UriKind.RelativeOrAbsolute)),
                Title = album.Title,
                ReleaseYear = album.ReleaseYear,
                Image = album.CoverImage,
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

            // Raise property change event on all pagination fields
            RaisePropertyChanged(nameof(MaxPages));
            RaisePropertyChanged(nameof(CurrentPage));
            RaisePropertyChanged(nameof(PaginationCanGoLeft));
            RaisePropertyChanged(nameof(PaginationCanGoRight));
            RaisePropertyChanged(nameof(AlbumsView));
        }
    }

}