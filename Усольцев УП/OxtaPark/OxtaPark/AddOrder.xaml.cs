using OxtaPark.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace OxtaPark
{
    /// <summary>
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        private int currentElementIndex = 1;
        private ComboBox[] elements;
        static int sel;



        public AddOrder()
        {
            InitializeComponent();
            DgClient.ItemsSource = App.Bd.Client.ToList();
            checkclient.IsEnabled = false;   
            CodeOrdertb.IsEnabled = false;
            CbService1.ItemsSource = App.Bd.Service.ToList();
            CbService2.ItemsSource = App.Bd.Service.ToList();
            CbService3.ItemsSource = App.Bd.Service.ToList();
            elements = new ComboBox[] { CbService1, CbService2,CbService3};

        }

 
        public void updata()
        {
            DgClient.ItemsSource = App.Bd.Client.ToList();
        }

        private void searchtb_SelectionChanged(object sender, RoutedEventArgs e)
        {

            if (searchtb.Text == string.Empty)
            {
                updata();
            }
            else
            {
                List<Client> clien = new List<Client>();
                var _search = App.Bd.Client.Where(x => x.Lastname.ToLower().Contains(searchtb.Text.ToLower())).ToArray();
                clien = _search.ToList();
                DgClient.ItemsSource = _search.ToList();
            }

        }

        private void DgClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var client = DgClient.SelectedItem as Client;
            if (client != null)
            {
                checkclient.Text = client.CodeClient.ToString();
                CodeOrdertb.Text = client.CodeClient.ToString() + " "+ "/" +" " + DateTime.Now.Day +"."+DateTime.Now.Month +"."+DateTime.Now.Year;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var client=DgClient.SelectedItem as Client;
            TimeSpan timeNow = DateTime.Now.TimeOfDay; // время дня текущее
            TimeSpan trimmedTimeNow = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds); //формат времени
            DateTime selectedDate = (DateTime)Datepick.SelectedDate;



            Entities.Orderr orderr = new Entities.Orderr
            {
                //CodeOrder = CodeOrdertb.Text,
                CodeClient = client.CodeClient,
                DateCreate = DateTime.Now, // дата создания
                Timecreate = trimmedTimeNow, // время создания указвыется локальная переменная 
                id_Status = 3,
                DateClose = selectedDate,
                //RentalTime = Timetb.Text


            };

            App.Bd.Orderr.Add(orderr);
            App.Bd.SaveChanges();

            // добавление идентификаторов в связную таблицу
            Entities.OrderService ordserv = new OrderService
            {
                id_Order = orderr.id_Order,
               
            };

            Entities.OrderService ordserv1 = new OrderService
            {
                id_Order = orderr.id_Order,

            };
            Entities.OrderService ordserv2 = new OrderService
            {
                id_Order = orderr.id_Order,

            };

            // если в combobox выбрано значение,услуга  добавляется
            if (CbService1.SelectedIndex != (-1))
            {
                ordserv.id_Servic = CbService1.SelectedIndex+1;
            }
            if (CbService2.SelectedIndex != (-1))
            {
                ordserv1.id_Servic= CbService2.SelectedIndex+1;
            }
            if (CbService3.SelectedIndex != (-1))
            {
                ordserv2.id_Servic=CbService3.SelectedIndex+1;
            }

            App.Bd.OrderService.Add(ordserv);
            App.Bd.OrderService.Add(ordserv1);
            App.Bd.OrderService.Add(ordserv2);
            App.Bd.SaveChanges();

            MessageBox.Show("Заказ успшено создан!");
            WindowSeller windowSeller = new WindowSeller();
            windowSeller.Show();
            this.Close();
        }



        private void clientadd_Click(object sender, RoutedEventArgs e)
        {
           AddClient client = new AddClient();
           client.ShowDialog();
            DgClient.ItemsSource = App.Bd.Client.ToList();
        }

        private void addservice_Click(object sender, RoutedEventArgs e)
        {
            if (currentElementIndex < elements.Length)
            {
                // Раскрываем текущий элемент
                elements[currentElementIndex].Visibility = Visibility.Visible;
                currentElementIndex++;
            }          

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WindowSeller windowSeller= new WindowSeller();
            windowSeller.Show();
            this.Close();
        }
    }
}
