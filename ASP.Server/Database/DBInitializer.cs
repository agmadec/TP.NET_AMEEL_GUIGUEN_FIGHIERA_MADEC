using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ASP.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ASP.Server.Database
{
    public class DbInitializer
    {
        public static void Initialize(LibraryDbContext bookDbContext)
        {

            if (bookDbContext.Books.Any())
                return;

            Genre SF, Fantasy,Aventure, Roman, Classic, Jeunesse, Social, Ex, Comique, Anti, Thriller, Horreur, Policier, Mystere, Drame, Fantastique, Histoire, Comedie, Tragedie, Poesie;
            bookDbContext.Genre.AddRange(
            SF = new Genre() { Name = "Science-Fiction" },
            Fantasy = new Genre() { Name = "Fantasy" },
            Aventure = new Genre() { Name = "Aventure" },
            Roman = new Genre() { Name = "Roman" },
            Classic = new Genre() { Name = "Classique" },
            Jeunesse = new Genre() { Name = "Jeunesse" },
            Social = new Genre() { Name = "Social" },
            Ex = new Genre() { Name = "Existentialiste" },
            Comique = new Genre() { Name = "Comique" },
            Anti = new Genre() { Name = "Anticipation" },
            Thriller = new Genre() { Name = "Thriller" },
            Horreur = new Genre() { Name = "Horreur" },
            Policier = new Genre() { Name = "Policier" },
            Mystere = new Genre() { Name = "Mystère" },
            Drame = new Genre() { Name = "Drame" },
            Fantastique = new Genre() { Name = "Fantastique" },
            Histoire = new Genre() { Name = "Historique" },
            Comedie = new Genre() { Name = "Comédie" },
            Tragedie = new Genre() { Name = "Tragédie" },
            Poesie = new Genre() { Name = "Poésie" }
            );
            bookDbContext.SaveChanges();

            // Une fois les moèles complété Vous pouvez faire directement
            // new Book() { Author = "xxx", Name = "yyy", Price = n.nnf, Content = "ccc", Genres = new() { Romance, Thriller } }
            bookDbContext.Books.AddRange(
            new Book()
            {
                Title = "Tom au pays des kangourous et Tom au pays des kangourous et Tom au pays des kangourous",
                Author = "Håkan Nesser",
                Price = 19,
                Genres = new List<Genre>() { SF, Aventure },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute; par un vieil homme qui lui a demand&eacute; de l'aide pour sauver sa fille, enlev&eacute;e par un dragon. Tom n'a pas h&eacute;sit&eacute; et est parti &agrave; la rescousse de la jeune fille. Il a affront&eacute; le dragon et a r&eacute;ussi &agrave; le vaincre gr&acirc;ce &agrave; sa force et &agrave; son courage.</p> <p>La jeune fille a &eacute;t&eacute; sauv&eacute;e et a &eacute;t&eacute; r&eacute;unie avec son p&egrave;re, qui a remerci&eacute; Tom pour son acte h&eacute;ro&iuml;que. De retour au village, Tom a &eacute;t&eacute; accueilli en h&eacute;ros et tout le monde a c&eacute;l&eacute;br&eacute; sa victoire. Les habitants du village ont commenc&eacute; &agrave; voir Tom comme leur protecteur et l'ont appel&eacute; pour les aider dans toutes sortes de situations difficiles.</p> <p>Tom a continu&eacute; &agrave; explorer la for&ecirc;t et &agrave; aider les gens du village, en affrontant des cr&eacute;atures dangereuses et en r&eacute;solvant des &eacute;nigmes complexes. Il a gagn&eacute; la reconnaissance et le respect de tous les habitants du village.</p> <p>&nbsp;</p> <h1>Chapitre 2 : Une nouvelle aventure</h1> <p>Un jour, le roi du royaume voisin a demand&eacute; de l'aide &agrave; Tom pour sauver sa fille, qui avait &eacute;t&eacute; enlev&eacute;e par une sorci&egrave;re mal&eacute;fique. Tom n'a pas h&eacute;sit&eacute; et est parti pour la rescousse de la princesse. Il a finalement r&eacute;ussi &agrave; vaincre la sorci&egrave;re et &agrave; sauver la princesse, devenant ainsi un h&eacute;ros connu dans tout le royaume.</p> <p>Et ainsi, Tom est devenu un h&eacute;ros l&eacute;gendaire pour les g&eacute;n&eacute;rations &agrave; venir, connu pour son courage, sa sagesse et son d&eacute;vouement &agrave; aider les autres.</p>\r\n\r\n"
            },
            new Book()
            {
                Title = "Lorem Ipsum",
                Author = "Lorem",
                Price = 19,
                Genres = new List<Genre>() { Histoire },
                Content = "<h1>Lorem Ipsum</h1> <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc venenatis hendrerit eros, a sagittis erat pellentesque id. Etiam porttitor lectus elementum molestie efficitur. Cras vehicula blandit dui et euismod. Suspendisse potenti. Pellentesque eu odio finibus, ornare leo sed, cursus quam. In sodales nisi diam, non fermentum neque cursus vitae. Nullam blandit vulputate feugiat. Sed feugiat tortor at accumsan ornare. Integer fermentum, orci quis aliquet vulputate, ligula sapien tempor magna, nec eleifend neque odio in justo. Sed sit amet nisi erat.</p> <p>Aliquam mattis nulla eu diam tempus laoreet. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam nibh erat, vehicula sit amet mollis sit amet, faucibus vitae risus. Nullam placerat nisl tempus vestibulum porttitor. Phasellus vel enim eu leo fermentum commodo. Nunc lobortis accumsan facilisis. Curabitur pharetra fermentum lacus, fermentum accumsan nulla consequat in. Nullam a tellus ligula. Mauris quis vulputate dui, eget tempus ligula. Cras efficitur lobortis suscipit. Nam ipsum odio, tempor eget pharetra a, volutpat quis ipsum.</p> <p>&nbsp;</p> <h2>Lorem Ipsum 2: Le retour de Lorem</h2> <p>Quisque eu tellus eros. Cras sit amet quam vitae nisi rutrum rutrum id ut dolor. Maecenas fermentum felis sed mauris congue, ac egestas massa tristique. Pellentesque varius, tortor in vestibulum venenatis, erat ante interdum ligula, luctus sagittis sem nibh nec neque. Proin laoreet leo sem, id molestie libero volutpat ut. Aenean tincidunt dignissim congue. Donec condimentum sed ex a rutrum. Fusce vulputate nulla sed gravida bibendum. Nullam varius lacus vel placerat scelerisque.</p> <p>Phasellus vitae luctus lectus, id pharetra neque. Quisque volutpat orci vitae nibh accumsan, sit amet maximus mauris auctor. Etiam sem tellus, euismod vel scelerisque eget, sagittis eget enim. Suspendisse et dui in enim porta iaculis. Ut varius luctus sagittis. Curabitur elementum nisi lorem, in commodo mi laoreet quis. Nulla vel mauris sit amet libero pharetra pharetra. Nam placerat elit non lorem tincidunt, non pulvinar risus ultrices. Vestibulum rutrum ante sed malesuada sollicitudin. Quisque nec lacinia felis. Sed nulla leo, efficitur vel fermentum eu, tristique quis ex. Nulla id vestibulum purus. Etiam mauris enim, mattis id leo ac, tempus pretium magna. Cras ut arcu vitae dolor gravida pellentesque sed vitae velit.</p> <p><span style=\"color: rgb(230, 126, 35);\">Nullam tellus nibh, porttitor vel nunc eget, dictum consectetur ligula. Ut et diam ac arcu interdum placerat. Donec sed risus imperdiet, tempor eros eget, scelerisque ante. Quisque molestie ex libero, ac varius orci tempor ut. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque tellus velit, sodales ut massa quis, tempor auctor augue. Donec dui ipsum, pharetra quis augue vitae, volutpat efficitur nunc. Donec eget tempor libero, id maximus elit. Nulla facilisi. Vivamus finibus, tellus sit amet tincidunt tempus, nisi nibh ultricies dolor, ut laoreet risus dolor et magna. Mauris sit amet molestie mauris. Integer a purus leo. Donec cursus arcu ac velit molestie, vel tempus odio tincidunt. Donec fermentum, tellus sed porta sagittis, quam urna commodo ante, in porta dui purus vitae ligula. Nam sit amet eleifend nisl. Nullam elementum fermentum tellus et euismod.</span></p>"
            },
            new Book()
            {
                Title = "L'IA dans tous ses états",
                Author = "David Gomez",
                Price = 19,
                Genres = new List<Genre>() { Ex, Anti },
                Content = "<h2>Chapitre 1 : Introduction</h2> <p>L'Intelligence Artificielle (IA) est en train de changer notre monde de mani&egrave;re significative. De plus en plus de domaines, tels que la finance, la sant&eacute; et les sciences, adoptent l'IA pour am&eacute;liorer les processus et les r&eacute;sultats. Cependant, l'IA suscite &eacute;galement de nombreuses inqui&eacute;tudes quant &agrave; ses implications sur l'emploi et les questions &eacute;thiques. Dans ce texte, nous examinerons les avantages et les inconv&eacute;nients de l'IA, ainsi que les d&eacute;fis &eacute;thiques qui y sont li&eacute;s.</p> <h2>Chapitre 2 : Les avantages de l'IA</h2> <p>L'IA peut apporter de nombreux avantages consid&eacute;rables, notamment une am&eacute;lioration de la productivit&eacute;, une augmentation de l'efficacit&eacute; et une r&eacute;duction des co&ucirc;ts. Les syst&egrave;mes d'IA peuvent automatiser de nombreuses t&acirc;ches fastidieuses et r&eacute;p&eacute;titives, ce qui peut lib&eacute;rer du temps pour des t&acirc;ches plus cr&eacute;atives et strat&eacute;giques. De plus, l'IA peut fournir des informations en temps r&eacute;el et des analyses plus pr&eacute;cises, ce qui peut conduire &agrave; des d&eacute;cisions plus inform&eacute;es.</p> <h2>Chapitre 3 : Les inconv&eacute;nients de l'IA</h2> <p>Bien que l'IA puisse apporter de nombreux avantages, il y a &eacute;galement des inconv&eacute;nients importants &agrave; prendre en compte. Tout d'abord, les syst&egrave;mes d'IA peuvent remplacer certains emplois, ce qui peut entra&icirc;ner une r&eacute;duction de l'emploi et une augmentation du ch&ocirc;mage. De plus, il y a un risque que les syst&egrave;mes d'IA ne soient pas exempts de biais, ce qui peut entra&icirc;ner des erreurs ou des discriminations.</p> <h2>Chapitre 4 : Les enjeux &eacute;thiques li&eacute;s &agrave; l'IA</h2> <p>L'IA soul&egrave;ve &eacute;galement de nombreuses questions &eacute;thiques importantes, telles que la responsabilit&eacute; en cas d'erreur, la protection de la vie priv&eacute;e et la transparence des algorithmes. Il est crucial de s'assurer que les syst&egrave;mes d'IA soient d&eacute;velopp&eacute;s et utilis&eacute;s de mani&egrave;re responsable pour garantir le bien-&ecirc;tre de tous les individus.</p> <h2>Chapitre 5 : Conclusion</h2> <p>En conclusion, l'IA est en train de r&eacute;volutionner notre monde de mani&egrave;re consid&eacute;rable, apportant de nombreux avantages tout en soulevant de nombreux d&eacute;fis &eacute;thiques. Il est important de poursuivre les d&eacute;bats sur les implications de l'IA pour garantir un futur positif pour tous.</p> <div class=\"flex-1 overflow-hidden\"> <div class=\"react-scroll-to-bottom--css-acqro-79elbk h-full dark:bg-gray-800\"> <div class=\"react-scroll-to-bottom--css-acqro-1n7m0yu\"> <div class=\"flex flex-col items-center text-sm h-full dark:bg-gray-800\"> <div class=\"w-full border-b border-black/10 dark:border-gray-900/50 text-gray-800 dark:text-gray-100 group bg-gray-50 dark:bg-[#444654]\"> <div class=\"text-base gap-4 md:gap-6 m-auto md:max-w-2xl lg:max-w-2xl xl:max-w-3xl p-4 md:py-6 flex lg:px-0\"> <div class=\"relative flex w-[calc(100%-50px)] flex-col gap-1 md:gap-3 lg:w-[calc(100%-115px)]\"> <div class=\"flex flex-grow flex-col gap-3\"> <div class=\"min-h-[20px] flex flex-col items-start gap-4 whitespace-pre-wrap\"> <div class=\"markdown prose w-full break-words dark:prose-invert dark\"> <h2>Chapitre 6 : Le r&ocirc;le de la gouvernance dans l'IA</h2> <p>La gouvernance de l'IA jouera un r&ocirc;le crucial dans la d&eacute;termination de la direction que prendra le d&eacute;veloppement de l'IA. Il est important de cr&eacute;er un cadre de gouvernance solide qui inclura des r&egrave;gles et des r&eacute;glementations pour garantir une utilisation responsable de l'IA. Les gouvernements, les entreprises et les organisations de la soci&eacute;t&eacute; civile doivent travailler ensemble pour &eacute;tablir des normes &eacute;thiques claires et des processus de responsabilit&eacute; pour les syst&egrave;mes d'IA.</p> <h2>Chapitre 7 : L'avenir de l'IA</h2> <p>L'avenir de l'IA est incroyablement prometteur, mais il est important de continuer &agrave; surveiller les implications &eacute;thiques pour garantir que l'IA soit utilis&eacute;e de mani&egrave;re responsable. En travaillant ensemble, nous pouvons tirer parti des avantages de l'IA tout en minimisant les inconv&eacute;nients potentiels. &Agrave; mesure que l'IA continue de se d&eacute;velopper, il est important de poursuivre les discussions sur les enjeux &eacute;thiques pour garantir un futur positif pour tous.</p> <p>En conclusion, l'IA est en train de changer notre monde de mani&egrave;re significative et il est important de prendre en compte les avantages, les inconv&eacute;nients et les enjeux &eacute;thiques li&eacute;s &agrave; son utilisation. La gouvernance jouera un r&ocirc;le crucial dans la d&eacute;termination de la direction que prendra l'IA &agrave; l'avenir et il est important de continuer &agrave; surveiller les implications &eacute;thiques pour garantir que l'IA soit utilis&eacute;e de mani&egrave;re responsable.</p> </div> </div> </div> <div class=\"flex justify-between\"> <div class=\"text-gray-400 flex self-end lg:self-center justify-center mt-2 gap-3 md:gap-4 lg:gap-1 lg:absolute lg:top-0 lg:translate-x-full lg:right-0 lg:mt-0 lg:pl-2 visible\">&nbsp;</div> </div> </div> </div> </div> <div class=\"w-full h-32 md:h-48 flex-shrink-0\">&nbsp;</div> </div> </div> </div> </div> <div class=\"absolute bottom-0 left-0 w-full border-t md:border-t-0 dark:border-white/20 md:border-transparent md:dark:border-transparent md:bg-vert-light-gradient bg-white dark:bg-gray-800 md:!bg-transparent dark:md:bg-vert-dark-gradient\"><form class=\"stretch mx-2 flex flex-row gap-3 pt-2 last:mb-2 md:last:mb-6 lg:mx-auto lg:max-w-3xl lg:pt-6\" data-dashlane-rid=\"1c45e80bb5dfedd7\" data-form-type=\"\"> <div class=\"relative flex h-full flex-1 md:flex-col\"> <div class=\"flex ml-1 mt-1.5 md:w-full md:m-auto md:mb-2 gap-0 md:gap-2 justify-center\">&nbsp;</div> <div class=\"flex flex-col w-full py-2 flex-grow md:py-3 md:pl-4 relative border border-black/10 bg-white dark:border-gray-900/50 dark:text-white dark:bg-gray-700 rounded-md shadow-[0_0_10px_rgba(0,0,0,0.10)] dark:shadow-[0_0_15px_rgba(0,0,0,0.10)]\">&nbsp;</div> </div> </form></div>"
            },
            new Book()
            {
                Title = "La ligne d'ombre",
                Author = "Joseph Conrad",
                Price = 25,
                Genres = new List<Genre>() { Classic, Aventure },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Guerre et Paix",
                Author = "Léon Tolstoï",
                Price = 35,
                Genres = new List<Genre>() { Classic, Histoire },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "1984",
                Author = "George Orwell",
                Price = 22,
                Genres = new List<Genre>() { SF, Anti },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "L'étranger",
                Author = "Albert Camus",
                Price = 18,
                Genres = new List<Genre>() { Social, Ex },
                Content = "<H1>Salut</H1>"
            },
            new Book()
            {
                Title = "Les trois mousquetaires",
                Author = "Alexandre Dumas",
                Price = 30,
                Genres = new List<Genre>() { Classic, Aventure },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Les frères Karamazov",
                Author = "Fédor Dostoïevski",
                Price = 40,
                Genres = new List<Genre>() { Classic, Social },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Les Misérables",
                Author = "Victor Hugo",
                Price = 50,
                Genres = new List<Genre>() { Classic, Histoire },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "L'Énéide",
                Author = "Virgile",
                Price = 27,
                Genres = new List<Genre>() { Classic, Histoire },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Le portrait de Dorian Gray",
                Author = "Oscar Wilde",
                Price = 20,
                Genres = new List<Genre>() { Classic, Tragedie },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Les Rougon-Macquart",
                Author = "Emile Zola",
                Price = 35,
                Genres = new List<Genre>() { Classic, Mystere },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Les Hauts de Hurlevent",
                Author = "Emily Bronte",
                Price = 28,
                Genres = new List<Genre>() { Classic, Tragedie },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Les Aventures de Tom Sawyer",
                Author = "Mark Twain",
                Price = 21,
                Genres = new List<Genre>() { Classic, Jeunesse },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Le Meilleur des Mondes",
                Author = "Aldous Huxley",
                Price = 25,
                Genres = new List<Genre>() { SF, Anti },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "La Vie devant soi",
                Author = "Romain Gary",
                Price = 22,
                Genres = new List<Genre>() { Roman, Social },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "L'Écume des jours",
                Author = "Boris Vian",
                Price = 18,
                Genres = new List<Genre>() { Roman, Fantastique },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Les Fourmis",
                Author = "Bernard Werber",
                Price = 32,
                Genres = new List<Genre>() { Roman, SF },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Le Cycle de Dune",
                Author = "Frank Herbert",
                Price = 40,
                Genres = new List<Genre>() { SF, Aventure },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "L'Alchimiste",
                Author = "Paulo Coelho",
                Price = 27,
                Genres = new List<Genre>() { Roman, Mystere },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            },
            new Book()
            {
                Title = "Les Carnets de Guerre",
                Author = "Antoine de Saint-Exupéry",
                Price = 20,
                Genres = new List<Genre>() { Classic, Aventure },
                Content = "<h1>Chapitre 1 : Le commencement</h1> <p>Il &eacute;tait une fois un jeune gar&ccedil;on nomm&eacute; Tom, qui vivait dans un petit village au bord de la for&ecirc;t. Un jour, en explorant la for&ecirc;t, Tom a d&eacute;couvert un arbre magique qui lui a accord&eacute; un v&oelig;u. Tom a souhait&eacute; devenir un h&eacute;ros pour aider les gens de son village.</p> <p>Le lendemain, Tom a &eacute;t&eacute; approch&eacute;"
            }
            );
            // Vous pouvez initialiser la BDD ici

            bookDbContext.SaveChanges();
        }
    }
}