using ADO_Demo.DB.CRUDs;
using ADO_Demo.DB.Models;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для AccountWindowUser.xaml
    /// </summary>
    public partial class AccountWindowUser : Window
    {
        public Account currentAccount { get; set; }
        public Role curentRole { get; set; }
        public AccountWindowUser(Account account)
        {
            var _account = new AccountCrud();
            currentAccount = account;
            curentRole = _account.GetRole(currentAccount);
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var registrationtWindow = new MainWindow();
            registrationtWindow.Show();
            this.Close();
        }
    }
}
