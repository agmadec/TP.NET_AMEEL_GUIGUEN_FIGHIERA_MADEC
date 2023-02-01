using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;
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
        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>() {
            new Book()
            {
                Title= "Tom au pays des kangourous et Tom au pays des kangourous et Tom au pays des kangourous",
                Author= "Håkan Nesser",
                Price= 19,
                Genres= new List<Genre>() {new Genre() { Name= "SF"}, new Genre() { Name= "Aventure"} },
                Content= "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute; par un vieil homme qui lui a demand&eacute; de l'aide pour sauver sa fille, enlev&eacute;e par un dragon. Tom n'a pas h&eacute;sit&eacute; et est parti &agrave; la rescousse de la jeune fille. Il a affront&eacute; le dragon et a r&eacute;ussi &agrave; le vaincre gr&acirc;ce &agrave; sa force et &agrave; son courage.</p> <p>La jeune fille a &eacute;t&eacute; sauv&eacute;e et a &eacute;t&eacute; r&eacute;unie avec son p&egrave;re, qui a remerci&eacute; Tom pour son acte h&eacute;ro&iuml;que. De retour au village, Tom a &eacute;t&eacute; accueilli en h&eacute;ros et tout le monde a c&eacute;l&eacute;br&eacute; sa victoire. Les habitants du village ont commenc&eacute; &agrave; voir Tom comme leur protecteur et l'ont appel&eacute; pour les aider dans toutes sortes de situations difficiles.</p> <p>Tom a continu&eacute; &agrave; explorer la for&ecirc;t et &agrave; aider les gens du village, en affrontant des cr&eacute;atures dangereuses et en r&eacute;solvant des &eacute;nigmes complexes. Il a gagn&eacute; la reconnaissance et le respect de tous les habitants du village.</p> <p>&nbsp;</p> <h1>Chapitre 2 : Une nouvelle aventure</h1> <p>Un jour, le roi du royaume voisin a demand&eacute; de l'aide &agrave; Tom pour sauver sa fille, qui avait &eacute;t&eacute; enlev&eacute;e par une sorci&egrave;re mal&eacute;fique. Tom n'a pas h&eacute;sit&eacute; et est parti pour la rescousse de la princesse. Il a finalement r&eacute;ussi &agrave; vaincre la sorci&egrave;re et &agrave; sauver la princesse, devenant ainsi un h&eacute;ros connu dans tout le royaume.</p> <p>Et ainsi, Tom est devenu un h&eacute;ros l&eacute;gendaire pour les g&eacute;n&eacute;rations &agrave; venir, connu pour son courage, sa sagesse et son d&eacute;vouement &agrave; aider les autres.</p>\r\n\r\n"
            },
            new Book()
            {
                Title= "Lorem Ipsum",
                Author= "Lorem",
                Price= 19,
                Genres= new List<Genre>() {new Genre() { Name= "Romantique"} },
                Content= "<h1>Lorem Ipsum</h1> <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc venenatis hendrerit eros, a sagittis erat pellentesque id. Etiam porttitor lectus elementum molestie efficitur. Cras vehicula blandit dui et euismod. Suspendisse potenti. Pellentesque eu odio finibus, ornare leo sed, cursus quam. In sodales nisi diam, non fermentum neque cursus vitae. Nullam blandit vulputate feugiat. Sed feugiat tortor at accumsan ornare. Integer fermentum, orci quis aliquet vulputate, ligula sapien tempor magna, nec eleifend neque odio in justo. Sed sit amet nisi erat.</p> <p>Aliquam mattis nulla eu diam tempus laoreet. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam nibh erat, vehicula sit amet mollis sit amet, faucibus vitae risus. Nullam placerat nisl tempus vestibulum porttitor. Phasellus vel enim eu leo fermentum commodo. Nunc lobortis accumsan facilisis. Curabitur pharetra fermentum lacus, fermentum accumsan nulla consequat in. Nullam a tellus ligula. Mauris quis vulputate dui, eget tempus ligula. Cras efficitur lobortis suscipit. Nam ipsum odio, tempor eget pharetra a, volutpat quis ipsum.</p> <p>&nbsp;</p> <h2>Lorem Ipsum 2: Le retour de Lorem</h2> <p>Quisque eu tellus eros. Cras sit amet quam vitae nisi rutrum rutrum id ut dolor. Maecenas fermentum felis sed mauris congue, ac egestas massa tristique. Pellentesque varius, tortor in vestibulum venenatis, erat ante interdum ligula, luctus sagittis sem nibh nec neque. Proin laoreet leo sem, id molestie libero volutpat ut. Aenean tincidunt dignissim congue. Donec condimentum sed ex a rutrum. Fusce vulputate nulla sed gravida bibendum. Nullam varius lacus vel placerat scelerisque.</p> <p>Phasellus vitae luctus lectus, id pharetra neque. Quisque volutpat orci vitae nibh accumsan, sit amet maximus mauris auctor. Etiam sem tellus, euismod vel scelerisque eget, sagittis eget enim. Suspendisse et dui in enim porta iaculis. Ut varius luctus sagittis. Curabitur elementum nisi lorem, in commodo mi laoreet quis. Nulla vel mauris sit amet libero pharetra pharetra. Nam placerat elit non lorem tincidunt, non pulvinar risus ultrices. Vestibulum rutrum ante sed malesuada sollicitudin. Quisque nec lacinia felis. Sed nulla leo, efficitur vel fermentum eu, tristique quis ex. Nulla id vestibulum purus. Etiam mauris enim, mattis id leo ac, tempus pretium magna. Cras ut arcu vitae dolor gravida pellentesque sed vitae velit.</p> <p><span style=\"color: rgb(230, 126, 35);\">Nullam tellus nibh, porttitor vel nunc eget, dictum consectetur ligula. Ut et diam ac arcu interdum placerat. Donec sed risus imperdiet, tempor eros eget, scelerisque ante. Quisque molestie ex libero, ac varius orci tempor ut. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque tellus velit, sodales ut massa quis, tempor auctor augue. Donec dui ipsum, pharetra quis augue vitae, volutpat efficitur nunc. Donec eget tempor libero, id maximus elit. Nulla facilisi. Vivamus finibus, tellus sit amet tincidunt tempus, nisi nibh ultricies dolor, ut laoreet risus dolor et magna. Mauris sit amet molestie mauris. Integer a purus leo. Donec cursus arcu ac velit molestie, vel tempus odio tincidunt. Donec fermentum, tellus sed porta sagittis, quam urna commodo ante, in porta dui purus vitae ligula. Nam sit amet eleifend nisl. Nullam elementum fermentum tellus et euismod.</span></p>"
            },
            new Book()
            {
                Title= "Super",
                Author= "Jiji",
                Price= 19,
                Genres= new List<Genre>() {new Genre() { Name= "Best-seller"} },
                Content= "Ta mere"
            }
        };

        // C'est aussi ici que vous ajouterez les requête réseau pour récupérer les livres depuis le web service que vous avez fait
        // Vous pourrez alors ajouter les livres obtenu a la variable Books !
        // Faite bien attention a ce que votre requête réseau ne bloque pas l'interface 
    }
}
