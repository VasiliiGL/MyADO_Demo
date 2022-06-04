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
    /// Логика взаимодействия для AccountWindowAdmin.xaml
    /// </summary>
    public partial class AccountWindowAdmin : Window
    {
        public Account currentAccount { get; set; }
        public Role curentRole { get; set; }
        public ObservableCollection<Role> Roles { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Account> Accounts { get; set; }

        public AccountWindowAdmin(Account account)
        {
            var _account = new AccountCrud();
            currentAccount = account;
            curentRole = _account.GetRole(currentAccount);

            var roles = new RoleCrud();
            Roles = new ObservableCollection<Role>(roles.GetAllRoles());
            var users = new UserCrud();
            Users = new ObservableCollection<User>(users.GetAllUsers());
            var accounts = new AccountCrud();
            Accounts = new ObservableCollection<Account>(accounts.GetAllAcounts());
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
