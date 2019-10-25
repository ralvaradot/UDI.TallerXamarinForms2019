using Xamarin.Forms;

namespace UDI.XamApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Usuario { get; set; }

        public string Password { get; set; }


        public Command LoginUser { get; set; }
        public LoginViewModel()
        {
            Title = "Ingresar Credenciales";
            LoginUser = new Command( () =>  Verifiedcredentials());
        }

        private async void Verifiedcredentials()
        {
            if (string.IsNullOrEmpty(Usuario))
            {
                await App.Current.MainPage.DisplayAlert("Error ", "Los campos no pueden ser vacios.", "OK");
                return ;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error ","Los campos no pueden ser vacios.", "OK");
                return ;
            }
            if(Usuario != "UDIDemo")
            {
                await App.Current.MainPage.DisplayAlert("Error ", "Usuario / Clave Invalido", "OK");
                return ;
            }
            if (Password != "UDIDemo*")
            {
                await App.Current.MainPage.DisplayAlert("Error ", "Usuario / Clave Invalido", "OK");
                return ;
            }
            await App.Current.MainPage.DisplayAlert("Error ", "Usuario Autorizado!!", "OK");
            return  ;
        }
    }
}
