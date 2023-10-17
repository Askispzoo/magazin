using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.Protocols;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace magazin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = logintextBox.Text;
            string password = password_textBox.Text;
            string ldapPath = "LDAP://192.168.108.10"; //Trzeba podac adres serwera do LDAP

            if (AuthenticateUser(username, password, ldapPath))
            {
                MessageBox.Show("Zalogowano pomyślnie!");
                Form main_view = new Main_View();
                main_view.Show();

            }
            else
            {
                MessageBox.Show("Wprowadzono błędne dane logowania!");
            }



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
                 */
        }

        private static bool AuthenticateUser(string username, string password, string ldapPath)
        {
            using (DirectoryEntry entry = new DirectoryEntry(ldapPath, username, password))
            {
                try
                {
                    DirectorySearcher searcher = new DirectorySearcher(entry);
                    searcher.Filter = "(sAMAccountName=" + username + ")";
                    searcher.PropertiesToLoad.Add("cn");

                    SearchResult result = searcher.FindOne();

                    if (result != null)
                    {
                        //zalogowano pomyślnie
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Nieprawidłowe dane logowania!", "Błąd!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
            }

            /* IMITACJA LOGOWANIA
            if (logintextBox.Text == "aski" && password_textBox.Text == "Aski2023!")
            {
                Form main_view = new Main_View();
                main_view.Show();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania!", "Błąd!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);



            }
            Form logowanie = new Form1();
            logowanie.Visible = false;

            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string username = logintextBox.Text;
            string password = password_textBox.Text;
            string ldapPath = "LDAP://192.168.108.10"; //Trzeba podac adres serwera do LDAP
            if (e.KeyCode == Keys.Enter)
            {

                if (AuthenticateUser(username, password, ldapPath))
                {
                    MessageBox.Show("Zalogowano pomyślnie!");
                    Form main_view = new Main_View();
                    main_view.Show();

                }
                else
                {
                    MessageBox.Show("Wprowadzono błędne dane logowania!");
                }
            }
        }
    }
}

