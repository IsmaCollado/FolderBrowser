using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FolderBrowser
{
    public partial class ControlBrowserControl : UserControlBrowser
    {
        public ControlBrowserControl()
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



    }
}
