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
    public partial class ConsulterRapport : Form
    {
        string chaineConnexion;  //ceci permettra la connexion à la base de données //		
        string userCo;
        string userStatut;
        string userMatricule;


        public ConsulterRapport()
        {
            InitializeComponent();
        }


        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
        public string UserCo { get => userCo; set => userCo = value; }
        public string UserStatut { get => userStatut; set => userStatut = value; }
        public string UserMatricule { get => userMatricule; set => userMatricule = value; }


        private void ConsulterRapport_Load(object sender, EventArgs e)
        {

           
            CURS cs2 = new CURS(chaineConnexion);


            string req2 = "SELECT * FROM  praticien";

           
            cs2.ReqSelect(req2);

            while (!cs2.Fin())
            {


                visiteur_cbx.Items.Add(cs2.champ("PRA_NOM"));

                cs2.suivant();
            }
            cs2.fermer();



        }

        private void visiteur_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CURS cs1 = new CURS(chaineConnexion);

            string req1 = "SELECT * FROM rapport_visite INNER JOIN typemotif ON rapport_visite.numMotif = typemotif.numMotif INNER JOIN praticien ON praticien.PRA_NUM = rapport_visite.PRA_NUM WHERE praticien.PRA_NOM ='";
            req1 += visiteur_cbx.Text;
            req1 += "';";
            MessageBox.Show(req1);

            cs1.ReqSelect(req1)  ;
            string praticien = cs1.champ("PRA_NUM").ToString();
            MessageBox.Show(praticien);

            //definition du nombre de colonne
            this.rapport_dg.ColumnCount = 2;

          



            while (!cs1.Fin())
            {
                rapport_dg.Rows.Add("Nom du praticien", cs1.champ("PRA_NOM").ToString());
                rapport_dg.Rows.Add("Motif", cs1.champ("libelleMotif").ToString()); 
                rapport_dg.Rows.Add("Date", cs1.champ("rap_date"));



                cs1.suivant();
            }
            cs1.fermer();
           
            CURS cs3 = new CURS(chaineConnexion);

            string req3 = "SELECT * FROM rapport_visite INNER JOIN typemotif ON rapport_visite.numMotif = typemotif.numMotif INNER JOIN praticien ON praticien.PRA_NUM = rapport_visite.PRA_NUM WHERE praticien.PRA_NOM ='";
            req3 += visiteur_cbx.Text;
            req3 += "';";
            MessageBox.Show(req1);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
