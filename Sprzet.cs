using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magazin
{
    public partial class Sprzet : Form
    {
        public Sprzet()
        {
            InitializeComponent();
        }

        private void Sprzet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form tools_view = new Tools();
            tools_view.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form uniforms_view = new Uniforms();
            uniforms_view.Show();
        }
    }
}
