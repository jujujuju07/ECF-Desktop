using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ECF_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _ = panelInfoAsync();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private async Task panelInfoAsync()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


            var json = await client.GetStringAsync("http://192.168.1.38/ECF-Web/api/listPatientDesktop.php");
            var repositories = JsonConvert.DeserializeObject<List<Patient>>(json);

            foreach (var patient in repositories) 
            {
                Panel panel = new Panel();
                panel.Size = new Size(0, 50);
                panel.MaximumSize = new Size(0,50);
                panel.Location = new Point(0, 50);
                panel.Dock = DockStyle.Bottom;
                panel.Name = "panel11";
                Label label = new Label();
                label.Text = patient.nom + " " + patient.prenom;
                label.AutoSize = true;
                label.Location = new Point(59, 10);
                label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
                label.Name = "label11";
                CheckBox checkBoxEntre = new CheckBox();
                checkBoxEntre.Location = new Point(710, 20);
                checkBoxEntre.AutoSize = true;
                checkBoxEntre.Name = "checkBoxEntre11";
                checkBoxEntre.AutoCheck = false;
                if (patient.entre == 1) 
                {
                    checkBoxEntre.Checked = true;
                }
                CheckBox checkBoxSortie = new CheckBox();
                checkBoxSortie.Location = new Point(1140, 20);
                checkBoxSortie.AutoSize = true;
                checkBoxSortie.Name = "checkBoxSortie11";
                checkBoxSortie.AutoCheck = false;
                if (patient.sortie == 1) 
                {
                    checkBoxSortie.Checked = true;
                }
                Panel panelBottom = new Panel();
                panelBottom.BackColor = Color.Black;
                panelBottom.Location = new Point(0, 47);
                panelBottom.Name = "panelBottom11";
                panelBottom.Size = new Size(1254, 3);

                panel.Controls.Add(panelBottom);
                panel.Controls.Add(checkBoxSortie);
                panel.Controls.Add(checkBoxEntre);
                panel.Controls.Add(label);

                panel3.Controls.Add(panel);                
            }          
        }
    }
}
