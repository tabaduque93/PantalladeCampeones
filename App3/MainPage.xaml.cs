using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace App3
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            Fondo.Visibility = Visibility.Visible;
            Fondo.Play();
        }

        void verJugadores(object sender, RoutedEventArgs e)
        {
            Fondo2.Visibility = Visibility.Visible;
            Fondo.Source = new Uri(this.BaseUri, "/Assets/Loop_VerJugadoresSombra.mp4");
            Fondo.Visibility = Visibility.Collapsed;
            FondoTeo.Source = new Uri(this.BaseUri, "/Assets/Teo_seleccion.mp4");
            FondoMiguel.Source = new Uri(this.BaseUri, "/Assets/Borja_seleccion.mp4");
            FondoMarlon.Source = new Uri(this.BaseUri, "/Assets/Piedrahita_seleccion.mp4");
            FondoFredy.Source = new Uri(this.BaseUri, "/Assets/Hinestroza_seleccion.mp4");
            FondoSebastian.Source = new Uri(this.BaseUri, "/Assets/Viera_Seleccion.mp4");
            FondoDidier.Source = new Uri(this.BaseUri, "/Assets/Moreno_Seleccion.mp4");
            FondoTodos.Source = new Uri(this.BaseUri, "/Assets/ver_grupo.mp4");
            Fondo2.IsLooping = false;
            Fondo2.Play();
            btnVoyPaEsa.Visibility = Visibility.Collapsed;
            btnIndividual.Visibility = Visibility.Collapsed;
            btnCapturar.Visibility = Visibility.Collapsed;
            btnCapturar.Margin = new Thickness(336, 869, 0, 0);
            Fondo2.MediaEnded += finVideo2;
        }

        void finVideo2(object sender, RoutedEventArgs e)
        {
            Fondo.Visibility = Visibility.Visible;
            Fondo2.Visibility = Visibility.Collapsed;
            
            Fondo.IsLooping = true;
            Fondo.Play();

            // Mostrar los botones de los jugadores
            btnTeofilo.Visibility = Visibility.Visible;
            btnFredy.Visibility = Visibility.Visible;
            btnMiguel.Visibility = Visibility.Visible;
            btnSebastian.Visibility = Visibility.Visible;
            btnMarlon.Visibility = Visibility.Visible;
            btnDidier.Visibility = Visibility.Visible;
            btnTodos.Visibility = Visibility.Visible;
        }

        void finTeo(object sender, RoutedEventArgs e)
        {

            FondoTeo.Visibility = Visibility.Collapsed;
            Fondo.Visibility = Visibility.Visible;
            Fondo.IsLooping = true;
            Fondo.Play();
            btnCapturar.Visibility = Visibility.Visible;
        }

        void finMiguel(object sender, RoutedEventArgs e)
        {
            FondoMiguel.Visibility = Visibility.Collapsed;
            Fondo.Visibility = Visibility.Visible;
            Fondo.IsLooping = true;
            Fondo.Play();
            btnCapturar.Visibility = Visibility.Visible;
        }

        void finMarlon(object sender, RoutedEventArgs e)
        {
            FondoMarlon.Visibility = Visibility.Collapsed;
            Fondo.Visibility = Visibility.Visible;
            Fondo.IsLooping = true;
            Fondo.Play();
            btnCapturar.Visibility = Visibility.Visible;
        }

        void finFredy(object sender, RoutedEventArgs e)
        {
            FondoFredy.Visibility = Visibility.Collapsed;
            Fondo.Visibility = Visibility.Visible;
            Fondo.IsLooping = true;
            Fondo.Play();
            btnCapturar.Visibility = Visibility.Visible;
        }

        void finSebastian(object sender, RoutedEventArgs e)
        {
            FondoSebastian.Visibility = Visibility.Collapsed;
            Fondo.Visibility = Visibility.Visible;
            Fondo.IsLooping = true;
            Fondo.Play();
            btnCapturar.Visibility = Visibility.Visible;
        }

        void finDidier(object sender, RoutedEventArgs e)
        {
            FondoDidier.Visibility = Visibility.Collapsed;
            Fondo.Visibility = Visibility.Visible;
            Fondo.IsLooping = true;
            Fondo.Play();
            btnCapturar.Visibility = Visibility.Visible;
        }

        void finTodos(object sender, RoutedEventArgs e)
        {
            FondoTodos.Visibility = Visibility.Collapsed;
            Fondo.Visibility = Visibility.Visible;
            Fondo.IsLooping = true;
            Fondo.Play();
            btnCapturar.Margin = new Thickness(310, 1100, 0 ,0);
            btnCapturar.Visibility = Visibility.Visible;
            btnIndividual.Visibility = Visibility.Visible;
        }

        void seleccionarJugador(object sender, RoutedEventArgs e)
        {
            Button boton = sender as Button;
            switch (boton.Name)
            {
                case "btnTeofilo":
                    Fondo.Source = new Uri(this.BaseUri, "/Assets/TeoLoop.mp4");
                    Fondo.Visibility = Visibility.Collapsed;
                    FondoTeo.Visibility = Visibility.Visible;
                    habilitarBtnJugadores("teofilo");
                    FondoTeo.Play();
                    FondoTeo.MediaEnded += finTeo;
                    break;

                case "btnFredy":

                    Fondo.Source = new Uri(this.BaseUri, "/Assets/Hinestroza_Loop.mp4");
                    Fondo.Visibility = Visibility.Collapsed;
                    FondoFredy.Visibility = Visibility.Visible;
                    habilitarBtnJugadores("fredy");
                    FondoFredy.Play();
                    FondoFredy.MediaEnded += finFredy;
                    break;

                case "btnMiguel":

                    Fondo.Source = new Uri(this.BaseUri, "/Assets/Borja_Loop.mp4");
                    Fondo.Visibility = Visibility.Collapsed;
                    FondoMiguel.Visibility = Visibility.Visible;
                    habilitarBtnJugadores("miguel");
                    FondoMiguel.Play();
                    FondoMiguel.MediaEnded += finMiguel;
                    break;

                case "btnSebastian":
                    Fondo.Source = new Uri(this.BaseUri, "/Assets/Viera_Loop.mp4");
                    Fondo.Visibility = Visibility.Collapsed;
                    FondoSebastian.Visibility = Visibility.Visible;
                    habilitarBtnJugadores("sebastian");
                    FondoSebastian.Play();
                    FondoSebastian.MediaEnded += finSebastian;
                    break;

                case "btnMarlon":
                    Fondo.Source = new Uri(this.BaseUri, "/Assets/Piedrahita_Loop.mp4");
                    Fondo.Visibility = Visibility.Collapsed;
                    FondoMarlon.Visibility = Visibility.Visible;
                    habilitarBtnJugadores("marlon");
                    FondoMarlon.Play();
                    FondoMarlon.MediaEnded += finMarlon;
                    break;

                case "btnDidier":
                    Fondo.Source = new Uri(this.BaseUri, "/Assets/Moreno_Loop.mp4");
                    Fondo.Visibility = Visibility.Collapsed;
                    FondoDidier.Visibility = Visibility.Visible;
                    habilitarBtnJugadores("didier");
                    FondoDidier.Play();
                    FondoDidier.MediaEnded += finDidier;
                    break;

                case "btnTodos":
                    Fondo2.Source = new Uri(this.BaseUri, "Assets/Volver_Individual.mp4");
                    Fondo.Source = new Uri(this.BaseUri, "/Assets/LoopGrupo.mp4");
                    Fondo.Visibility = Visibility.Collapsed;
                    FondoTodos.Visibility = Visibility.Visible;
                    habilitarBtnJugadores("todos");
                    btnCapturar.Visibility = Visibility.Collapsed;
                    FondoTodos.Play();
                    FondoTodos.MediaEnded += finTodos;
                    break;

                default:
                    break;
            }
        }
        void capturar(object sender, RoutedEventArgs e)
        {

        }

        void habilitarBtnJugadores(String jugador)
        {
            btnTeofilo.Visibility = Visibility.Visible;
            btnMiguel.Visibility = Visibility.Visible;
            btnMarlon.Visibility = Visibility.Visible;
            btnFredy.Visibility = Visibility.Visible;
            btnSebastian.Visibility = Visibility.Visible;
            btnDidier.Visibility = Visibility.Visible;
            btnTodos.Visibility = Visibility.Visible;

            switch (jugador)
            {

                case "teofilo":
                    btnTeofilo.Visibility = Visibility.Collapsed;
                    break;

                case "fredy":
                    btnFredy.Visibility = Visibility.Collapsed;
                    break;

                case "marlon":
                    btnMarlon.Visibility = Visibility.Collapsed;
                    break;

                case "sebastian":
                    btnSebastian.Visibility = Visibility.Collapsed;
                    break;

                case "didier":
                    btnDidier.Visibility = Visibility.Collapsed;
                    break;

                case "miguel":
                    btnMiguel.Visibility = Visibility.Collapsed;
                    break;

                case "todos":
                    btnTeofilo.Visibility = Visibility.Collapsed;
                    btnMiguel.Visibility = Visibility.Collapsed;
                    btnMarlon.Visibility = Visibility.Collapsed;
                    btnFredy.Visibility = Visibility.Collapsed;
                    btnSebastian.Visibility = Visibility.Collapsed;
                    btnDidier.Visibility = Visibility.Collapsed;
                    btnTodos.Visibility = Visibility.Collapsed;
                    break;
            }
        }
    }
}
