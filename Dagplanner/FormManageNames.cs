using Microsoft.Data.Sqlite;
using Dapper;
namespace Dagplanner
{
    public partial class FormManageNames : Form
    {
        public FormManageNames()
        {
            InitializeComponent();
        }
        //globale variabelen
        List<Werknemer> listFulltime = new List<Werknemer>();
        List<Werknemer> listParttime = new List<Werknemer>();
        List<Stagiaire> listStag = new List<Stagiaire>();
        string connectionString = new SqliteConnectionStringBuilder()
        {
            Mode = SqliteOpenMode.ReadWriteCreate,
            DataSource = Environment.CurrentDirectory + "\\werknemers.db"
        }.ToString();

        private void FormManageNames_Load(object sender, EventArgs e)
        {
            //form niet resizable maken
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // namen uit db halen
            RefreshLists();
            //default value comboboxtype
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                // dagen not null check voor stagaire
                if (textBoxDaysLeft.Text == "" && comboBoxType.SelectedIndex == 2)
                {
                    MessageBox.Show("Voer het aantal dagen in!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var sql = $"INSERT INTO werknemer (voornaam,achternaam,isFulltime,dagen) VALUES ('{textBoxFirst.Text}','{textBoxLast.Text}',{comboBoxType.SelectedIndex},{textBoxDaysLeft.Text})";
                    connection.Execute(sql);
                }
                connection.Close();
            }
            // namen uit db halen
            RefreshLists();
        }
        public void RefreshLists()
        {
            //listbox leegmaken
            listBoxFull.Items.Clear();
            listBoxPart.Items.Clear();
            listBoxStag.Items.Clear();
            listFulltime.Clear();
            listParttime.Clear();
            listStag.Clear();

            //werknemers uit db halen en onderverdelen
            var sql = "select * from werknemer";
            var werknemers = new List<Database>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                werknemers = (List<Database>)connection.Query<Database>(sql);
                foreach (Database werk in werknemers)
                {
                    // iemand met beperkte dagen is stagaire
                    int daysLeft = werk.getDays();
                    if (daysLeft > 0)
                    {
                        //stagaire aanmaken en aan lijst toevoegen
                        Stagiaire stag = new Stagiaire(werk.getId(), werk.getFirstname(), werk.getLastname(), werk.getIsFulltime(), werk.getDays());
                        listStag.Add(stag);
                    }
                    else
                    {
                        //werknemer aanmaken en aan lijst toevoegen
                        Werknemer werknemer = new Werknemer(werk.getId(), werk.getFirstname(), werk.getLastname(), werk.getIsFulltime());
                        if (werknemer.getIsFulltime())
                        {
                            //fulltime werknemer aan lijst toevoegen
                            listFulltime.Add(werknemer);
                        }
                        else
                        {
                            //parttime werknemer aan lijst toevoegen
                            listParttime.Add(werknemer);
                        }
                    }
                }
                connection.Close();
            }
            // alle werknemers aan de juiste listbox tovoegen
            foreach (Werknemer werk in listFulltime)
            {
                listBoxFull.Items.Add(werk.ToString());
            }
            foreach (Werknemer werk in listParttime)
            {
                listBoxPart.Items.Add(werk.ToString());
            }
            foreach (Stagiaire stag in listStag)
            {
                listBoxStag.Items.Add(stag.ToString());
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // knoppen bewegen voor stagaire
            if (comboBoxType.SelectedIndex == 2)
            {
                textBoxDaysLeft.Enabled= true;
                textBoxDaysLeft.Text = "1";
            }
            else
            {
                textBoxDaysLeft.Enabled = false;
                textBoxDaysLeft.Text = "0";
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // namen uit db halen
            RefreshLists();
        }
        public void RemoveEmployee(string name)
        {
            int id = -1;
            //naam opzoeken in lijst
            foreach (Werknemer werk in listFulltime)
            {
                if (werk.ToString().Equals(name))
                {
                    id = werk.getId();
                }
            }foreach (Werknemer werk in listParttime)
            {
                if (werk.ToString().Equals(name))
                {
                    id = werk.getId();
                }
            }
            foreach (Stagiaire stag in listStag)
            {
                if (stag.ToString().Equals(name))
                {
                    id = stag.getId();
                }
            }
            if (id > 0)
            {

                // werknemer verwijderen adhv een id
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    var sql = $"DELETE FROM werknemer WHERE id={id}";
                    connection.Execute(sql);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Deze naam werd niet gevonden in de database!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            // namen uit db halen
            RefreshLists();
        }

        private void buttonRemoveFull_Click(object sender, EventArgs e)
        {
            //werknemer verwijderen
            RemoveEmployee(listBoxFull.Text);
        }

        private void buttonRemovePart_Click(object sender, EventArgs e)
        {
            //werknemer verwijderen
            RemoveEmployee(listBoxPart.Text);
        }

        private void buttonRemoveStag_Click(object sender, EventArgs e)
        {
            //werknemer verwijderen
            RemoveEmployee(listBoxStag.Text);
        }
    }
}
