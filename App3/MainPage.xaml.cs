using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
            Fondo.Visibility = Visibility.Visible;
            Fondo.Play();
        }

        void verJugadores(object sender, RoutedEventArgs e)
        {
            Fondo2.Visibility = Visibility.Visible;
            Fondo.Source = new Uri(this.BaseUri, "/Assets/LoopJugadores.mp4");
            Fondo.Visibility = Visibility.Collapsed;
            Fondo2.IsLooping = false;
            Fondo2.Play();
            btnVoyPaEsa.Visibility = Visibility.Collapsed;
            Fondo2.MediaEnded += Finvideo2;
        }

        void Finvideo2(object sender, RoutedEventArgs e)
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

        void FinTeo(object sender, RoutedEventArgs e)
        {
            Fondo.Visibility = Visibility.Collapsed;
            btnCapturar.Visibility = Visibility.Visible;
            Fondo2.Visibility = Visibility.Visible;
            Fondo2.IsLooping = true;
            Fondo2.Play();
        }

        void seleccionarJugador(object sender, RoutedEventArgs e)
        {
            Button boton = sender as Button;
            String opcionSeleccionada = "";
            switch (boton.Name)
            {
                case "btnTeofilo":
                    opcionSeleccionada = "Teófilo Gutiérrez";
                    Fondo.Source = new Uri(this.BaseUri, "/Assets/Teo_seleccion.mp4");
                    Fondo2.Source = new Uri(this.BaseUri, "/Assets/TeoLoop.mp4");
                    Fondo.Visibility = Visibility.Visible;
                    Fondo2.Visibility = Visibility.Collapsed;
                    Fondo.IsLooping = false;
                    Fondo.Play();
                    Fondo.MediaEnded += FinTeo;
                    break;

                case "btnFredy":
                    opcionSeleccionada = "Fredy Hinestroza";
                    break;

                case "btnMiguel":
                    opcionSeleccionada = "Miguel Borja";
                    break;

                case "btnSebastian":
                    opcionSeleccionada = "Sebastián Viera";
                    break;

                case "btnMarlon":
                    opcionSeleccionada = "Marlon Piedrahita";
                    break;

                case "btnDidier":
                    opcionSeleccionada = "Didier Moreno";
                    break;

                case "btnTodos":
                    opcionSeleccionada = "Todos los jugadores";
                    break;

                default:
                    break;
            }

            ContentDialog contentDialog = new ContentDialog
            {
                Title = "Opción seleccionada",
                Content = opcionSeleccionada,
                CloseButtonText = "Cerrar"
            };

            contentDialog.ShowAsync();
        }
        void capturar(object sender, RoutedEventArgs e)
        {
            ContentDialog contentDialog = new ContentDialog
            {
                Title = "Capturar",
                Content = "Foto",
                CloseButtonText = "Cerrar"
            };

            contentDialog.ShowAsync();
        }
    }
}
