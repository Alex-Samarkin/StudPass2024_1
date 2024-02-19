namespace EFCoreTextGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var className = textBox1.Text + "Context";
            var s1 = 
                $@"public class {className} : DbContext 
{{";


            var s2 = $@"       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(""Data Source={textBox3.Text}.db"");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {{

        }}
}}";

            textBox2.Text = s1+s2;
            ;
        }
    }
}
