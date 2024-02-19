using CsvHelper.Configuration;
using CsvHelper;
using LumenWorks.Framework.IO.Csv;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;

namespace StudPass2024_1
{
    public partial class Form1 : Form
    {
        public PersonContext? dbContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.dbContext = new PersonContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Persons.Load<Person>();
            this.dbContext.Adresses.Load<Adress>();
            this.dbContext.EContacts.Load<EContact>();
            this.dbContext.AntropDatas.Load<AntropData>();
            this.dbContext.MeasuredDatas.Load<MeasuredData>();
            this.dbContext.QDatas.Load<QData>();

            personBindingSource.DataSource = this.dbContext.Persons.Local.ToBindingList();

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
            this.personBindingSource.ResetBindings(false);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                /* var person = (Person)this.dataGridView1.CurrentRow.DataBoundItem;

                 if (person != null)
                 {
                     this.dbContext.Entry(Adress).Collection(e => e.Adress).Load();
                 } */
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
            this.personBindingSource.ResetBindings(false);

            if (Control.ModifierKeys == Keys.Shift)
            {
                this.dbContext.Database.EnsureDeleted();
                this.dbContext.Database.EnsureCreated();
                this.Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (personBindingSource.Filter != string.Empty)
            {
                personBindingSource.RemoveFilter();
                this.personBindingSource.ResetBindings(false);
            }
            else
            {

                personBindingSource.Filter = $"LastName like '{toolStripTextBox1.Text}%'";
                dataGridView1.DataSource = personBindingSource;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.dbContext = this.dbContext;
            f.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var f = new Form3();
            f.dbContext = this.dbContext;
            f.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var f = new Form4();
            f.dbContext = this.dbContext;
            f.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // open the file "data.csv" which is a CSV file with headers
                using (var csv = new CachedCsvReader(new StreamReader(openFileDialog1.FileName), true, ';'))
                {
                    // Field headers will automatically be used as column names
                    var tmp = csv.ToList();
                    string s = tmp[0][0] + " " + tmp[0][1] + tmp[0][2];
                    if (s.Length > 0)
                    {

                        if (MessageBox.Show(s, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            foreach (var item in tmp)
                            {
                                var p = new Person()
                                { LastName = item[0], Name = item[1], MiddleName = item[2] };
                                dbContext.Persons.Add(p);
                            }
                            personBindingSource.ResetBindings(false);
                        }
                    }
                }
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            var queryAll1 = dbContext.Persons.ToList();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true // Include header row
            };

            config.Delimiter = ";";
            config.MemberTypes = MemberTypes.Properties;
            config.Quote = '"';
            try
            {

                using (var writer = new StreamWriter("person.csv"))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(queryAll1);
                }

                var queryAll2 = dbContext.Adresses.ToList();
                using (var writer = new StreamWriter("adress.csv"))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(queryAll2);
                }

                var queryAll3 = dbContext.EContacts.ToList();
                using (var writer = new StreamWriter("contacts.csv"))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(queryAll3);
                }

                var queryAll4 = dbContext.AntropDatas.ToList();
                using (var writer = new StreamWriter("antrodata.csv"))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(queryAll4);
                }

                var queryAll5 = dbContext.MeasuredDatas.ToList();
                using (var writer = new StreamWriter("mdata.csv"))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(queryAll5);
                }

                var queryAll6 = dbContext.QDatas.ToList();
                using (var writer = new StreamWriter("qdata.csv"))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(queryAll6);
                }
            }
            catch { };
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            var f = new Form5();
            f.dbContext = dbContext;

            f.ShowDialog();
        }
    }
}
