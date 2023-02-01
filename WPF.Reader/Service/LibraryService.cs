using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPF.Reader.Model;

namespace WPF.Reader.Service
{
    public class LibraryService
    {
        // A remplacer avec vos propres données !!!!!!!!!!!!!!
        // Pensé qu'il ne faut mieux ne pas réaffecter la variable Books, mais juste lui ajouter et / ou enlever des éléments
        // Donc pas de LibraryService.Instance.Books = ...
        // mais plutot LibraryService.Instance.Books.Add(...)
        // ou LibraryService.Instance.Books.Clear()
        public ObservableCollection<Genre> Genres { get; set; } = new ObservableCollection<Genre>()
        {
           new Genre() { Name="Sciences-Fiction"},
           new Genre(){ Name="Romantique"}
        };
        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>() {
            new Book() { Title= "Super", Author= "Jojo", Price= 19, Genres= new List<Genre>(){Genres.[0]},  Content= "Ta mere"},
            new Book() { Title= "Super", Author= "Jijo", Price= 19, Content= "Ta mere"},
            new Book() { Title= "Super", Author= "Jiji", Price= 19, Content= "Ta mere"}
        };

        // C'est aussi ici que vous ajouterez les requête réseau pour récupérer les livres depuis le web service que vous avez fait
        // Vous pourrez alors ajouter les livres obtenu a la variable Books !
        // Faite bien attention a ce que votre requête réseau ne bloque pas l'interface 
    }
}
