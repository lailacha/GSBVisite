using essaiMysql;
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
    public partial class Form1 : Form
    {

        string chaineConnexion;  //ceci permettra la connexion à la base de données //		
        string userCo;
        string userStatut;
        string userMatricule;
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }

        public Form1()
        {
            ChaineConnexion = "server = 127.0.0.1; user id = admincdi;password= secret;  database = gsb";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string id = idTbx.Text;
            string mdp = mdp_Tbx.Text;
            CURS cs = new CURS(ChaineConnexion);
            string requete = "select count(*)  from utilisateur where identifiant ='" ;
           
            requete += id;
            requete += "' AND mdp ='";
            requete += mdp ;
            requete += "';";


            cs.Compter(requete);

            if (Convert.ToInt32(cs.Compter(requete)) == 0)
            { MessageBox.Show("Identification incorrect!");
                cs.fermer();
            }
            else
            {
                MessageBox.Show("Identification Réussie ;)");
                cs.fermer();

            }

            CURS cs1 = new CURS(ChaineConnexion);
           requete = "select identifiant, mdp, Collaborateur.statut, Collaborateur.MATRICULE, Collaborateur.nom from utilisateur INNER JOIN Collaborateur on utilisateur.idCollaborateur = Collaborateur.MATRICULE where identifiant ='";

            requete += id;
            requete += "' AND mdp ='";
            requete += mdp;
            requete += "';";
            cs1.ReqSelect(requete);
          userCo = cs1.champ("nom").ToString();
            userStatut = cs1.champ("statut").ToString();
            userMatricule = cs1.champ("matricule").ToString();


            Menu m = new Menu();
            m.ChaineConnexion = this.ChaineConnexion;
            m.UserCo = this.userCo;
            m.UserStatut = this.userStatut;
          m.UserMatricule = this.userMatricule;

            m.Show();





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
