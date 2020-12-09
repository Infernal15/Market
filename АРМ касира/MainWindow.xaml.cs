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

namespace АРМ_касира
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list;
        KeyValuePair<int, int> size = new KeyValuePair<int, int>(10, 12);
        Button[,] buttons;
        int sum = 0;
        public MainWindow()
        {
            InitializeComponent();
            ret.Visibility = Visibility.Hidden;
            combo.Visibility = Visibility.Hidden;
            calendar1.Visibility = Visibility.Hidden;
            grid.Visibility = Visibility.Hidden;
            reserv.Visibility = Visibility.Hidden;
            price.Visibility = Visibility.Hidden;
            s.Visibility = Visibility.Hidden;
            list = new List<string>() { "Лісова пісня", "Мавка", "Сухишвили" };
            foreach (string tmp in list)
                combo.Items.Add(tmp);
            for (int i = 0; i < size.Key; i++)
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            for (int i = 0; i < size.Value; i++)
            {
                RowDefinition tmp = new RowDefinition();
                tmp.Height = new GridLength(25);
                grid.RowDefinitions.Add(tmp);
            }

            buttons = new Button[size.Key, size.Value];
            for (int i = 0; i < size.Key; i++)
                for (int j = 0; j < size.Value; j++)
                {
                    if (j == 0)
                    {
                        Label lbl = new Label();
                        lbl.Content = $"Ряд - {i + 1}";
                        grid.Children.Add(lbl);
                        Grid.SetRow(lbl, i);
                        Grid.SetColumn(lbl, j);
                    }
                    buttons[i, j] = new Button();
                    buttons[i, j].Name = $"Button{i + j}";
                    buttons[i, j].Content = $"{j + 1}";
                    buttons[i, j].Click += Button_Set;
                    buttons[i, j].Background = Brushes.LightGreen;
                    grid.Children.Add(buttons[i, j]);
                    Grid.SetRow(buttons[i, j], i);
                    Grid.SetColumn(buttons[i, j], j + 1);
                }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Height = 510;
            this.Width = 650;
            sell.Visibility = Visibility.Hidden;
            rep.Visibility = Visibility.Hidden;
            exit.Visibility = Visibility.Hidden;

            ret.Visibility = Visibility.Visible;
            combo.Visibility = Visibility.Visible;
            calendar1.Visibility = Visibility.Visible;
            grid.Visibility = Visibility.Visible;
            reserv.Visibility = Visibility.Visible;
            price.Visibility = Visibility.Visible;
            s.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void ret_Click(object sender, RoutedEventArgs e)
        {
            this.Height = 450;
            this.Width = 800;
            sell.Visibility = Visibility.Visible;
            rep.Visibility = Visibility.Visible;
            exit.Visibility = Visibility.Visible;

            ret.Visibility = Visibility.Hidden;
            combo.Visibility = Visibility.Hidden;
            calendar1.Visibility = Visibility.Hidden;
            grid.Visibility = Visibility.Hidden;
            reserv.Visibility = Visibility.Hidden;
            price.Visibility = Visibility.Hidden;
            s.Visibility = Visibility.Hidden;
        }

        private void Button_Set(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            if (Equals(button.Background, Brushes.DeepSkyBlue))
                button.Background = Brushes.LightGreen;
            else if (Equals(button.Background, Brushes.LightGreen))
                button.Background = Brushes.DeepSkyBlue;

            List<KeyValuePair<int, int>> tmp = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < size.Key; i++)
                for (int j = 0; j < size.Value; j++)
                {
                    if (buttons[i, j].Background.Equals(Brushes.DeepSkyBlue))
                        tmp.Add(new KeyValuePair<int, int>(i, j));
                }

            sum = 0;
            for (int i = 0; i < tmp.Count; i++)
            {
                int t = 0;
                if (tmp[i].Key < 3)
                    t += 8;
                else if (tmp[i].Key >= 3 && tmp[i].Key < 6)
                    t += 4;
                else
                    t += 2;

                if (tmp[i].Value < 3 && tmp[i].Value > 9)
                    t += 3;
                else if (tmp[i].Value >= 3 && tmp[i].Value < 6)
                    t += 4;
                else
                    t += 5;

                sum += t;
            }
            price.Content = Convert.ToString(sum);
        }

        private void reserv_Click(object sender, RoutedEventArgs e)
        {
            if (combo.SelectedIndex == -1)
                MessageBox.Show("Виберіть виставу");
            else if (calendar1.SelectedDate.ToString() == "")
                MessageBox.Show("Виберіть дату");
            else if (sum == 0)
            {
                MessageBox.Show("Виберіть місце");
                return;
            }

            List<KeyValuePair<int, int>> tmp = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < size.Key; i++)
                for (int j = 0; j < size.Value; j++)
                {
                    if (buttons[i, j].Background.Equals(Brushes.DeepSkyBlue))
                        tmp.Add(new KeyValuePair<int, int>(i, j));
                }

            if (!File.Exists($"users\\{calendar1.SelectedDate}"))
                File.Create($"users\\{calendar1.SelectedDate}");
        }

        private void calendar1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            sum = 2;
        }
    }
}
