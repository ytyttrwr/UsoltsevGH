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
using System.Windows.Threading;

namespace OxtaPark
{
    /// <summary>
    /// Логика взаимодействия для WindowSeller.xaml
    /// </summary>
    public partial class WindowSeller : Window
    {
        private DispatcherTimer _timer;
        private TimeSpan _timeLeft;
        public WindowSeller()
        {
            InitializeComponent();
            StartTimer(2, 0); // Запуск таймера на 2 минуты
            DgOrder.ItemsSource= App.Bd.Orderr.ToList();
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrder  add= new AddOrder();  
            add.ShowDialog();

        }

        private void StartTimer(int minutes, int seconds)
        {
            _timeLeft = new TimeSpan(0, minutes, seconds);
            _timer = new DispatcherTimer(); // Создание таймера
            _timer.Interval = TimeSpan.FromSeconds(1); // Интервал 1 секунда
            _timer.Tick += TimerTick;
            _timer.Start();
            UpdateLabel();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (_timeLeft > TimeSpan.Zero)
            {
                _timeLeft = _timeLeft.Subtract(TimeSpan.FromSeconds(1));
                UpdateLabel();
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
                _timer.Stop();
                MessageBox.Show("Время вышло,войдите снова!", "Таймер", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void UpdateLabel()
        {
            TimerLabel.Content = $"{_timeLeft.Minutes:D2}:{_timeLeft.Seconds:D2}"; // Вывод таймера в Label
        }


        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
