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

namespace DelegacjeProjekt
{
    /// <summary>
    /// Interaction logic for Wstawianie.xaml
    /// </summary>
    public partial class Wstawianie : Window
    {
        Database1Entities _db = new Database1Entities();
        public Wstawianie()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            Delegacja delegacja = new Delegacja();
            {
                IdDelegacji = IDBox.Text;
                Termin = TerminBox.Text;
                Miejscowosc = MiejscBox.Text;
            };
            _db.Delegacja.Add(nowadelegacja);
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.Delegacja.ToList();
            this.Hide();

        }
    }
}
