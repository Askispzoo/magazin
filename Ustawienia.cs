using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.Protocols;

namespace magazin
{
    public partial class Ustawienia : Form
    {
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ustawienia_Load(object sender, EventArgs e)
        {
            label3.Text = Environment.UserDomainName;
            label4.Text = Environment.UserName;
            label5.Text = Environment.SystemDirectory;
        }
    }
}
