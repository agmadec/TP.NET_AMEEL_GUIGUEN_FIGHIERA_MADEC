using CommunityToolkit.Mvvm.DependencyInjection;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WPF.Reader.Model;
using WPF.Reader.Service;

namespace WPF.Reader.ViewModel
{
    internal class ListBook : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ItemSelectedCommand { get; set; }
        public ICommand GenreSelectedCommand { get; set; }

        public ObservableCollection<BookWithoutContent> Books => Ioc.Default.GetRequiredService<LibraryService>().Books;
        public ObservableCollection<Genre> Genres => Ioc.Default.GetRequiredService<LibraryService>().Genres;

        public int SelectedIndex { get; set; } = 0;


        public ListBook()
        {
            Ioc.Default.GetRequiredService<LibraryService>().PopulateCollection();
            ItemSelectedCommand = new RelayCommand(book =>
            {
                var newBook = Ioc.Default.GetService<LibraryService>().GetBook((BookWithoutContent)book);
                Ioc.Default.GetRequiredService<INavigationService>().Navigate<DetailsBook>(newBook);
            });
            GenreSelectedCommand = new RelayCommand(genre =>
            {
                Ioc.Default.GetRequiredService<LibraryService>().BookByGenre((Genre)genre);
                SelectedIndex = 0;
            });
        }
    }
}
