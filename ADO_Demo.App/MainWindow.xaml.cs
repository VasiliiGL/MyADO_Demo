using ADO_Demo.DB.CRUDs;
using ADO_Demo.DB.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ADO_Demo.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Role> Roles { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Account> Accounts {get; set;}
        public MainWindow()
        {

            var roles = new RoleCrud();
            Roles = new ObservableCollection<Role>(roles.GetAllRoles());
            var users = new UserCrud();
            Users = new ObservableCollection<User>(users.GetAllUsers());
            var accounts = new AccountCrud();
            Accounts = new ObservableCollection<Account>(accounts.GetAllAcounts());
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool initialization = false;
            foreach (var account in Accounts)
            {
                if ((account.Login== InputLogin.Text) & (account.Password == InputPassword.Text))
                {
                    MessageBox.Show("Successfully. Authorization passed!");
                    initialization = true;
                    var accountWindow = new AccountWindow(account);
                    accountWindow.Show();
                    this.Close();
                }   
            }
            if (initialization == false)
            {
                MessageBox.Show("Authorization failed!");
            }
               


        }
    }
}
