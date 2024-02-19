namespace StudPass2024_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            personBindingSource = new BindingSource(components);
            adressesBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            creditBookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rowVersionDataGridViewImageColumn = new DataGridViewImageColumn();
            splitContainer2 = new SplitContainer();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            provinceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            streetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            houseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            buildingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apartmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adressesBindingSource1 = new BindingSource(components);
            dataGridView3 = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phone2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            email2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vkIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tgIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            otherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            other1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            personDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            eContactsBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            toolStripButton6 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adressesBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adressesBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eContactsBindingSource).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // adressesBindingSource
            // 
            adressesBindingSource.DataMember = "Adresses";
            adressesBindingSource.DataSource = personBindingSource;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1, toolStripTextBox1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(8, 0);
            toolStrip1.Margin = new Padding(3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(3);
            toolStrip1.Size = new Size(778, 29);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(65, 20);
            toolStripLabel1.Text = "Навигатор";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(133, 20);
            toolStripButton1.Text = "Сохранить изменения";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(52, 20);
            toolStripButton2.Text = "Фильтр";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(175, 20);
            toolStripButton3.Text = "Антропометрические данные";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(111, 20);
            toolStripButton4.Text = "Инстр. измерения";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(123, 20);
            toolStripButton5.Text = "Быстрые измерения";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Size = new Size(952, 622);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(5, 5);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Padding = new Padding(3);
            toolStripContainer1.Size = new Size(958, 682);
            toolStripContainer1.TabIndex = 4;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip2);
            toolStripContainer1.TopToolStripPanel.Padding = new Padding(3);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(952, 622);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.SplitterWidth = 8;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, genderDataGridViewCheckBoxColumn, creditBookDataGridViewTextBoxColumn, rowVersionDataGridViewImageColumn });
            dataGridView1.DataSource = personBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(952, 260);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewCheckBoxColumn.HeaderText = "Пол";
            genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            // 
            // creditBookDataGridViewTextBoxColumn
            // 
            creditBookDataGridViewTextBoxColumn.DataPropertyName = "CreditBook";
            creditBookDataGridViewTextBoxColumn.HeaderText = "Зачетная книжка";
            creditBookDataGridViewTextBoxColumn.Name = "creditBookDataGridViewTextBoxColumn";
            // 
            // rowVersionDataGridViewImageColumn
            // 
            rowVersionDataGridViewImageColumn.DataPropertyName = "RowVersion";
            rowVersionDataGridViewImageColumn.HeaderText = "RowVersion";
            rowVersionDataGridViewImageColumn.Name = "rowVersionDataGridViewImageColumn";
            rowVersionDataGridViewImageColumn.ReadOnly = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dataGridView3);
            splitContainer2.Size = new Size(952, 354);
            splitContainer2.SplitterDistance = 207;
            splitContainer2.SplitterWidth = 8;
            splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, stateDataGridViewTextBoxColumn, provinceDataGridViewTextBoxColumn, regionDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, streetDataGridViewTextBoxColumn, houseDataGridViewTextBoxColumn, buildingDataGridViewTextBoxColumn, apartmentDataGridViewTextBoxColumn, personIdDataGridViewTextBoxColumn, personDataGridViewTextBoxColumn });
            dataGridView2.DataSource = adressesBindingSource1;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(952, 207);
            dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 42;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "Государство";
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            provinceDataGridViewTextBoxColumn.HeaderText = "Регион";
            provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            regionDataGridViewTextBoxColumn.HeaderText = "Область";
            regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "Населенный пункт";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // houseDataGridViewTextBoxColumn
            // 
            houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            // 
            // buildingDataGridViewTextBoxColumn
            // 
            buildingDataGridViewTextBoxColumn.DataPropertyName = "Building";
            buildingDataGridViewTextBoxColumn.HeaderText = "Корпус";
            buildingDataGridViewTextBoxColumn.Name = "buildingDataGridViewTextBoxColumn";
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            apartmentDataGridViewTextBoxColumn.HeaderText = "Квартира/Комната";
            apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            personIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personDataGridViewTextBoxColumn
            // 
            personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            personDataGridViewTextBoxColumn.HeaderText = "Person";
            personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            personDataGridViewTextBoxColumn.Visible = false;
            // 
            // adressesBindingSource1
            // 
            adressesBindingSource1.DataMember = "Adresses";
            adressesBindingSource1.DataSource = personBindingSource;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, phoneDataGridViewTextBoxColumn, phone2DataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, email2DataGridViewTextBoxColumn, vkIdDataGridViewTextBoxColumn, tgIdDataGridViewTextBoxColumn, otherDataGridViewTextBoxColumn, other1DataGridViewTextBoxColumn, personIdDataGridViewTextBoxColumn1, personDataGridViewTextBoxColumn1 });
            dataGridView3.DataSource = eContactsBindingSource;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(952, 139);
            dataGridView3.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // phone2DataGridViewTextBoxColumn
            // 
            phone2DataGridViewTextBoxColumn.DataPropertyName = "Phone2";
            phone2DataGridViewTextBoxColumn.HeaderText = "Телефон 2";
            phone2DataGridViewTextBoxColumn.Name = "phone2DataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "E_mail";
            emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // email2DataGridViewTextBoxColumn
            // 
            email2DataGridViewTextBoxColumn.DataPropertyName = "E_mail2";
            email2DataGridViewTextBoxColumn.HeaderText = "E-mail2";
            email2DataGridViewTextBoxColumn.Name = "email2DataGridViewTextBoxColumn";
            // 
            // vkIdDataGridViewTextBoxColumn
            // 
            vkIdDataGridViewTextBoxColumn.DataPropertyName = "VkId";
            vkIdDataGridViewTextBoxColumn.HeaderText = "Вконтакте";
            vkIdDataGridViewTextBoxColumn.Name = "vkIdDataGridViewTextBoxColumn";
            // 
            // tgIdDataGridViewTextBoxColumn
            // 
            tgIdDataGridViewTextBoxColumn.DataPropertyName = "TgId";
            tgIdDataGridViewTextBoxColumn.HeaderText = "Телеграм";
            tgIdDataGridViewTextBoxColumn.Name = "tgIdDataGridViewTextBoxColumn";
            // 
            // otherDataGridViewTextBoxColumn
            // 
            otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            otherDataGridViewTextBoxColumn.HeaderText = "Другое";
            otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            // 
            // other1DataGridViewTextBoxColumn
            // 
            other1DataGridViewTextBoxColumn.DataPropertyName = "Other1";
            other1DataGridViewTextBoxColumn.HeaderText = "Другое 1";
            other1DataGridViewTextBoxColumn.Name = "other1DataGridViewTextBoxColumn";
            // 
            // personIdDataGridViewTextBoxColumn1
            // 
            personIdDataGridViewTextBoxColumn1.DataPropertyName = "PersonId";
            personIdDataGridViewTextBoxColumn1.HeaderText = "PersonId";
            personIdDataGridViewTextBoxColumn1.Name = "personIdDataGridViewTextBoxColumn1";
            // 
            // personDataGridViewTextBoxColumn1
            // 
            personDataGridViewTextBoxColumn1.DataPropertyName = "Person";
            personDataGridViewTextBoxColumn1.HeaderText = "Person";
            personDataGridViewTextBoxColumn1.Name = "personDataGridViewTextBoxColumn1";
            personDataGridViewTextBoxColumn1.Visible = false;
            // 
            // eContactsBindingSource
            // 
            eContactsBindingSource.DataMember = "EContacts";
            eContactsBindingSource.DataSource = personBindingSource;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton6, toolStripButton7 });
            toolStrip2.Location = new Point(3, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(173, 25);
            toolStrip2.TabIndex = 0;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(61, 22);
            toolStripButton6.Text = "Load CSV";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(69, 22);
            toolStripButton7.Text = "Export CSV";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "CSV|*.csv";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 692);
            Controls.Add(toolStripContainer1);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "Паспорт студента - главная форма";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)adressesBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)adressesBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)eContactsBindingSource).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource personBindingSource;
        private DataGridViewTextBoxColumn adressStringDataGridViewTextBoxColumn;
        private BindingSource adressesBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripContainer toolStripContainer1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView2;
        private BindingSource adressesBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn creditBookDataGridViewTextBoxColumn;
        private DataGridViewImageColumn rowVersionDataGridViewImageColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn email2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vkIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tgIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn other1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn personDataGridViewTextBoxColumn1;
        private BindingSource eContactsBindingSource;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private OpenFileDialog openFileDialog1;
    }
}
