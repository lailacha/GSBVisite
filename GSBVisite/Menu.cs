using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBVisite
{
    public partial class Menu : Form
    {


        string chaineConnexion;  //ceci permettra la connexion à la base de données //		
        string userCo;
        string userStatut;
        string userMatricule;

        public Menu()
        {
            InitializeComponent();
        }

        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
        public string UserCo { get => userCo; set => userCo = value; }
        public string UserStatut { get => userStatut; set => userStatut = value; }
        public string UserMatricule { get => userMatricule; set => userMatricule = value; }

        private void Menu_Load(object sender, EventArgs e)
        {
            userCo_tbx.Text = userCo;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userCo_tbx_Click(object sender, EventArgs e)
        {

        }

        private void rapportDeVisiteToolStripMenuItem2_Click(object sender, EventArgs e)
        {


            CreateRapport c = new CreateRapport();
            c.ChaineConnexion = this.ChaineConnexion;
            c.UserCo = this.userCo;
            c.UserStatut = this.userStatut;
            c.UserMatricule = this.userMatricule;
            c.Show();
        }

        private void consulterLesRapportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {


           ConsulterRapport cr = new ConsulterRapport();
            cr.ChaineConnexion = this.ChaineConnexion;
            cr.UserCo = this.userCo;
            cr.UserStatut = this.userStatut;
            cr.UserMatricule = this.userMatricule;
            cr.Show();
        }
    }
}
