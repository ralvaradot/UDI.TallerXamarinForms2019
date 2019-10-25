using System;
using System.Collections.Generic;
using System.Text;
using UDI.XamApp.Models;
using UDI.XamApp.Services;
using Xamarin.Forms;

namespace UDI.XamApp.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly CountriesAPIService _service;

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public Command RegisterCommand { get; set; }

        public RegisterViewModel()
        {
            Title = "Registro de Usuario";
            RegisterCommand = new Command(() => SaveRegister());

            _service = new CountriesAPIService();
        }

        private async void SaveRegister()
        {
            // Datos Guardados
            ;
            await App.Current.MainPage.DisplayAlert("Registro Usuario ", "Se ha registrado como usuario.", "OK");
            CleanFields();

            GithubUser country = await _service.GetCountryByName("ralvaradot");
        }

        private void CleanFields()
        {
            Nombre = String.Empty;
            Apellido = String.Empty;
            Email = String.Empty;
        }
    }
}
