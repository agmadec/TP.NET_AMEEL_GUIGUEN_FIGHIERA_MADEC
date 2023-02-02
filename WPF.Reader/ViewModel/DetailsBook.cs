using CommunityToolkit.Mvvm.DependencyInjection;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Navigation;
using WPF.Reader.Model;
using WPF.Reader.Service;

namespace WPF.Reader.ViewModel
{
    public class DetailsBook : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand ReadCommand { get; init; } = new RelayCommand(x => { Ioc.Default.GetRequiredService<INavigationService>().Navigate<ReadBook>(x); });

        // n'oublier pas faire de faire le binding dans DetailsBook.xaml !!!!
        public Book CurrentBook { get; init; }
        public int NombreDeMots { get; init; }
        public string TempsDeLecture { get; init; }
        public int TempsDeLectureMinute { get; init; }
        public int TempsDeLectureSeconde { get; init; }
        public int VitesseDeLecturre { get; init; } = 150;

        public DetailsBook(Book book)
        {
            if (book == null) return;
            CurrentBook = book;
            string sansBalises = Regex.Replace(book.Content, "<[^>]*>", string.Empty);
            string[] mots = sansBalises.Split(' ');
            NombreDeMots = mots.Length;
            float minutes = (float)NombreDeMots / VitesseDeLecturre;
            int secondes = (int)(minutes*60);
            TempsDeLectureMinute = secondes / 60;
            TempsDeLectureSeconde = secondes % 60;
            TempsDeLecture = string.Format("~{0:0} : {1:00}", TempsDeLectureMinute, TempsDeLectureSeconde);

        }
    }

    /* Cette classe sert juste a afficher des donnée de test dans le designer */
    public class InDesignDetailsBook : DetailsBook
    {
        public InDesignDetailsBook() : base(new Book() { Title = "Test Book", Genres = new() { new() { Name = "Test Genre" } } } ) { }
    }
}
