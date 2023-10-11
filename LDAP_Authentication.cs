using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin
{
    internal class LDAP_Authentication : Form1
    {
        TextBox logintextBox = new TextBox();
        

    /*
             public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string ldapPath = "LDAP://your_ldap_server_address"; // Replace with your LDAP server address

            if (IsAuthenticated(ldapPath, username, password))
            {
                MessageBox.Show("Authentication successful!");
                // You can add code here to open your main application form or perform other actions.
            }
            else
            {
                MessageBox.Show("Authentication failed. Please check your credentials.");
            }
        }

        private bool IsAuthenticated(string ldapPath, string username, string password)
        {
            try
            {
                using (DirectoryEntry entry = new DirectoryEntry(ldapPath, username, password))
                {
                    using (DirectorySearcher searcher = new DirectorySearcher(entry))
                    {
                        searcher.Filter = "(sAMAccountName=" + username + ")";
                        SearchResult result = searcher.FindOne();
                        return (result != null);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
             * */
    }
}
