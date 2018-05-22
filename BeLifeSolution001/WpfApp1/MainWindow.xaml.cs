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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string month = DateTime.Today.Month.ToString(); 
            string day = DateTime.Today.Day.ToString();
            Day.Text = day;
            Month.Text = month;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

        }

        private void HomeBtn_Click(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void ClientsBtn_Click(object sender, MouseButtonEventArgs e)
        {
            ClientesWPF clientes = new ClientesWPF();
            clientes.Show();
            this.Close();
        }

        private void ContratosBtn_Click(object sender, MouseButtonEventArgs e)
        {
            ContratosWPF contratos = new ContratosWPF();
            contratos.Show();
            this.Close();

        }

        private void CloseBtn_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
