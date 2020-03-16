using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

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
            //Iniciar la app en modo Full Screen
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;

            //Colocar transparente la barra de titulo del programa
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ForegroundColor = Windows.UI.Colors.Transparent;
            titleBar.BackgroundColor = Windows.UI.Colors.Transparent;
            titleBar.ButtonForegroundColor = Windows.UI.Colors.Transparent;
            titleBar.ButtonBackgroundColor = Windows.UI.Colors.Transparent;
            titleBar.ButtonHoverForegroundColor = Windows.UI.Colors.Transparent;
            titleBar.ButtonHoverBackgroundColor = Windows.UI.Colors.Transparent;
            titleBar.ButtonPressedForegroundColor = Windows.UI.Colors.Transparent;
            titleBar.ButtonPressedBackgroundColor = Windows.UI.Colors.Transparent;

            this.InitializeComponent();

            Fondo.Visibility = Visibility.Visible;
            Fondo.Play();
        }

        private void verJugadores(object sender, RoutedEventArgs e)
        {

            sonarAudio("clic");
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
            finOpcionSelecionada(FondoTeo);
        }

        void finMiguel(object sender, RoutedEventArgs e)
        {
            finOpcionSelecionada(FondoMiguel);
        }

        void finMarlon(object sender, RoutedEventArgs e)
        {
            finOpcionSelecionada(FondoMarlon);
        }

        void finFredy(object sender, RoutedEventArgs e)
        {
            finOpcionSelecionada(FondoFredy);
        }

        void finSebastian(object sender, RoutedEventArgs e)
        {
            finOpcionSelecionada(FondoSebastian);
        }

        void finDidier(object sender, RoutedEventArgs e)
        {
            finOpcionSelecionada(FondoDidier);
        }

        void finTodos(object sender, RoutedEventArgs e)
        {
            FondoTodos.Visibility = Visibility.Collapsed;
            Fondo.Visibility = Visibility.Visible;
            Fondo.IsLooping = true;
            Fondo.Play();
            btnCapturar.Margin = new Thickness(310, 1100, 0, 0);
            btnCapturar.Visibility = Visibility.Visible;
            btnIndividual.Visibility = Visibility.Visible;
        }

        void seleccionarJugador(object sender, RoutedEventArgs e)
        {
            sonarAudio("clic");
            btnCapturar.Visibility = Visibility.Collapsed;

            Button boton = sender as Button;

            switch (boton.Name)
            {
                case "btnTeofilo":
                    establecerFondoLoop("/Assets/Teo_LoopLong.mp4", FondoTeo, "teofilo");
                    break;

                case "btnFredy":
                    establecerFondoLoop("/Assets/Hinestroza_Loop.mp4", FondoFredy, "fredy");
                    break;

                case "btnMiguel":
                    establecerFondoLoop("/Assets/Borja_Loop.mp4", FondoMiguel, "miguel");
                    break;

                case "btnSebastian":
                    establecerFondoLoop("/Assets/Viera_Loop.mp4", FondoSebastian, "sebastian");
                    break;

                case "btnMarlon":
                    establecerFondoLoop("/Assets/Piedrahita_Loop.mp4", FondoMarlon, "marlon");
                    break;

                case "btnDidier":
                    establecerFondoLoop("/Assets/Moreno_Loop.mp4", FondoDidier, "didier");
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
        async void capturar(object sender, RoutedEventArgs e)
        {
            sonarAudio("clic");

            MediaElement sonido = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile fileJunior = await folder.GetFileAsync("dalejunior.mp3");
            var streamJunior = await fileJunior.OpenAsync(Windows.Storage.FileAccessMode.Read);
            sonido.SetSource(streamJunior, fileJunior.ContentType);

            String videoJugador = Fondo.Source.ToString();
            videoJugador = videoJugador.Split("Assets/").Last();

            btnEnviar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            correoText.Visibility = Visibility.Visible;
            btnCapturar.Visibility = Visibility.Collapsed;
            habilitarBtnJugadores("todos");
            btnIndividual.Visibility = Visibility.Collapsed;

            switch (videoJugador)
            {
                case "Teo_LoopLong.mp4":
                    escribirJugadorTxt("PLAYER 1");
                    FondoTeo.Visibility = Visibility.Collapsed;
                    break;

                case "Borja_Loop.mp4":
                    escribirJugadorTxt("PLAYER 2");
                    FondoMiguel.Visibility = Visibility.Collapsed;
                    break;

                case "Piedrahita_Loop.mp4":
                    escribirJugadorTxt("PLAYER 3");
                    FondoMarlon.Visibility = Visibility.Collapsed;
                    break;

                case "Hinestroza_Loop.mp4":
                    escribirJugadorTxt("PLAYER 4");
                    FondoFredy.Visibility = Visibility.Collapsed;
                    break;

                case "Viera_Loop.mp4":
                    escribirJugadorTxt("PLAYER 5");
                    FondoSebastian.Visibility = Visibility.Collapsed;
                    break;

                case "Moreno_Loop.mp4":
                    escribirJugadorTxt("PLAYER 6");
                    FondoDidier.Visibility = Visibility.Collapsed;
                    break;

                case "LoopGrupo.mp4":
                    escribirJugadorTxt("PLAYER 7");
                    FondoTodos.Visibility = Visibility.Collapsed;
                    break;
            }

            ImgCargando.Visibility = Visibility.Visible;
            var view = ApplicationView.GetForCurrentView();
            view.ExitFullScreenMode();

            await Task.Delay(5000);

            while (!finCaptura())
            {
                await Task.Delay(1000);
            }

            sonido.Stop();
            string usuario = "USER";
            //string usuario = "Sistra Dev BE";


            string rutaFoto = @"C:\Users\" + usuario + @"\AppData\Local\Packages\9e44d609-57f4-47ef-8e9f-5d0b19eccf1e_6yj39zyq0cs5j\LocalState\Fotos\FOTO.png";
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.UriSource = new Uri(rutaFoto);
            bitmapImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            ImgFoto.Source = bitmapImage;

            view.TryEnterFullScreenMode();
            ImgCargando.Visibility = Visibility.Collapsed;
            Fondo2.Source = new Uri(this.BaseUri, "/Assets/VerJugadoresSombras.mp4");
            ImgTeclado.Visibility = Visibility.Visible;
            gridTeclado.Visibility = Visibility.Visible;
            ImgFoto.Visibility = Visibility.Visible;
            Fondo.Source = new Uri(this.BaseUri, "/Assets/Loop_Inicial.mp4");
            Fondo.IsLooping = true;
            sonido.Stop();
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

        void establecerFondoLoop(String rutaAsset, MediaElement fondoJugador, String jugador)
        {

            Fondo.Source = new Uri(this.BaseUri, rutaAsset);
            Fondo.Visibility = Visibility.Collapsed;
            fondoJugador.Visibility = Visibility.Visible;
            habilitarBtnJugadores(jugador);
            fondoJugador.Play();

            switch (jugador)
            {
                case "teofilo":
                    fondoJugador.MediaEnded += finTeo;
                    break;
                case "marlon":
                    fondoJugador.MediaEnded += finMarlon;
                    break;
                case "fredy":
                    fondoJugador.MediaEnded += finFredy;
                    break;
                case "didier":
                    fondoJugador.MediaEnded += finDidier;
                    break;
                case "sebastian":
                    fondoJugador.MediaEnded += finSebastian;
                    break;
                case "miguel":
                    fondoJugador.MediaEnded += finMiguel;
                    break;
            }
        }

        void finOpcionSelecionada(MediaElement fondoJugador)
        {
            fondoJugador.Visibility = Visibility.Collapsed;
            Fondo.Visibility = Visibility.Visible;
            Fondo.IsLooping = true;
            Fondo.Play();
            btnCapturar.Visibility = Visibility.Visible;
        }

        private async void validarEmail(object sender, RoutedEventArgs e)
        {
            String email = correoText.Text.ToString();

            if (emailValido(email))
            {
                sonarAudio("clic");
                ImgTeclado.Visibility = Visibility.Collapsed;
                ImgFoto.Visibility = Visibility.Collapsed;
                gridTeclado.Visibility = Visibility.Collapsed;
                ImgEnviandoEmail.Visibility = Visibility.Visible;
                await Task.Delay(2000); // Se pausa durante 1 segundos para mostrar la imagen de Enviando

                // Credentials
                //String SMTP_USERNAME = "AKIAQJIZPMK43GHT3P4J";
                String SMTP_USERNAME = "AKIASASQOR57CM2J2W4M";
                //String SMTP_PASSWORD = "BOFsSsxD2c0FyPMfjdyboWQCKqQwFQdzom9cq1khPXBy";
                String SMTP_PASSWORD = "BE8AELg6H+16lI6mgXUmLKKwAo3040240j0gHhCKGcP8";
                String HOST = "email-smtp.us-west-2.amazonaws.com";
                // String HOST = "smtp.mailtrap.io";
                int PORT = 587;

                // General Data
                String FROM = "no-reply@sistra.com.co";
                String FROMNAME = "Pantalla de Campeones";
                String SUBJECT = "¡Tu foto! #JuniorTuPapá";

                // User Data
                String TO = email;

                // Content Message
                String BODY = "<h4>¡Gracias por visitarnos! Recuerda compartir tu experiencia con la Pantalla de Campeones utilizando nuestros hashtags.</h4>" +
                    "<h3>#VamosJunior #FamiliaRojiblanca #PantallaDeCampeones</h3>";
                string usuario = "USER";
                //string usuario = "Sistra Dev BE";
                String photo = @"C:\Users\" + usuario + @"\AppData\Local\Packages\9e44d609-57f4-47ef-8e9f-5d0b19eccf1e_6yj39zyq0cs5j\LocalState\Fotos\FOTO.png";
                Attachment dataPhoto = new Attachment(photo, MediaTypeNames.Application.Octet);
                ContentDisposition photoContent = dataPhoto.ContentDisposition;
                photoContent.CreationDate = System.IO.File.GetCreationTime(photo);
                photoContent.ModificationDate = System.IO.File.GetLastWriteTime(photo);
                photoContent.ReadDate = System.IO.File.GetLastAccessTime(photo);

                /* String video = @"C:\Users\" + usuario + @"\AppData\Local\Packages\9e44d609-57f4-47ef-8e9f-5d0b19eccf1e_6yj39zyq0cs5j\LocalState\Fotos\VIDEO.mp4";
                Attachment dataVideo = new Attachment(video, MediaTypeNames.Application.Octet);
                ContentDisposition videoContent = dataVideo.ContentDisposition;
                videoContent.CreationDate = System.IO.File.GetCreationTime(video);
                videoContent.ModificationDate = System.IO.File.GetLastWriteTime(video);
                videoContent.ReadDate = System.IO.File.GetLastAccessTime(video);*/

                // Create Messaje Object
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(FROM, FROMNAME);
                message.To.Add(new MailAddress(TO));
                message.Attachments.Add(dataPhoto);
                //message.Attachments.Add(dataVideo);
                message.Subject = SUBJECT;
                message.Body = BODY;

                using (var client = new System.Net.Mail.SmtpClient(HOST, PORT))
                {
                    client.Credentials =
                        new NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);

                    client.Timeout = 60000;
                    client.EnableSsl = true;
                    ImgEnviandoEmail.Visibility = Visibility.Collapsed;

                    // Try to send the message. Show status in console.
                    try
                    {
                        client.Send(message);
                        Debug.WriteLine("======= Email sent! ========");
                        sonarAudio("enviado");
                        ImgEmailEnviado.Visibility = Visibility.Visible;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("======= The email was not sent. ========");
                        Debug.WriteLine("Error message: " + ex.Message);
                        ImgErrorEmail.Visibility = Visibility.Visible;
                    }
                }

                Fondo.Source = new Uri(this.BaseUri, "/Assets/Loop_Inicial.mp4");
                Fondo.IsLooping = true;
                await Task.Delay(5000);
                ImgEnviandoEmail.Visibility = Visibility.Collapsed;
                ImgEmailEnviado.Visibility = Visibility.Collapsed;
                ImgErrorEmail.Visibility = Visibility.Collapsed;
                Fondo.Visibility = Visibility.Visible;
                btnVoyPaEsa.Visibility = Visibility.Visible;
                correoText.Text = "";
                Fondo.Play();
            }
        }

        private void cancelar(object sender, RoutedEventArgs e)
        {
            sonarAudio("clic");
            ImgTeclado.Visibility = Visibility.Collapsed;
            ImgFoto.Visibility = Visibility.Collapsed;
            gridTeclado.Visibility = Visibility.Collapsed;
            btnEnviar.Visibility = Visibility.Collapsed;
            btnCancelar.Visibility = Visibility.Collapsed;
            correoText.Visibility = Visibility.Collapsed;
            correoText.Text = "";
            btnVoyPaEsa.Visibility = Visibility.Visible;
            Fondo.Visibility = Visibility.Visible;
            Fondo.Play();
        }

        private async void sonarAudio(String audio)
        {
            MediaElement sonido = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");

            switch (audio)
            {
                case "stopJunior":
                    Windows.Storage.StorageFile fileStop = await folder.GetFileAsync("dalejunior.mp3");
                    var streamStop = await fileStop.OpenAsync(Windows.Storage.FileAccessMode.Read);
                    sonido.Stop();
                    break;
                case "enviado":
                    Windows.Storage.StorageFile fileEnviado = await folder.GetFileAsync("sent.mp3");
                    var streamEnviado = await fileEnviado.OpenAsync(Windows.Storage.FileAccessMode.Read);
                    sonido.SetSource(streamEnviado, fileEnviado.ContentType);
                    break;
                case "clic":
                default:
                    Windows.Storage.StorageFile fileClic = await folder.GetFileAsync("click.mp3");
                    var streamClic = await fileClic.OpenAsync(Windows.Storage.FileAccessMode.Read);
                    sonido.SetSource(streamClic, fileClic.ContentType);
                    break;
            }
            sonido.Play();
        }

        private bool emailValido(string Email)
        {
            bool valido = true;
            int posArroba = Email.IndexOf("@", 0);
            if ((posArroba == -1) || (posArroba == 0) || (posArroba == (Email.Length - 1)))
            {
                valido = false;
                return valido;
            }
            int posUltimoPunto = Email.LastIndexOf(".");
            if ((posUltimoPunto < posArroba) || (posUltimoPunto == -1) || (posUltimoPunto == (Email.Length - 1)))
            {
                valido = false;
                return valido;
            }
            int posEspacio = Email.IndexOf(" ");
            if (posEspacio != -1)
            {
                valido = false;
                return valido;
            }
            return valido;
        }


        async void escribirJugadorTxt(string jugadorSeleccionado)
        {
            try
            {
                Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                Windows.Storage.StorageFile file = await storageFolder.CreateFileAsync("jugadorSeleccionado.txt",
                        Windows.Storage.CreationCollisionOption.OpenIfExists);

                await Windows.Storage.FileIO.WriteTextAsync(file, jugadorSeleccionado);

                Debug.WriteLine("===== RUTA ARCHIVO =======");
                Debug.WriteLine(file.Path);
            }
            catch (Exception e)
            {
                Debug.WriteLine("===== ERROR ARCHIVO =======");
                Debug.WriteLine(e.ToString());
            }
        }

        bool finCaptura()
        {
            bool fin = false;
            string rutaArchivo = @"C:\Users\USER\AppData\Local\Packages\9e44d609-57f4-47ef-8e9f-5d0b19eccf1e_6yj39zyq0cs5j\LocalState\jugadorSeleccionado.txt";

            if (File.Exists(rutaArchivo))
            {

                string text = System.IO.File.ReadAllText(rutaArchivo);
                text = text.Trim();

                if (text.Equals("FIN"))
                {
                    fin = true;
                    escribirJugadorTxt("");
                }
            }

            return fin;
        }

        /****** Métodos para el funcionamiento del teclado ******/
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "1";
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "2";
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "3";
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "4";
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "5";
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "6";
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "7";
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "8";
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "9";
        }
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "0";
        }
        private void BtnQ_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "q";
        }
        private void BtnW_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "w";
        }
        private void BtnE_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "e";
        }
        private void BtnR_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "r";
        }
        private void BtnT_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "t";
        }
        private void BtnY_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "y";
        }
        private void BtnU_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "u";
        }
        private void BtnI_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "i";
        }
        private void BtnO_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "o";
        }
        private void BtnP_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "p";
        }
        private void BtnA_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "a";
        }
        private void BtnS_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "s";
        }
        private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "d";
        }
        private void BtnF_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "f";
        }
        private void BtnG_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "g";
        }
        private void BtnH_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "h";
        }
        private void BtnJ_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "j";
        }
        private void BtnK_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "k";
        }
        private void BtnL_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "l";
        }
        private void BtnÑ_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "ñ";
        }
        private void BtnZ_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "z";
        }
        private void BtnX_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "x";
        }
        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "c";
        }
        private void BtnV_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "v";
        }
        private void BtnB_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "b";
        }
        private void BtnN_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "n";
        }
        private void BtnM_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "m";
        }
        private void BtnMiddle_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "-";
        }
        private void BtnDash_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "_";
        }
        private void BtnPeriod_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + ".";
        }
        private void BtnGmail_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "@gmail.com";
        }
        private void BtnHotmail_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "@hotmail.com";
        }
        private void BtnCom_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + ".com";
        }
        private void BtnCo_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + ".co";
        }
        private void BtnAt_Click(object sender, RoutedEventArgs e)
        {
            correoText.Text = correoText.Text + "@";
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            int longitud = correoText.Text.Length;
            if (correoText.Text == "")
            {
                correoText.Text = "";
            }
            else
            {
                correoText.Text = correoText.Text.Remove(longitud - 1);

            }

        }

        private void TextBox_OnTextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            if (correoText.Text.Contains('@') && correoText.Text.Contains(".c"))
            {
                btnEnviar.IsEnabled = true;
            }
            else
            {
                btnEnviar.IsEnabled = false;
            }
        }

        /****** Fin métodos ******/
    }
}
