using System;
using System.Collections.Generic;
using System.IO;
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

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> userLista = new List<User>();

        public MainWindow()
        {
            InitializeComponent();
            userLista.Add(new User("miguel", "987", "admin"));
            userLista.Add(new User("raquel", "123", "tecnico"));
            userLista.Add(new User("marcos", "456", "tecnico"));
            userLista.Add(new User("belen", "789", "admin"));
            userLista.Add(new User("ivan", "150", "tecnico"));
        }


        
        private void Comprobar(object sender, RoutedEventArgs e)
        {
            string user = usuario.Text;
            string pass = password.Text;
            bool log = false;

            for ( int i = 0; i < userLista.Count; i++)
            {
                if(user == userLista[i].Nombre)
                {
                    if(pass == userLista[i].Pass)
                    {
                        alert.Text = "Se ha logeado como " + userLista[i].Role;
                        alert.Foreground = Brushes.Green;
                        btn_menu.IsEnabled = true;
                        log = true;
                    }

                    else
                    {
                        alert.Text = "Contraseña incorrecta";
                        alert.Foreground = Brushes.Red;
                        log = true;
                    }
                }
            }

            if (log == false)
            {
                alert.Text = "Usuario no encontrado";
                alert.Foreground = Brushes.Red;
            }
        }
    }
}
