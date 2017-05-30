using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteExample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelloPage : ContentPage
    {
        public HelloPage()
        {
            InitializeComponent();
            //https://www.google.cz/search?q=happy+smile+icon+drawing&source=lnms&tbm=isch&sa=X&ved=0ahUKEwiBxpjFiIbUAhXCSBQKHVmCAK8Q_AUICigB&biw=1920&bih=925#imgrc=Jlg5R-FFTAKzWM:
            //https://thumbs.dreamstime.com/z/medieval-weapons-icons-vector-illustration-47855259.jpg
            var obrazek = new Image { Aspect = Aspect.AspectFit };
            obrazek.Source = ImageSource.FromResource("SQLiteExample.logo_village.png");
            obrazek.Source = "@drawable/logo_village.png";
        }
    }
}
