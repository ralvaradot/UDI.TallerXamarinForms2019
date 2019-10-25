using System;
using System.Collections.Generic;
using System.Text;

namespace UDI.XamApp.Models
{
    public enum MenuItemType
    {
        Login,
        Register,
        UsuarioGitHub,
        Paises,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
