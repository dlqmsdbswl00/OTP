using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01b
{
    /// <summary>
    /// StartPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // START 버튼 클릭 시 동작 정의
            StartPage newPage = new StartPage();
            this.Content = newPage;
        }

        private void Chapter1Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 1 버튼 클릭 시 동작 정의
            Chap1 newPage = new Chap1();
            this.Content = newPage;
        }

        private void Chapter2Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 2 버튼 클릭 시 동작 정의
            Chap2 newPage = new Chap2();
            this.Content = newPage;
        }

        private void Chapter3Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 3 버튼 클릭 시 동작 정의
            Chap3 newPage = new Chap3();
            this.Content = newPage;
        }

        private void Chapter4Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 4 버튼 클릭 시 동작 정의
            Chap4 newPage = new Chap4();
            this.Content = newPage;
        }
    }
}
