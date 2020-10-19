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

        public Menu()
        {
            InitializeComponent();
        }

        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
        public string UserCo { get => userCo; set => userCo = value; }
        public string UserStatut { get => userStatut; set => userStatut = value; }

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
    }
}
