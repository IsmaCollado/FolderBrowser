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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Creamos un nuevo diálogo
            FolderBrowserDialog dialogo = new FolderBrowserDialog();
            dialogo.ShowNewFolderButton = false;

            //Mostramos el diálogo
            DialogResult resultado = dialogo.ShowDialog();

            //Comprobamos si el usuario ha pulsado el botón Aceptar
            if (resultado == DialogResult.OK)
            {
                //Accedemos a la ruta seleccionada por el usuario
                string ruta = dialogo.SelectedPath;
            }
        }
    }
}
