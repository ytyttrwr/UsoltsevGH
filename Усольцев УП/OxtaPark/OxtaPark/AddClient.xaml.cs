using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace OxtaPark
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {

        public AddClient()
        {
            InitializeComponent();
           
        }

        private void clientadd_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate = (DateTime)Datepick.SelectedDate;
            if (Lastnametb.Text != string.Empty && Nametb.Text != string.Empty && Patronymetb.Text != string.Empty
                && Codeclienttb.Text != string.Empty && Passporttb.Text != string.Empty && Datepick.SelectedDate != null
                && Adrestb.Text != string.Empty && Emailtb.Text != string.Empty && Passporttb.Text != string.Empty)
            {
                var lastProduct = App.Bd.Client.OrderByDescending(p => p.CodeClient).FirstOrDefault();

                

                Entities.Client client = new Entities.Client 
                { 
                Lastname = Lastnametb.Text,
                Name = Nametb.Text,
                Patronyme = Patronymetb.Text,
                CodeClient= Convert.ToInt32(Codeclienttb.Text),
                Passport =Passporttb.Text,
                Datebirth=selectedDate,
                Adress=Adrestb.Text,
                Email=Emailtb.Text,
                Password=Passwordtb.Text,
                };
                App.Bd.Client.Add(client);
                App.Bd.SaveChanges();
                MessageBox.Show("Клиент успешно добавлен!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void behind_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
