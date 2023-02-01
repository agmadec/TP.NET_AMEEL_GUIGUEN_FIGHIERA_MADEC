using System.ComponentModel;
using System.Windows.Controls;
using System.Windows;
using WPF.Reader.Model;

namespace WPF.Reader.ViewModel
{
    public class WebBrowserHelper
    {
        public static readonly DependencyProperty BodyProperty =
            DependencyProperty.RegisterAttached("Body", typeof(string), typeof(WebBrowserHelper), new PropertyMetadata(OnBodyChanged));

        public static string GetBody(DependencyObject dependencyObject)
        {
            return (string)dependencyObject.GetValue(BodyProperty);
        }

        public static void SetBody(DependencyObject dependencyObject, string body)
        {
            dependencyObject.SetValue(BodyProperty, body);
        }

        private static void OnBodyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var webBrowser = (WebBrowser)d;
            webBrowser.NavigateToString((string)e.NewValue);
        }
    }
    class ReadBook : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Book CurrentBook { get; init; }

        public ReadBook(Book book)
        {
            this.CurrentBook = book;
        }
    }

    /* Cette classe sert juste a afficher des donnée de test dans le designer */
    class InDesignReadBook : ReadBook
    {
        public InDesignReadBook() : base(new Book()
        {
            Title = "Test Title",
            Author = "Test Author",
            Content = "<h1>Lorem Ipsum</h1> <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc venenatis hendrerit eros, a sagittis erat pellentesque id. Etiam porttitor lectus elementum molestie efficitur. Cras vehicula blandit dui et euismod. Suspendisse potenti. Pellentesque eu odio finibus, ornare leo sed, cursus quam. In sodales nisi diam, non fermentum neque cursus vitae. Nullam blandit vulputate feugiat. Sed feugiat tortor at accumsan ornare. Integer fermentum, orci quis aliquet vulputate, ligula sapien tempor magna, nec eleifend neque odio in justo. Sed sit amet nisi erat.</p> <p>Aliquam mattis nulla eu diam tempus laoreet. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nullam nibh erat, vehicula sit amet mollis sit amet, faucibus vitae risus. Nullam placerat nisl tempus vestibulum porttitor. Phasellus vel enim eu leo fermentum commodo. Nunc lobortis accumsan facilisis. Curabitur pharetra fermentum lacus, fermentum accumsan nulla consequat in. Nullam a tellus ligula. Mauris quis vulputate dui, eget tempus ligula. Cras efficitur lobortis suscipit. Nam ipsum odio, tempor eget pharetra a, volutpat quis ipsum.</p> <p>&nbsp;</p> <h2>Lorem Ipsum 2: Le retour de Lorem</h2> <p>Quisque eu tellus eros. Cras sit amet quam vitae nisi rutrum rutrum id ut dolor. Maecenas fermentum felis sed mauris congue, ac egestas massa tristique. Pellentesque varius, tortor in vestibulum venenatis, erat ante interdum ligula, luctus sagittis sem nibh nec neque. Proin laoreet leo sem, id molestie libero volutpat ut. Aenean tincidunt dignissim congue. Donec condimentum sed ex a rutrum. Fusce vulputate nulla sed gravida bibendum. Nullam varius lacus vel placerat scelerisque.</p> <p>Phasellus vitae luctus lectus, id pharetra neque. Quisque volutpat orci vitae nibh accumsan, sit amet maximus mauris auctor. Etiam sem tellus, euismod vel scelerisque eget, sagittis eget enim. Suspendisse et dui in enim porta iaculis. Ut varius luctus sagittis. Curabitur elementum nisi lorem, in commodo mi laoreet quis. Nulla vel mauris sit amet libero pharetra pharetra. Nam placerat elit non lorem tincidunt, non pulvinar risus ultrices. Vestibulum rutrum ante sed malesuada sollicitudin. Quisque nec lacinia felis. Sed nulla leo, efficitur vel fermentum eu, tristique quis ex. Nulla id vestibulum purus. Etiam mauris enim, mattis id leo ac, tempus pretium magna. Cras ut arcu vitae dolor gravida pellentesque sed vitae velit.</p> <p><span style=\"color: rgb(230, 126, 35);\">Nullam tellus nibh, porttitor vel nunc eget, dictum consectetur ligula. Ut et diam ac arcu interdum placerat. Donec sed risus imperdiet, tempor eros eget, scelerisque ante. Quisque molestie ex libero, ac varius orci tempor ut. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque tellus velit, sodales ut massa quis, tempor auctor augue. Donec dui ipsum, pharetra quis augue vitae, volutpat efficitur nunc. Donec eget tempor libero, id maximus elit. Nulla facilisi. Vivamus finibus, tellus sit amet tincidunt tempus, nisi nibh ultricies dolor, ut laoreet risus dolor et magna. Mauris sit amet molestie mauris. Integer a purus leo. Donec cursus arcu ac velit molestie, vel tempus odio tincidunt. Donec fermentum, tellus sed porta sagittis, quam urna commodo ante, in porta dui purus vitae ligula. Nam sit amet eleifend nisl. Nullam elementum fermentum tellus et euismod.</span></p>"
        })
        {
        }
    }
}
