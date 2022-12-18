using Dapper;
using Microsoft.Data.Sqlite;
using Spire.Xls;
using System.Data.SQLite;
using System.Diagnostics;
using System.Text;
namespace Dagplanner
{
    public partial class FormPlanner : Form
    {
        public FormPlanner()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }
        //globale variabelen
        string connectionString = new SqliteConnectionStringBuilder()
        {
            Mode = SqliteOpenMode.ReadWriteCreate,
            DataSource = Environment.CurrentDirectory + "\\werknemers.db"
        }.ToString();
        List<string> tasks = new List<string>();
        List<List<DateTime>> dates = new List<List<DateTime>>();


        private void buttonManageNames_Click(object sender, EventArgs e)
        {
            //opent het naambeheer venster
            FormManageNames windowManageNames = new FormManageNames();
            windowManageNames.ShowDialog();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (listBoxAll.SelectedIndex >= 0)
            {
                if (tasks.Count > 0)
                {
                    // maakt een workbook object aan zonder bladen
                    Workbook workbook = new Workbook();
                    workbook.Worksheets.Clear();
                    
                    //maakt een blad genaamt plannning aan
                    Worksheet worksheet = workbook.Worksheets.Add("Planning");
                    
                    // cellen aanvullen
                    worksheet.Range[1, 2].Value = "Tasks";
                    worksheet.Range[1, 1].Value = listBoxAll.Text;
                    worksheet.Range[1, 1].Style.HorizontalAlignment = HorizontalAlignType.Center;
                    worksheet.Range[1, 2].Style.HorizontalAlignment = HorizontalAlignType.Center;
                    worksheet.Range[1, 1].Style.Font.IsBold= true;

                    //startdatum
                    DateTime time = DateTime.Parse("08:30");

                    //taken toevoegen aan juiste cellen
                    for (int i = 2; i < 31; i++)
                    {
                        for (int j = 0; j < tasks.Count; j++)
                        {
                            if (dates[j][0].Ticks <= time.AddMinutes(30 * (i - 2)).Ticks && time.AddMinutes(30 * (i - 2)).Ticks <= dates[j][1].Ticks)
                            {
                                worksheet.Range[i, 2].Value = tasks[j];
                            }
                            worksheet.Range[i, 1].Value = time.AddMinutes(30 * (i - 2)).ToShortTimeString();
                            worksheet.Range[i, 1].Style.NumberFormat = "hh:mm";
                        }

                    }

                    //automatische kolombreedte
                    worksheet.AllocatedRange.AutoFitColumns();

                    // catch als bestand al open staat
                    try
                    {
                        //Bestand opslaan en openen
                        workbook.SaveToFile("Dagplanning.xlsx", ExcelVersion.Version2016);
                        var p = new Process();
                        p.StartInfo = new ProcessStartInfo(Environment.CurrentDirectory + "\\Dagplanning.xlsx")
                        {
                            UseShellExecute = true
                        };
                        p.Start();
                    }
                    catch (IOException)
                    {

                        MessageBox.Show("Gelieve het bestand eerst te sluiten!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Geen taken om te exporteren!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Duid aub een werknemer aan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Databank aanmaken als die nog niet bestaat
            if (!File.Exists(Environment.CurrentDirectory + "\\werknemers.db"))
            {
                SQLiteConnection.CreateFile(Environment.CurrentDirectory + "\\werknemers.db");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "CREATE TABLE werknemer(id INTEGER PRIMARY KEY UNIQUE NOT NULL, voornaam TEXT NOT NULL, achternaam TEXT NOT NULL, isFulltime INTEGER NOT NULL, dagen INTEGER NOT NULL);";
                    connection.Execute(sql);
                    connection.Close();
                }
            }

            //form niet resizable maken
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            // formaat datetimepickers aanpassen
            dateTimePickerStart.Format = DateTimePickerFormat.Time;
            dateTimePickerEnd.Format = DateTimePickerFormat.Time;
            dateTimePickerStart.ShowUpDown = true;
            dateTimePickerEnd.ShowUpDown = true;

            // namen uit db halen
            RefreshLists();

        }

        public void RefreshLists()
        {
            
            //listbox leegmaken
            listBoxAll.Items.Clear();
            // namen uit db halen
            var sql = "select * from werknemer";
            var werknemers = new List<Database>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                werknemers = (List<Database>)connection.Query<Database>(sql);
                foreach (Database werk in werknemers)
                {
                    listBoxAll.Items.Add(werk.ToString());
                }
                connection.Close();
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            //einddatum niet voor begindatum check
            TimeSpan time = dateTimePickerEnd.Value.Subtract(dateTimePickerStart.Value);
            if (time.Ticks > 0)
            {
                if (textBoxToDo.Text != "")
                {
                    // als textbox niet leeg is taken en data toevoegen aan lijst
                    listBoxTasks.Items.Add(textBoxToDo.Text + " " + dateTimePickerStart.Value.ToShortTimeString() + " until " + dateTimePickerEnd.Value.ToShortTimeString());
                    List<DateTime> timespans= new List<DateTime>();
                    timespans.Add(dateTimePickerStart.Value);
                    timespans.Add(dateTimePickerEnd.Value);
                    dates.Add(timespans);
                    tasks.Add(textBoxToDo.Text);
                }
                else
                {
                    MessageBox.Show("Voer aub een taak in!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Gelieve een tijd in de toekomst in te geven!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // namen uit db halen
            RefreshLists();
        }

        private void buttonClearTasks_Click(object sender, EventArgs e)
        {
            //tasks weghalen
            listBoxTasks.Items.Clear();
            tasks.Clear();
            dates.Clear();
        }
    }
}