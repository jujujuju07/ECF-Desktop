using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECF_Desktop
{
    public partial class detail : Form
    {
        public int id;
        public String nomPrenom;
        public String adresse;

        public detail()
        {
            InitializeComponent();
        }

        private void detail_Load(object sender, EventArgs e)
        {
            labelNomPrenom.Text = nomPrenom;

            panelInfoAsync();
        }

        private async Task panelInfoAsync()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var json = await client.GetStringAsync(adresse + "/ECF-Web/api/consultationSejour.php?idSejour=" + id);
            var sejour = JsonConvert.DeserializeObject<Sejour>(json);
            textBoxMotifSejour.Text = sejour.motif;
            textBoxDateDebut.Text = sejour.date;
            if (sejour.entre == 1)
            {
                checkBoxEntre.Checked = true;
            }
            if (sejour.sortie == 1)
            {
                checkBoxSortie.Checked = true;
            }

            var json1 = await client.GetStringAsync(adresse + "/ECF-Web/api/listAvis.php?idPatient=" + sejour.patient);
            var listAvis = JsonConvert.DeserializeObject<List<listAvis>>(json1);
            foreach (var avis in listAvis) 
            {
                Panel panel = new Panel();
                panel.Size = new Size(0, 50);
                panel.MaximumSize = new Size(0, 50);
                panel.Location = new Point(0, 50);
                panel.Dock = DockStyle.Bottom;
                panel.Name = "panel11";
                panel.Click += new EventHandler(click);
                Label label = new Label();
                label.Text = avis.titre;
                label.AutoSize = true;
                label.Location = new Point(5, 10);
                label.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
                label.Name = "label11";
                label.Click += new EventHandler(click);
                Panel panelBottom = new Panel();
                panelBottom.BackColor = Color.Black;
                panelBottom.Location = new Point(0, 47);
                panelBottom.Name = "panelBottom11";
                panelBottom.Size = new Size(248, 3);


                void click(object sender, EventArgs e)
                {
                    requeteAvis(avis.id);

                }

                panel.Controls.Add(panelBottom);
                panel.Controls.Add(label);

                panelListAvis.Controls.Add(panel);

            }

            var json2 = await client.GetStringAsync(adresse + "/ECF-Web/api/listPrescription.php?idPatient=" + sejour.patient);
            var listPrescription = JsonConvert.DeserializeObject<List<listPrescription>>(json2);
            foreach (var prescription in listPrescription)
            {
                Panel panel = new Panel();
                panel.Size = new Size(0, 50);
                panel.MaximumSize = new Size(0, 50);
                panel.Location = new Point(0, 50);
                panel.Dock = DockStyle.Bottom;
                panel.Name = "panel11";
                panel.Click += new EventHandler(click);
                Label label = new Label();
                label.Text = prescription.liste_medicament;
                label.AutoSize = true;
                label.Location = new Point(5, 10);
                label.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
                label.Name = "label11";
                label.Click += new EventHandler(click);
                Panel panelBottom = new Panel();
                panelBottom.BackColor = Color.Black;
                panelBottom.Location = new Point(0, 47);
                panelBottom.Name = "panelBottom11";
                panelBottom.Size = new Size(248, 3);


                void click(object sender, EventArgs e)
                {
                    requetePrescription(prescription.id);

                }

                panel.Controls.Add(panelBottom);
                panel.Controls.Add(label);

                panelListPrescription.Controls.Add(panel);

            }


        }

        private async Task requeteAvis(int id)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var json = await client.GetStringAsync(adresse + "/ECF-Web/api/consultationAvis.php?idAvis=" + id);
            var avis = JsonConvert.DeserializeObject<Avis>(json);
            textBoxTitreAvis.Text = avis.titre;
            textBoxDate.Text = avis.date;
            textBoxDescription.Text = avis.description;

            var json1 = await client.GetStringAsync(adresse + "/ECF-Web/api/consultationMedecin.php?idMedecin=" + avis.medecin);
            var medecin = JsonConvert.DeserializeObject<Medecin>(json1);

            textBoxNomPrenomMedecin.Text = medecin.nom + " " + medecin.prenom;

        }

        private async Task requetePrescription(int id)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var json = await client.GetStringAsync(adresse + "/ECF-Web/api/consultationprescription.php?idPrescription=" + id);
            var prescription = JsonConvert.DeserializeObject<Prescription>(json);
            textBoxListeMedicament.Text = prescription.liste_medicament;
            textBoxPosologie.Text = prescription.posologie;
            textBoxDateDebutP.Text = prescription.date_debut;
            textBoxDateFinP.Text = prescription.date_fin;

        }

        private void pictureBoxValider_Click(object sender, EventArgs e)
        {
            validerEntreSortie();

            this.Close();
        }

        private async Task validerEntreSortie()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            String entre = "0";
            String sortie = "0";

            if(checkBoxEntre.CheckState == CheckState.Checked)
            {
                entre = "1";
            }

            if(checkBoxSortie.CheckState == CheckState.Checked)
            {
                entre = "1";
                sortie = "1";
            }

            await client.GetStringAsync(adresse + "/ECF-Web/api/modifierEntreSortie.php?id=" + id + "&entre=" + entre + "&sortie=0" + sortie);
        }

        private void pictureBoxRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
