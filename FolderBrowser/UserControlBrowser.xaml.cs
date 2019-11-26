using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace FolderBrowser
{
    /// <summary>
    /// Lógica de interacción para UserControlBrowser.xaml
    /// </summary>
    public partial class UserControlBrowser : System.Windows.Controls.UserControl
    {
        public UserControlBrowser()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Texto
        {
            get { return (string)GetValue(TextoProperty); }
            set { SetValue(TextoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Texto.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextoProperty =
            DependencyProperty.Register("Texto", typeof(string), typeof(UserControlBrowser), new PropertyMetadata(""));



        public bool MuestraCarpetaNueva
        {
            get { return (bool)GetValue(MuestraCarpetaNuevaProperty); }
            set { SetValue(MuestraCarpetaNuevaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MuestraCarpetaNueva.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MuestraCarpetaNuevaProperty =
            DependencyProperty.Register("MuestraCarpetaNueva", typeof(bool), typeof(UserControlBrowser), new PropertyMetadata(true));



        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsReadOnly.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(UserControlBrowser), new PropertyMetadata(false));

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Creamos un nuevo diálogo
            FolderBrowserDialog dialogo = new FolderBrowserDialog();
            dialogo.ShowNewFolderButton = MuestraCarpetaNueva;

            //Mostramos el diálogo
            DialogResult resultado = dialogo.ShowDialog();

            //Comprobamos si el usuario ha pulsado el botón Aceptar
            if (resultado == DialogResult.OK)
            {
                //Accedemos a la ruta seleccionada por el usuario
                string ruta = dialogo.SelectedPath;
                DirectorioTextBox.Text = ruta;
            }
        }
    }
}
