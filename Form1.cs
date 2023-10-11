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

namespace magazin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "aski" && textBox2.Text == "Aski2023!")
            {
                Form main_view = new Main_View();
                main_view.Show();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania!", "Błąd!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private static bool fnValidateUser()
        {
            bool validation;
            try
            {
                LdapConnection lcon = new LdapConnection
                        (new LdapDirectoryIdentifier((string)null, false, false));
                NetworkCredential nc = new NetworkCredential(Environment.UserName,
                                       "Password", Environment.UserDomainName);
                lcon.Credential = nc;
                lcon.AuthType = AuthType.Negotiate;
                // user has authenticated at this point,
                // as the credentials were used to login to the dc.
                lcon.Bind(nc);
                validation = true;
            }
            catch (LdapException)
            {
                validation = false;
            }
            return validation;
        }
    }
}
