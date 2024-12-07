using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace OxtaPark
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private const string CredentialsFilePath = "credentials.txt"; // Путь к файлу с учётными данными
        private int failedAttempts = 0;
        private int captchaFailedAttempts = 0;
        private DispatcherTimer lockoutTimer;
        private int lockoutTime = 10; // Время блокировки в секундах
        private string captchaText;


        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void GenerateCaptcha()
        {
            captchaText = GenerateRandomText(4); // Генерируем случайный текст длиной в 4 символа
            captchaImage.Source = CreateCaptchaImage(captchaText);
        }



        private string GenerateRandomText(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // Возможные символы
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length) // Генерация случайной строки
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private BitmapSource CreateCaptchaImage(string captcha)
        {
            int width = 200;
            int height = 75;

            using (Bitmap bitmap = new Bitmap(width, height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Устанавливаем случайный цвет фона
                    System.Drawing.Color bgColor = System.Drawing.Color.FromArgb(
                        255, new Random().Next(0, 256), new Random().Next(0, 256), new Random().Next(0, 256));
                    graphics.Clear(bgColor);
                    Font font = new Font("Comic Sans MS", 24, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
                    // Рисуем  капчу
                    graphics.DrawString(captcha, font, System.Drawing.Brushes.White, new PointF(50, 26));

                    // Рисуем случайные линии на изображении для усложнения
                    Random rnd = new Random();
                    for (int i = 0; i < 50; i++)
                    {
                        System.Drawing.Color lineColor = System.Drawing.Color.FromArgb(255,
                            rnd.Next(0, 256),
                            rnd.Next(0, 256),
                            rnd.Next(0, 256));

                        int x1 = rnd.Next(0, width);
                        int y1 = rnd.Next(0, height);
                        int x2 = rnd.Next(0, width);
                        int y2 = rnd.Next(0, height);

                        using (System.Drawing.Pen pen = new System.Drawing.Pen(lineColor))
                        {
                            graphics.DrawLine(pen, x1, y1, x2, y2);
                        }
                    }
                }
                using (MemoryStream stream = new MemoryStream())
                {
                    bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    stream.Position = 0;

                    BitmapImage imageSource = new BitmapImage();
                    imageSource.BeginInit();
                    imageSource.StreamSource = new MemoryStream(stream.ToArray());
                    imageSource.CacheOption = BitmapCacheOption.OnLoad;
                    imageSource.EndInit();
                    imageSource.Freeze();
                    return imageSource;
                }
            }
        }

        private void UpdateCaptchaButton_Click(object sender, RoutedEventArgs e)
        {
            GenerateCaptcha(); // Генерация новой капчу при нажатии на кнопку
        }

        private void ShowCaptcha()
        {
            // Отображаем CAPTCHA на экране
            Captcha.Visibility = Visibility.Visible;
            rect.Visibility = Visibility.Visible; 
            Captcha.Width = 350;
            Captcha.Height = 120;
            captchaImage.Source = CreateCaptchaImage(captchaText); // Устанавливаем изображение капчи
            //Enter.Margin = new Thickness(0, 50, 0, 0);
        }


        




        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string loginn = Logintb.Text;
            string passwordd = PasswordTb.Text;
            string Passwordboxx = Passwordbox.Password; 
            if (Logintb.Text != string.Empty &&  PasswordTb.Text != string.Empty || Passwordbox.Password!=string.Empty)
            {   
                var Check1 = App.Bd.Employes.FirstOrDefault(x => x.Login == loginn);
                var Check = App.Bd.Employes.FirstOrDefault(x => x.Login == loginn && x.Password == passwordd && x.Password==Passwordboxx);
                var CheckAdmin = App.Bd.Employes.FirstOrDefault(x => x.Login == loginn && x.Password==passwordd && x.Password == Passwordboxx && x.id_pos == 1);
                var CheckSeller = App.Bd.Employes.FirstOrDefault(x => x.Login == loginn && x.Password == passwordd && x.Password == Passwordboxx && x.id_pos == 2); // Prodavec
                var Checksupervisor = App.Bd.Employes.FirstOrDefault(x => x.Login == loginn && x.Password == passwordd && x.Password == Passwordboxx && x.id_pos == 3); // Starhiy

                if (failedAttempts < 1)
                {

                
                if (Check != null)
                {
                  

                   
                    if (CheckAdmin != null)
                    {
                            var id = CheckAdmin.id_Emp;
                            Entities.HistoryEnter history = new Entities.HistoryEnter();
                            history.id_Emplo = id;
                            history.datetimehistory= DateTime.Now;
                            history.typeentry = "Успешно";
                            App.Bd.HistoryEnter.Add(history);
                            App.Bd.SaveChanges();

                            LoginHistory loginHistory = new LoginHistory();
                            loginHistory.Show();
                            this.Close();
                            MessageBox.Show("Вы успешно вошли под должностью Администратора!");
                            Properties.Settings.Default.id_Empl = CheckAdmin.id_Emp;                       
                    }

                    if (CheckSeller != null)
                    {
                            var id = CheckSeller.id_Emp;
                            Entities.HistoryEnter history = new Entities.HistoryEnter();
                            history.id_Emplo = id;
                            history.datetimehistory = DateTime.Now;
                            history.typeentry = "Успешно";
                            App.Bd.HistoryEnter.Add(history);
                            App.Bd.SaveChanges();

                           WindowSeller windowSeller = new WindowSeller();
                            windowSeller.Show();
                            MessageBox.Show("Вы успешно вошли под должностью Продавца");                   
                        this.Close();
                        Properties.Settings.Default.id_Empl = CheckSeller.id_Emp;

                    }

                    if (Checksupervisor != null)
                    {
                            var id = CheckSeller.id_Emp;
                            Entities.HistoryEnter history = new Entities.HistoryEnter();
                            history.id_Emplo = id;
                            history.datetimehistory = DateTime.Now;
                            history.typeentry = "Успешно";
                            App.Bd.HistoryEnter.Add(history);
                            App.Bd.SaveChanges();

                            WindowSeller windowSeller2 = new WindowSeller();    
                            windowSeller2.Show();   
    
                            MessageBox.Show("Вы успешно вошли под должностью Старшего смены");
                        this.Close();
                        Properties.Settings.Default.id_Empl = Checksupervisor.id_Emp;

                    }
                   
                    else
                    {
                       
                    }

                }
                else
                    {
                      

                        var id = Check1.id_Emp;
                        Entities.HistoryEnter history = new Entities.HistoryEnter();
                        history.id_Emplo = id;
                        history.datetimehistory = DateTime.Now;
                        history.typeentry = "Неуспешно";
                        App.Bd.HistoryEnter.Add(history);
                        App.Bd.SaveChanges();

                        failedAttempts++;
                        MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        // После первой неудачной попытки показываем капчу
                        if (failedAttempts == 1)
                        {
                            ShowCaptcha();
                        }
                   
                }
               }
                else
                {
                    ProcessCaptcha(loginn, passwordd,Passwordboxx); // Обрабатываем ввод капчи
                }
            }

            else
            {
                MessageBox.Show("Введите все данные!");
            }

            }




        private void ProcessCaptcha(string login, string password,string Passworbox)
        {
            string captchaInput = captchaTextBox.Text;

            // Проверка на корректный ввод капчи
            if (captchaInput == captchaText)
            {
                var CheckAdmin = App.Bd.Employes.FirstOrDefault(x => x.Login == login && x.Password == password && x.Password == Passworbox && x.id_pos == 1);

                // Если введены правильные данные, открываем окно пользователя
                if (CheckAdmin != null)
                {
                    var id = CheckAdmin.id_Emp;
              
                    Entities.HistoryEnter history = new Entities.HistoryEnter();
                    history.id_Emplo = id;
                    history.datetimehistory = DateTime.Now;
                    history.typeentry = "Успешно";
                    App.Bd.HistoryEnter.Add(history);
                    App.Bd.SaveChanges();

                    LoginHistory loginHistory = new LoginHistory();
                    loginHistory.Show();
                    this.Close();
                    MessageBox.Show("Вы успешно вошли под должностью Администратора!");
                    Properties.Settings.Default.id_Empl = CheckAdmin.id_Emp;
                }
                else
                {
                    // Если введены неверные данные, выводим сообщение об ошибке
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    captchaTextBox.Clear();
                    GenerateCaptcha();
                }


            }
            else
            {
                captchaTextBox.Clear();
                GenerateCaptcha();
                captchaFailedAttempts++;

                // Если была одна неудачаная попытка, запускаем блокировку
                if (captchaFailedAttempts >= 1)
                {
                    StartLockout();
                }
                else
                {
                    MessageBox.Show($"Неверно введена капча", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }


        private void StartLockout()
        {
            lockoutTimerLabel.Content = 10; // Устанавливаем начальное время блокировки
            LockoutBorder.Visibility = Visibility.Visible; // Показываем границу блокировки
            lockoutTimer = new DispatcherTimer();
            lockoutTimer.Interval = TimeSpan.FromSeconds(1); // Интервал в 1 секунду
            lockoutTimer.Tick += LockoutTimer_Tick; // Подписываемся на событие таймера
            lockoutTimer.Start(); // Запускаем таймер
        }



        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            lockoutTime--; // Уменьшаем время блокировки

            // Обновляем текст виджета с оставшимся временем
            lockoutTimerLabel.Content = lockoutTime;

            // Если время блокировки истекло
            if (lockoutTime <= 0)
            {
                lockoutTimer.Stop(); // Останавливаем таймер
                LockoutBorder.Visibility = Visibility.Hidden; // Скрываем границу блокировки
                lockoutTime = 10; // Сбрасываем время блокировки
            }
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Visibility == Visibility.Collapsed)
            {
                // Показать пароль
                PasswordTb.Text = Passwordbox.Password;
                PasswordTb.Visibility = Visibility.Visible;
                Passwordbox.Visibility = Visibility.Collapsed;
                skrit.Content = "Скрыть пароль";
            }
            else
            {
                // Скрыть пароль
                Passwordbox.Password=PasswordTb.Text;
                Passwordbox.Visibility = Visibility.Visible;
                PasswordTb.Visibility = Visibility.Collapsed;
                skrit.Content = "Показать пароль";
            }
        }
    }
}
