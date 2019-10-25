using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.XamApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UDI.XamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioGitHubPage : ContentPage
    {
       // UsuarioGitHubViewModel vm;

        public UsuarioGitHubPage()
        {
            //vm = new UsuarioGitHubViewModel();

            InitializeComponent();
           // BindingContext = vm;
        }
    }
}