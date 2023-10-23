using System;
using Microsoft.EntityFrameworkCore;
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
    public partial class Samochody : Form
    {
        public Samochody()
        {
            InitializeComponent();
        }
        //TO TEŻ DOKOŃCZYĆ
        //public DbSet<Pracownik> Pracownik { get; set; }

        /* TRZEBA DOKOŃCZYĆ
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=magazin_db_local;Trusted_Connection=True;");
        }
        */
        private void Samochody_Load(object sender, EventArgs e)
        {

        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form passat_1_view = new Sam_Passat();
            passat_1_view.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form bipper_1_view = new Sam_Bipper();
            bipper_1_view.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form qashqai_view = new Sam_Qashqai();
            qashqai_view.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form partner_view = new Sam_Partner();
            partner_view.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sam_add_view = new Sam_Add();
            sam_add_view.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form boxer_view = new Sam_Boxer();
            boxer_view.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form peugeotsw_view = new Sam_407sw();
            peugeotsw_view.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form peugeotswsilver_view = new _307sw();
            peugeotswsilver_view.Show();
        }
    }
}
