using ADO_Demo.DB.CRUDs;
using ADO_Demo.DB.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ADO_Demo.App
{
    /// <summary>
    /// Логика взаимодействия для AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public Account currentAccount { get; set; }
        public Role curentRole { get; set; }
        public AccountWindow(Account account)
        {
            var _account = new AccountCrud();
            currentAccount = account;
            curentRole = _account.GetRole(currentAccount);
            InitializeComponent();
            //MessageBox.Show(currentAccount.Login);
            //MessageBox.Show(curentRole.RoleName);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var registrationtWindow = new MainWindow();
            registrationtWindow.Show();
            this.Close();
        }
    }
}
