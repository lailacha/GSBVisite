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
    public partial class CreateRapport : Form
    {


        string chaineConnexion;  //ceci permettra la connexion à la base de données //		
        string userCo;
        string userStatut;
        string userMatricule;
        Dictionary<string, string> praticien = new Dictionary<string, string>();

        /*        private List<Praticien> lesPraticiens = new List<Praticien>;
        */
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }

        public string UserCo { get => userCo; set => userCo = value; }
        public string UserStatut { get => userStatut; set => userStatut = value; }
        public string UserMatricule { get => userMatricule; set => userMatricule = value; }

        public CreateRapport()
        {
            InitializeComponent();
        }

        private void CreateRapport_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsbDataSet.medicament'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medicamentTableAdapter.Fill(this.gsbDataSet.medicament);

            CURS cs1 = new CURS(ChaineConnexion);
            string requete = "SELECT DISTINCT PRA_NOM, PRA_PRENOM, PRA_NUM FROM PRATICIEN";
           
            cs1.ReqSelect(requete);
            while (!cs1.Fin())
            {
               
              


                if (!praticien.ContainsKey(cs1.champ("PRA_NOM").ToString()))
                    {

                    praticien.Add(cs1.champ("PRA_NOM").ToString(), cs1.champ("PRA_NUM").ToString());
                }
                praticien_cbx.Items.Add(cs1.champ("PRA_NOM"));

                cs1.suivant();
            }
            cs1.fermer();



            CURS cs2 = new CURS(ChaineConnexion);
            string requete2 = "SELECT libelleMotif FROM typemotif";
            cs2.ReqSelect(requete2);
            while (!cs2.Fin())
            {
                motif_cbx.Items.Add(cs2.champ("libelleMotif").ToString());
                cs2.suivant();
            }
            cs2.fermer();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEnvoyerRapport_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(visiteur_tbx.Text) && String.IsNullOrEmpty(motif_cbx.Text) || String.IsNullOrEmpty(praticien_cbx.Text) || String.IsNullOrEmpty(bilan_Concu_tbx.Text)
                || String.IsNullOrEmpty(bilan_Hesit_txbx.Text) || String.IsNullOrEmpty(coef_conf_tbx.Text) || String.IsNullOrEmpty(impact_tbx.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                string numvisiteur = visiteur_tbx.Text;
                string reqLastReport = "SELECT COUNT(rap_num)+1 AS nbLastR FROM rapport_visite WHERE idCollaborateur = '";
                reqLastReport += numvisiteur;
                reqLastReport += "';";
                CURS cs3 = new CURS(ChaineConnexion);
                cs3.ReqSelect(reqLastReport);

                string lastReport = cs3.champ("nbLastR").ToString();
                cs3.fermer();




                string libelmotif = motif_cbx.Text;
                string reqCodeMotif = "SELECT numMotif FROM typemotif WHERE libelleMotif = '";
                reqCodeMotif += libelmotif;
                reqCodeMotif += "';";
                CURS cs4 = new CURS(ChaineConnexion);
                cs4.ReqSelect(reqCodeMotif);
                string codeMotif = cs4.champ("numMotif").ToString();
                cs4.fermer();




                string sqlFormattedDate = date_saisie_tbx.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string nump = praticien_cbx.Text.ToString();
                string numPrat = praticien[nump];
                MessageBox.Show(nump);
                string reqNewRapport = "INSERT INTO rapport_visite VALUES('";
                reqNewRapport += numvisiteur;
                reqNewRapport += "','";
                reqNewRapport += lastReport;
                reqNewRapport += "','";
                reqNewRapport += sqlFormattedDate;
                reqNewRapport += "','";
                reqNewRapport += coef_conf_tbx.Text;
                reqNewRapport += "','";
                reqNewRapport += numPrat;
                reqNewRapport += "','";
                reqNewRapport += codeMotif;
                reqNewRapport += "')";



                CURS cs6 = new CURS(ChaineConnexion);
                cs6.ReqAdmin(reqNewRapport);


                string reqNewBilan = "INSERT INTO `bilan` (`id`, `observation_hesitation`, `observation_concu`, `evaluation_impact`, `idRapport`) VALUES(NULL,'";
                reqNewBilan += bilan_Hesit_txbx.Text.ToString();
                reqNewBilan += "','";
                reqNewBilan += bilan_Concu_tbx.Text.ToString();
                reqNewBilan += "','";
                reqNewBilan += impact_tbx.Text.ToString();
                reqNewBilan += "','";
                reqNewBilan += lastReport;
                reqNewBilan += "')";

                CURS cs5 = new CURS(ChaineConnexion);
                cs5.ReqAdmin(reqNewBilan);
                cs5.fermer();

                DialogResult r = MessageBox.Show("Enregistrement validé! Voulez saisir des échantillons ?", "Mesage de confirmation", MessageBoxButtons.YesNo);
                if (r == DialogResult.No)
                {
                   
                    MessageBox.Show("Rapport inseré");
                     }

                else
                {



                    Echantillon ec = new Echantillon();
                    ec.ChaineConnexion = this.ChaineConnexion;
                    ec.UserCo = this.userCo;
                    ec.UserStatut = this.userStatut;
                    ec.UserMatricule = this.userMatricule;
                    ec.NumVisiteur = numvisiteur;
                    ec.NumRapport = lastReport;
                    ec.Show();
                }
            }
            

            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicamentTableAdapter.FillBy(this.gsbDataSet.medicament);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
