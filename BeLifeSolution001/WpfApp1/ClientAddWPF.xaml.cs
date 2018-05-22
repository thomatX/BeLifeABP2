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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class ClientAddWPF : Window
    {
        public ClientAddWPF()
        {
            InitializeComponent();
            CarcarComboBox();
        }

        private void CarcarComboBox()
        {
            List<string> sexos = new List<string>();
            sexos.Add("Hombre");
            sexos.Add("Mujer");
            SexoComboBox.ItemsSource = sexos;
            SexoComboBox.Items.Refresh();
            SexoComboBox.SelectedIndex = 0;


            List<string> estados = new List<string>();
            estados.Add("Soltero");
            estados.Add("Casado");
            estados.Add("Divorciado");
            estados.Add("Viudo");
            EstadoCivilComboBox.ItemsSource = estados;
            EstadoCivilComboBox.Items.Refresh();
            EstadoCivilComboBox.SelectedIndex = 0;

        }

        private void CloseBtn_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BelifeLibrary.Cliente c = new BelifeLibrary.Cliente();
                c.Rut = RutTxt.Text;
                c.Apellidos = ApellidoTxt.Text;
                c.FechaNacimiento = (DateTime)FechaNacimientoPicker.SelectedDate;
                c.IdSexo = SexoComboBox.SelectedIndex + 1;
                c.IdEstadoCivil = EstadoCivilComboBox.SelectedIndex + 1;
                c.Sexo = c.BuscarSexo();
                c.EstadoCivil = c.BuscarEstadoCivil();
                c.Create();
                MessageBox.Show("Cliente agregado correctamente.","Información",MessageBoxButton.OK,MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
