using System;
using System.Collections.Generic;
using System.Text;
using UDI.XamApp.Models;
using UDI.XamApp.Services;
using Xamarin.Forms;

namespace UDI.XamApp.ViewModels
{
    public class UsuarioGitHubViewModel : BaseViewModel
    {
        private readonly InfoUserGitHubService _service;

        public GithubUser UsuarioGitHub { get; set; }

        public string UserSearch { get; set; }
        public Command BuscarUserCommand { get; set; }

        // datos a mostrar
        private string _Login;
        public string Login { get { return _Login; } set { SetProperty(ref _Login, value); } }

        private string _Url;
        public string Url { get { return _Url; } set { SetProperty(ref _Url, value); } }

        private string _Nombre;
        public string Nombre { get { return _Nombre; } set { SetProperty(ref _Nombre, value); } }

        private string _Empresa;
        public string Empresa { get { return _Empresa; } set { SetProperty(ref _Empresa, value); } }

        private string _Ubicacion;
        public string Ubicacion { get { return _Ubicacion; } set { SetProperty(ref _Ubicacion, value); } }

        private string _Biografia;
        public string Biografia { get { return _Biografia; } set { SetProperty(ref _Biografia, value); } }

        private string _Actualizado;
        public string Actualizado { get { return _Actualizado; } set { SetProperty(ref _Actualizado, value); } }
        public UsuarioGitHubViewModel()
        {
            Title = "Consultar usuario GitHub";
            BuscarUserCommand = new Command(() => BuscarUserGitHub(UserSearch));
            _service = new InfoUserGitHubService();
        }

        private async void BuscarUserGitHub(string userSearch)
        {
            UsuarioGitHub = await _service.GetUserInfoGithub(userSearch);
            Login = UsuarioGitHub.login;
            Url = UsuarioGitHub.url;
            Nombre = UsuarioGitHub.name;
            Empresa = UsuarioGitHub.company?? "";
            Ubicacion = UsuarioGitHub.location;
            Biografia = UsuarioGitHub.bio;
            Actualizado = UsuarioGitHub.updated_at.ToShortDateString();
        }
    }
}
