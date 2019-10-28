# UDI.TallerXamarinForms2019
Taller de creacion de aplicaciones moviles con Xamarin Forms en la UDI Octubre 2019

# Taller de creación de una aplicación movil en Xamarin Forms

Iniciamos Visual Studio Community 2019 y creamos un nuevo proyecto.
![Imagen de carga de Visual Studio 2019](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img001.png)

Luego nos aparece una nueva pantalla que nos permite seleccionar el tipo de proyecto a crear. Ubicamos en el ultimo desplegable, como el que aparece en la imagen, Mobile, que es el tipo de aplicaciones de móviles.
![Seleccionanado el tipo de proyecto a crear](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img002.png)

Buscamos en la lista de aplicaciones móviles, una aplicacion Xamarin Forms.
![Ubicamos el proyecto Xamarin Forms](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img003.png)

Presionamos el boton Next, nos muestra las opciones para el nombrado del proyecto.
![Damos los nombres a la solucion y al proyecto](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img004.png)

Colocamos los nombres de la solución y del proyecto y presionamos el boton Create.
![Damos los nombres a la solucion y al proyecto](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img005.png)

Nos muestra la siguiente ventana
![Seleccionamos Plantilla tipo de proyecto Xamarin Forms](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img006.png)

Seleccionamos el check de Mobile Backend que crea un Web API con NET Core para darle soporte a la informacion que manejara el App.
![Seleccionamos Plantilla tipo de proyecto Xamarin Forms](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img007.png)

Se crea una solución con 3 proyectos, el primer proyecto es el proyecto principal, este es el proyecto de Xamarin forms, toda la codificación de la aplicación se realizará en este proyecto. El proyecto Android, el cual es el proyecto para la plataforma Android, en este proyecto algunas cosas particulares de la plataforma se tendrán que codificar en este proyecto, y el proyecto iOS, el cual es para la plataforma de Apple, aquí al igual que en la plataforma de Android se codificara lo particular a esta plataforma.
Ahora ejecutamos el proyecto para verificar que este bien y sin errores. Damos clic en el boton Play de la barra de herramientas como se muestra en la imagen anterior, con esto se lanza el emulador de Android que se haya instalado.
![Ejecutando el proyecto](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img008.png)

Asi se ve nuestra aplicación ejecutándose en el emulador de Android.
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img009.png)

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img010.png)

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img011.png)

# Analizando el proyecto de Xamarin Forms
El proyecto se ha creado y ejecuta, veamos cual es su estructura y que es cada carpeta que hay en el.

![La estructura de la Solucion](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img012.png)


## Proyecto Xamarin Forms

El proyecto de Xamarin forms utiliza un patron de arquitectura llamado MVVM, esto es, Model, View, ViewModel, de alli su nombre, esto se refleja en la estructura de las carpetas del proyecto, este patrón de arquitectura es muy similar a MVC, en este caso el ViewModel hace lo que hace el Controlador en MVC, sin embargo, el ViewModel es mucho más poderoso porque permite realizar Bindings o enlaces con los controles sin codigo.
Tenemos las carpetas:

•	Models

•	Views

•	ViewModels

En cada una de estas carpetas se almacena y ordena lo concerniente a su responsabilidad.
Tenemos una carpeta de Services, los servicios aquí son las diferentes tareas que realiza nuestra aplicación, servicios de conexión a bases de datos locales, servicios de consumir servicios REST API (web services), Servicios de conversión de datos o de transformación de datos, etc.
La carpeta de Dependencies, es donde se reflejan los diferentes paquetes o librerias que utilizamos en nuestro proyecto para ir modelando nuestra aplicación movil.
App.Xaml, es el punto de ingreso a nuestra aplicación en Xamarin forms, esta constituida por dos parte, una parte grafica con extensión xaml, aquí se almacenaran los estilos gráficos de nuestra aplicación, y una parte de codigo con extensión .xaml.cs en donde lanzaremos la pagina inicial de nuestra aplicación y controlaremos los eventos del ciclo de vida de las aplicaciones móviles.

# Configuracion del visor de Xaml para las pantallas

Para configurar el visor de Xaml que es como se ve nuestra pantalla a medida que la vamos dibujando en la pantalla, seguimos los siguientes pasos. Vamos al menu Tools (Herramientas) a la opción Options.. (opciones)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img013.png)

Ubicamos en la lista XAML Designer (Diseñador de XAML), lo expandimos como se muestra en la imagen.
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img014.png)

Seleccionamos las opciones a continuación

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img015.png)

El <b>default document view</b>, hará que se muestre por defecto el diseñador de Xaml.


# Iniciamos nuestra aplicación

Abrimos la carpeta Models, tenemos dos clases Item y HomeMenuItem , Item es el modelo (Entidad) que nos permite capturar datos para el TODO de la aplicación de ejemplo, HomeMenuItem es la clase que nos permite llenar las opciones del menu, contiene dos partes una enumeración, que solo tiene dos opciones y una clase que sirve de modelo a la pantalla que muestra el menu.
Modificamos la enumeración y adicionamos dos nuevas opciones al inicio, como lo vemos en la imagen.
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img016.png)

Luego abrimos la página MainPage.xaml.cs
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img017.png)

Abrimos el archivo y revisamos el codigo, en el constructor de la clase, el constructor lo identificamos porque tiene el mismo nombre de la clase y esta como público, puede o no tener parametros este método constructor.
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img018.png)

Como podemos observar la última línea tiene una opción de MenuPages, aquí es donde esta la informacion que se muestra en el menu, debemos adicionar las dos opciones que deseamos para nuestra aplicación.
Como observamos es una variable de tipo Dictionary en la cual se almacenan las opciones que deseamos aparezcan como menu, por defecto en nuestra aplicacion. Vamos al método NavigateFromMenu, en este es donde lanzamos las diferentes páginas de nuestro menu.
El codigo de este método debe modificarlo de la siguiente manera:
  
      
~~~
        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Login:
                        MenuPages.Add(id, new NavigationPage(new LoginPage()));
                        break;
                    case (int)MenuItemType.Register:
                        MenuPages.Add(id, new NavigationPage(new RegisterPage()));
                        break;
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
~~~
Adicionamos las opciones para Login y para Register, de igual manera podemos agregar las que necesitemos.


# La página de Menu

El menu es otra página, entonces vamos a la pagina del menu que es la página MenuPage.xaml.
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img019.png)

Nuestro menu es un ListView, al cual le hemos asignado un array de manera manual para tener una visión mas exacta de como se vera nuestro menu, en el codigo luego cambiaremos estos valores por los que nosotros necesitamos.
Abrimos MenuPage.xaml.cs y mostramos el codigo C#, en el constructor de la pagina observamos que se llenan las opciones del menu, agregamos las opciones que deseamos se muestren tambien.

Y Ejecutamos nuestra aplicación nuevamente. Ya podemos ver el menu de la aplicación
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img020.png)



# Creando las opciones de Registro y Login 

Para nuestra opción de login necesitamos un Modelo que llamaremos Usuario, crearemos esta clase en la carpeta Models. Damos clic derecho, Add, Class…

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img021.png)

Esto nos abre la ventana para crear una nueva clase en esta carpeta.

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img022.png)

Damos clic al boton Add y nos lleva a la ventana de codigo de C#. La clase va a tener el siguiente codigo:

~~~
namespace UDI.XamApp.Models
{
    public  class Usuario
    {
        public int Iduser { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
~~~

Ahora vamos a crear la Vista, para esto, damos clic derecho en la carpeta Views, Add, New Item…

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img023.png)

Nos muestra la siguiente pantalla:

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img024.png)

Selecionamos Xamarin forms, Content Page, damos el nombre LoginPage y damos clic al boton Add.

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img025.png)
Nos muestra la pantalla para generar la vista de Login.

Lo primero que vamos a hacer, es agregar un nuevo namespace en la vista de XAML, y el BindingContext de la página, esto lo que hace es enlazar la vista con la clase del ViewModel.
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img026.png)

Ahora vamos a pintar nuestra Vista, los primero es eliminar el Label que esta, creamos un Grid, le definimos 6 filas y sus respectivas alturas, además las cajas de texto de captura de datos y un boton de Validación del usuario. La vista queda de la siguiente manera:
~~~
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:d="http://xamarin.com/schemas/2014/forms/design"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             mc:Ignorable="d"
             x:Class="UDI.XamApp.Views.LoginPage1"
             xmlns:vm="clr-namespace:UDI.XamApp.ViewModels">
    <ContentPage.BindingContext>
        <vm:LoginViewModel />
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <StackLayout>
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="40"></RowDefinition>
                    <RowDefinition Height="100"></RowDefinition>
                    <RowDefinition Height="60"></RowDefinition>
                    <RowDefinition Height="60"></RowDefinition>
                    <RowDefinition Height="60"></RowDefinition>
                    <RowDefinition Height="*"></RowDefinition>
                </Grid.RowDefinitions>

                <Entry Placeholder="Ingrese el usuario"
                       Text="{Binding Usuario, Mode=TwoWay}"
                      Grid.Row="2" />

                <Entry Placeholder="Ingrese su Clave"
                       IsPassword="True"
                       Text="{Binding Password, Mode=TwoWay}"
                       Grid.Row="3"/>

                <Button Text="Ingresar" 
                        BorderWidth="20"
                        CornerRadius="40"
                        TextColor="White"
                        BackgroundColor="DarkBlue"
                        Grid.Row="4"
                        Command="{Binding LoginUser}"/>
            </Grid>

        </StackLayout>
    </ContentPage.Content>
</ContentPage>

~~~
Ahora vamos a crear una clase que llamaremos LoginViewModel el cual es la lógica para esta pantalla de nuestra Aplicación Xamarin Forms. Damos clic derecho en la carpeta ViewModel, Add, Class….

La clase del viewmodel queda de la siguiente manera:

~~~
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
                await App.Current.MainPage.DisplayAlert("Error ", 
"Los campos no pueden ser vacios.", "OK");
                return ;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error ",
"Los campos no pueden ser vacios.", "OK");
                return ;
            }
            if(Usuario != "UDIDemo")
            {
                await App.Current.MainPage.DisplayAlert("Error ", 
"Usuario / Clave Invalido", "OK");
                return ;
            }
            if (Password != "UDIDemo*")
            {
                await App.Current.MainPage.DisplayAlert("Error ", 
"Usuario / Clave Invalido", "OK");
                return ;
            }
            await App.Current.MainPage.DisplayAlert("Error ", 
"Usuario Autorizado!!", "OK");
            return  ;
        }
    }
}

~~~
Creamos 3 propiedades, usuario que es para la captura del nombre, password para la clave. y una Comando que responda al evento Tap del boton Ingresar. En el constructor inicializamos la propiedad Title y el Command. Creamos el método que ejecuta el comando y el codigo para este método.

La ventana de Visual Studio se verá asi:

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img027.png)

Ahora crearemos una nueva vista para la opción Register, recordemos que el nombre que le colocamos es RegisterPage, entonces clic derecho en la carpeta Views, Add, new Item seguimos los mismos pasos para crear LoginPage.

La Vista RegisterPage Queda de la siguiente manera:

~~~
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:d="http://xamarin.com/schemas/2014/forms/design"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             mc:Ignorable="d"
             x:Class="UDI.XamApp.Views.RegisterPage"
             xmlns:vm="clr-namespace:UDI.XamApp.ViewModels">
    <ContentPage.BindingContext>
        <vm:RegisterViewModel />
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <StackLayout>
            <Label Text="Nombre"
                HorizontalOptions="CenterAndExpand" />

            <Entry Placeholder="Nombre"
                   Text="{Binding Nombre, Mode=TwoWay}" />
            <Label Text="Apellidos"
                HorizontalOptions="CenterAndExpand" />
            <Entry Placeholder="Apellidos"
                   Text="{Binding Apellido, Mode=TwoWay}" />
            <Label Text="Email"
                HorizontalOptions="CenterAndExpand" />
            <Entry Placeholder="Email" Keyboard="Email"
                   Text="{Binding Email, Mode=TwoWay}" />

            <Button Text="Guardar" Command="{Binding RegisterCommand}"
                    BorderWidth="20" CornerRadius="40"
                    BackgroundColor="DarkCyan"
                    TextColor="White"/>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>

~~~

Se verá de la siguiente manera:

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img028.png)

Ahora crearemos en la carpeta de ViewModels, la clase RegisterViewModel, que tendrá el siguiente codigo:

~~~
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

~~~

Si ejecutamos nuestra aplicación ahora se vera de la siguiente manera:

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img029.png) 
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img030.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img031.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img032.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img033.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img034.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img035.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img036.png)



# Consumo de un API REST desde Xamarin Forms

Para esto utilizamos la clase HttpClient, con la cual nos conectamos al servicio.

El primer ejemplo de consumo de API REST es el servicio que expone GitHub para la informacion del usuario registrado.

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img037.png)

Agregamos dos opciones a la enumeración de las opciones, luego vamos al MainPage.xaml.cs, al método NavigateFromMenu, y alli adicionamos el codigo siguiente:

~~~
    case (int)MenuItemType.UsuarioGitHub:
        MenuPages.Add(id, new NavigationPage(new UsuarioGitHubPage()));
        break;
    case (int)MenuItemType.Paises:
        MenuPages.Add(id, new NavigationPage(new CountriesPage()));
        break;

~~~


Luego debemos ir al MenuPage.xaml.cs y modificar para que quede de la siguiente manera:

~~~
public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Login, Title="Login" },
                new HomeMenuItem {Id = MenuItemType.Register, Title="Registrese" },
                new HomeMenuItem {Id = MenuItemType.UsuarioGitHub, Title="Usuario GitHub" },
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = menuItems;

~~~
La línea 3 del menuItems, es la que vamos a agregar.

Ahora vamos a la carpeta Views en el Explorador de Soluciones, clic derecho, Add, New Item…

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img038.png)

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img039.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img040.png)

Adicionamos el namespace y la sección del bindingcontext de la página:

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img041.png)

Como aun no hemos creado el ViewModel nos aparece un error. Vamos a la carpeta ViewModels en el explorador de la solución, clic derecho, Add, Class…, damos el nombre de la clase UsuarioGitHubViewModel y el boton Add.

Colocamos la clase publica, agregamos dos puntos después del nombre de la clase para indicar que heredamos de la clase BaseViewModel,  creamos el constructor de la clase y alli damos valor a la propiedad Title.

Vamos a la url: https://api.github.com/users/{user}
En donde {user} es el usuario de GitHb a Consultar, en mi caso el valor a enviar a esa url es ralvaradot, que es mi usuario.

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img042.png)

Teniendo la informacion del objeto resultante, lo copiamos y abrimos una segunda ventana en el explorador de internet, esta vez vamos a www.Json2CSharp.com 

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img043.png)

En el espacio en blanco copiamos el objeto resultado del servicio de GitHub.
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img044.png)

Damos clic al boton de Generate, y nos genera la o las clases que conformarían este objeto en formato Json.

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img045.png)

Ahora regresamos a Visual Studio, y en la carpeta de Models creamos una clase que llamaremos GithubUser. En esta clase copiaremos la definición del objeto que nos entregó esta página web.

~~~
using System;
using System.Collections.Generic;
using System.Text;

namespace UDI.XamApp.Models
{
    public class GithubUser
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string blog { get; set; }
        public string location { get; set; }
        public object email { get; set; }
        public bool hireable { get; set; }
        public string bio { get; set; }
        public int public_repos { get; set; }
        public int public_gists { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}

~~~

Ahora regresamos a la vista y la modificamos de la siguiente manera:

~~~
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:d="http://xamarin.com/schemas/2014/forms/design"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             mc:Ignorable="d"
             x:Class="UDI.XamApp.Views.UsuarioGitHubPage"
             xmlns:vm="clr-namespace:UDI.XamApp.ViewModels"
             Title="{Binding Title}">
    <ContentPage.BindingContext>
        <vm:UsuarioGitHubViewModel />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <StackLayout Padding="15" >
            <StackLayout Orientation="Horizontal">
                <Label Text="Usuario GH " VerticalTextAlignment="Center"
                       TextColor="DarkBlue"/>
                <Entry Placeholder="Usuario a buscar" Text="{Binding UserSearch, Mode=TwoWay}" />
                <Button Text="Buscar" Command="{Binding BuscarUserCommand}"
                        BackgroundColor="DarkCyan"
                        CornerRadius="20" BorderWidth="40"
                        TextColor="White"/>
            </StackLayout>
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto"></RowDefinition>
                    <RowDefinition Height="Auto"></RowDefinition>
                    <RowDefinition Height="Auto"></RowDefinition>
                    <RowDefinition Height="Auto"></RowDefinition>
                    <RowDefinition Height="Auto"></RowDefinition>
                    <RowDefinition Height="Auto"></RowDefinition>
                    <RowDefinition Height="Auto"></RowDefinition>
                    <RowDefinition Height="*"></RowDefinition>
                </Grid.RowDefinitions>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto"></ColumnDefinition>
                    <ColumnDefinition Width="*"></ColumnDefinition>
                </Grid.ColumnDefinitions>
                <Label Text="Login: " Grid.Row="0" Grid.Column="0"></Label>
                <Label  Text="{Binding Login, Mode=TwoWay}"
                        Grid.Row="0" Grid.Column="1"/>

                <Label Text="Url: " Grid.Row="1" Grid.Column="0"></Label>
                <Label Text="{Binding Url, Mode=TwoWay}"
                        Grid.Row="1" Grid.Column="1"></Label>

                <Label Text="Nombre: " Grid.Row="2" Grid.Column="0"></Label>
                <Label Text="{Binding Nombre, Mode=TwoWay}"
                        Grid.Row="2" Grid.Column="1"></Label>
                
                <Label Text="Empresa: " Grid.Row="3" Grid.Column="0"></Label>
                <Label Text="{Binding Empresa, Mode=TwoWay}"
                        Grid.Row="3" Grid.Column="1"></Label>
                
                <Label Text="Ubicacion: " Grid.Row="4" Grid.Column="0"></Label>
                <Label Text="{Binding Ubicacion, Mode=TwoWay}"
                        Grid.Row="4" Grid.Column="1"></Label>
                
                <Label Text="Biografia: " Grid.Row="5" Grid.Column="0"></Label>
                <Label Text="{Binding Biografia, Mode=TwoWay}"
                        Grid.Row="5" Grid.Column="1"></Label>
                
                <Label Text="Actualizado: " Grid.Row="6" Grid.Column="0"></Label>
                <Label Text="{Binding Actualizado, Mode=TwoWay}"
                        Grid.Row="6" Grid.Column="1"></Label>
            </Grid>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>

~~~

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img046.png)

Vamos a la carpeta de Services en el Explorador de soluciones, clic derecho, Add, Class, y como nombre InfoUserGitHubService. Y le agregamos el siguiente codigo:

~~~
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UDI.XamApp.Models;

namespace UDI.XamApp.Services
{
    public class InfoUserGitHubService
    {
        const string UrlService = "https://api.github.com/users/";

        public async Task<GithubUser> GetUserInfoGithub(string name)
        {
            using (var client = new HttpClient())
            {
                // recursos 
                client.BaseAddress = new Uri(UrlService);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(
                        "application/json")
                    );
                var url = UrlService + name;
                HttpResponseMessage response = new HttpResponseMessage();
                try
                {
                    response = await client.GetAsync(url);
                }
                catch (Exception)
                {
                    // Logger
                    throw;
                }

                GithubUser lista = new GithubUser();
                if (response.IsSuccessStatusCode)
                {
                    // Convertimos el resultado en una cadena o string
                    var result = await response.Content.ReadAsStringAsync();
                    try
                    {
                        // Convertimos la cadena a objetos Json
                        var lis = JsonConvert.DeserializeObject<GithubUser>(result,
                                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                        lista = lis;
                    }
                    catch (Exception)
                    {
                        // Logger
                        throw;
                    }
                }
                return lista;
            };
        }
    }
}

~~~

Ahora regresamos a la clase UsuarioGitHubViewModel, y creamos una propiedad del tipo de este modelo GithubUser, que acabamos de crear. Creamos una propiedad UserSearch, que es donde capturamos el usuario de Github a buscar y visualizar la informacion en nuestra app.  Agregamos una propiedda de tipo Command y la llamamos BuscarUserCommand, este es el comando que responde al evento Tap o click del boton en nuestro formulario. 

Luego creamos las propiedades para los datos a mostrar en el formulario, estas propiedades son:

•	Login

•	Url

•	Nombre

•	Empresa

•	Biografia

•	Actualizado



Cada una de estas propiedades debe seguir el siguiente esquema en su definición:

~~~
private string _Login;
public string Login { get { return _Login; } set { SetProperty(ref _Login, value); } }

~~~


Con esto logramos hacer que funcione el patron MVVM que nos permite realizar el Binding de los datos desde el ViewModel a la View (Vista) y mostrarlos en la pantalla.

El codigo completo del ViewModel es el siguiente:

~~~
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
            //SetProperty("Login", UsuarioGitHub.login);
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

~~~

Ahora ejecutamos la aplicación y vemos las pantallas de los resultados de la ejecución de la aplicación:

![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img047.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img048.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img049.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img050.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img051.png)
![](https://raw.githubusercontent.com/ralvaradot/UDI.TallerXamarinForms2019/master/Assets/T1Img052.png)



