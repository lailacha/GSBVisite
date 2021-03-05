using essaiMysql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GSBVisite
{
    public partial class Echantillon : Form
    {
        string chaineConnexion;  //ceci permettra la connexion à la base de données //		
        string userCo;
        string userStatut;
        string userMatricule;
        string numVisiteur;
        string numRapport;
        Dictionary<string, string> medicaments = new Dictionary<string, string>();
        public Echantillon()
        {
            InitializeComponent();
        }

        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
        public string UserCo { get => userCo; set => userCo = value; }
        public string UserStatut { get => userStatut; set => userStatut = value; }
        public string UserMatricule { get => userMatricule; set => userMatricule = value; }
        public string NumVisiteur { get => numVisiteur; set => numVisiteur = value; }
        public string NumRapport { get => numRapport; set => numRapport = value; }

        private void Echantillon_Load(object sender, EventArgs e)
        {


            echantillon_dataG.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            echantillon_dataG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            echantillon_dataG.ColumnHeadersDefaultCellStyle.Font =
                new Font(echantillon_dataG.Font, FontStyle.Bold);

            echantillon_dataG.Name = "echantillon_dataG";
            // dg.Location = new Point(8, 8);
            //  dg.Size = new Size(500, 250);
            echantillon_dataG.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            echantillon_dataG.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            echantillon_dataG.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            echantillon_dataG.GridColor = Color.Black;
            echantillon_dataG.RowHeadersVisible = false;
            supprimer.Text = "Supprimer";


            supprimer.HeaderText = "Supprimer";


            CURS cs1 = new CURS(ChaineConnexion);
            string requete = "SELECT `MED_NOMCOMMERCIAL`, `MED_DEPOTLEGAL` FROM `medicament` ";

            cs1.ReqSelect(requete);
            while (!cs1.Fin())
            {



                if (!medicaments.ContainsKey(cs1.champ("MED_NOMCOMMERCIAL").ToString()))
                {

                    medicaments.Add(cs1.champ("MED_NOMCOMMERCIAL").ToString(), cs1.champ("MED_DEPOTLEGAL").ToString());
                }
                med_cbx.Items.Add(cs1.champ("MED_NOMCOMMERCIAL"));

                cs1.suivant();
            }
            cs1.fermer();


           


            // TODO: cette ligne de code charge les données dans la table 'gsbDataSet1.medicament'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medicamentTableAdapter1.Fill(this.gsbDataSet1.medicament);
            // TODO: cette ligne de code charge les données dans la table 'gsbDataSet.medicament'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medicamentTableAdapter.Fill(this.gsbDataSet.medicament);

        }

        private void ech_add_btn_Click(object sender, EventArgs e)
        {
        
           
            echantillon_dataG.Rows.Add(med_cbx.Text.ToString());
            med_cbx.Items.Remove(med_cbx.Text.ToString());

        }

        private void echantillon_dataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = echantillon_dataG.CurrentCell.RowIndex;
            echantillon_dataG.Rows.RemoveAt(row);
        }

        private void button1_Click(object sender, EventArgs e)


        {
            CURS cs2 = new CURS(chaineConnexion);
            string req3 = "";
                

            

           

                foreach (DataGridViewRow row in echantillon_dataG.Rows)


            {
               
                req3 = "INSERT INTO `offrir`(`MED_DEPOTLEGAL`, `VIS_MATRICULE`, `rap_num`, `OFF_QTE`)  VALUES('";
            req3 += medicaments[row.Cells["med_col"].Value.ToString()] + "', '";
            req3 += NumVisiteur + "', '";
            req3 += NumRapport + "', ";
            req3 += "'1')";
            cs2.ReqAdmin(req3);
                 }
                MessageBox.Show("ajout effectué");
                cs2.fermer();
             
           

           
             

        }
    }
}
