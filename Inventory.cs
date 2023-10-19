using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

namespace magazin
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form srodki_trwale_view = new Srodki_Trwale();
            srodki_trwale_view.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form workers_toolboxes_view = new Workers_Toolboxes();
            workers_toolboxes_view.Show();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            /*
             * 
             * POWIADOMIENIE TOAST NOTIFICATION KTORE NIE CHCE DZIALAC :)
             * 
             * 
            new ToastContentBuilder()
            .AddArgument("action", "viewConversation")
            .AddArgument("conversationId", 9813)
            .AddText("Moduł inwentaryzacji")
            .AddText("To jest powiadomineie z inwentaryzacji!");
            .Show();
            */

            /*
            new ToastContentBuilder()
            .AddText("To jest powiadomienie testowe. Test systemu.")
            //.Show(toast =>
            {
                toast.ExpirationTime = DateTime.Now.AddDays(1);
            });
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form legal_view = new Legal();
            legal_view.Show();
        }
    }
}
