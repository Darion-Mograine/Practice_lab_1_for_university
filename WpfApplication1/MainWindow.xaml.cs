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
using System.Collections;
using Microsoft.Win32;

namespace lb1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int flag = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
        }

        private void que_st(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            int[] num = new int[2000];
            int i = 0;
            int count = 0;
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                num[index] = number;
                lbMain.Items.Add(number);
            }
            int a = index;
            while (i <= a - 1)
            {
                if (i == 0)
                {
                    i++;
                    continue;
                }
                else if (i == a - 1)
                {
                    i++;
                    continue;
                }
                else if (num[i - 1] < num[i] && num[i + 1] < num[i])
                {
                    count++;
                }
                i++;
            }
            lbMain.Items.Add("1 Задание");
            lbMain.Items.Add(count);
        }

        private void que_stt(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            int[] num = new int[2000];
            int i = 0;
            int count = 0;
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                num[index] = number;
                lbMain.Items.Add(number);
            }
            int a = index;
            while (i <= a - 1)
            {
                if (num[i] == 25)
                {
                    lbMain.Items.Add("2 Задание - номер числа 25");
                    lbMain.Items.Add(i);
                    break;
                }
                i++;
            }
        }

        private void que_sttt(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            int[] num = new int[2000];
            int i = 0;
            int count = 0;
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                num[index] = number;
                lbMain.Items.Add(number);
            }
            int a = index;
            while (i <= a - 1)
            {
                if (i == 1)
                {
                    i++;
                    continue;
                }
                if (num[1] < (num[i] + num[i + 1]))
                {
                    lbMain.Items.Add("Сумма найдена");
                    lbMain.Items.Add(num[i]);
                    lbMain.Items.Add("и");
                    lbMain.Items.Add(num[i+1]);
                    break;
                }
                else if (i == a - 1 && count == 0)
                {
                    lbMain.Items.Add("Сумма не найдена");
                }
                i++;
            }
        }


        private void que_stte(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            int[] num = new int[2000];
            int i = 0;
            int count = 0;
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                num[index] = number;
                lbMain.Items.Add(number);
            }
            int a = index;
            Window1 w = new Window1();
            w.ShowDialog();
            int g = Convert.ToInt32(w.flag);
            while (i <= a - 1)
            {
                if (num[i] > g)
                {
                    lbMain.Items.Add("Число найдено");
                    lbMain.Items.Add(num[i]);
                    break;
                }
                i++;
            }

        }


        private void que_stttt(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            int[] num = new int[2000];
            int i = 0;
            int count = 0;
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                num[index] = number;
                lbMain.Items.Add(number);
            }
            int a = index;
            Window1 w = new Window1();
            w.ShowDialog();
            int g = Convert.ToInt32(w.flag);
            while (i <= a - 1)
            {
                if (i == g)
                {
                    i++;
                    continue;
                }
                if (g < (num[i] + num[i + 1]))
                {
                    lbMain.Items.Add("Сумма найдена");
                    lbMain.Items.Add(num[i]);
                    lbMain.Items.Add("и");
                    lbMain.Items.Add(num[i + 1]);
                    break;
                }
                else if (i == a - 1 && count == 0)
                {
                    lbMain.Items.Add("Сумма не найдена");
                }
                i++;
            }
        }

        private void que_str(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            int[] num = new int[2000];
            int i = 0;
            int count = 0;
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                num[index] = number;
                lbMain.Items.Add(number);
            }
            int a = index;
            lbMain.Items.Add("Выделенные элементы");
            while (i <= a - 1)
            {
                if (i == 0)
                {
                    i++;
                    continue;
                }
                else if (i == a - 1)
                {
                    i++;
                    continue;
                }
                else if (num[i - 1] < num[i] && num[i + 1] < num[i])
                {
                    lbMain.Items.Add(num[i]);
                }
                i++;
            }
        }
        

        private void BtN(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }
        }

        private void Sav_e(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}