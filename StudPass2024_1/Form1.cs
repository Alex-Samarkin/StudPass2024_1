using Microsoft.EntityFrameworkCore;
using System.Data;

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
            //this.dbContext.MeasuredDatas.Load<MeasuredData>();

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
            var f = new Form2();
            f.dbContext = this.dbContext;
            f.ShowDialog();
        }
    }
}
