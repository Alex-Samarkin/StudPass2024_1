using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudPass2024_1
{

    public partial class Form2 : Form
    {
        public PersonContext? dbContext;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.dbContext.Persons.Load<Person>();
            this.dbContext.Adresses.Load<Adress>();
            this.dbContext.EContacts.Load<EContact>();
            this.dbContext.AntropDatas.Load<AntropData>();
            personBindingSource.DataSource = this.dbContext.Persons.Local.ToBindingList();

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
            this.personBindingSource.ResetBindings(false);
        }
    }
}
