namespace StudPass2024_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            personBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateOfMeasurementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heightcmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightkgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bMIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            headcircDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            legslenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            handslenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            torsolenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            abdominalcircDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            waistcircDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hipscircDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            chestcircDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            neckcircDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bicepsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tricepsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thighcircDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calfcircDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rowVersionDataGridViewImageColumn1 = new DataGridViewImageColumn();
            personIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            antropDatasBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditBookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rowVersionDataGridViewImageColumn = new DataGridViewImageColumn();
            toolStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)antropDatasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(15, 0);
            toolStrip1.Margin = new Padding(3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(608, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(65, 22);
            toolStripLabel1.Text = "Навигатор";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(133, 22);
            toolStripButton1.Text = "Сохранить изменения";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(200, 22);
            toolStripButton2.Text = "Шаблон: мужчина среднего роста";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(198, 22);
            toolStripButton3.Text = "Шаблон: Девушка среднего роста";
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
            toolStripContainer1.ContentPanel.Padding = new Padding(5);
            toolStripContainer1.ContentPanel.Size = new Size(1117, 519);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(5, 5);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1117, 569);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 5);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Size = new Size(1107, 509);
            splitContainer1.SplitterDistance = 204;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, creditBookDataGridViewTextBoxColumn, rowVersionDataGridViewImageColumn });
            dataGridView1.DataSource = personBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1107, 204);
            dataGridView1.TabIndex = 0;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, dateOfMeasurementDataGridViewTextBoxColumn, heightcmDataGridViewTextBoxColumn, weightkgDataGridViewTextBoxColumn, bMIDataGridViewTextBoxColumn, headcircDataGridViewTextBoxColumn, legslenDataGridViewTextBoxColumn, handslenDataGridViewTextBoxColumn, torsolenDataGridViewTextBoxColumn, abdominalcircDataGridViewTextBoxColumn, waistcircDataGridViewTextBoxColumn, hipscircDataGridViewTextBoxColumn, chestcircDataGridViewTextBoxColumn, neckcircDataGridViewTextBoxColumn, bicepsDataGridViewTextBoxColumn, tricepsDataGridViewTextBoxColumn, thighcircDataGridViewTextBoxColumn, calfcircDataGridViewTextBoxColumn, rowVersionDataGridViewImageColumn1, personIdDataGridViewTextBoxColumn, personDataGridViewTextBoxColumn });
            dataGridView2.DataSource = antropDatasBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1107, 301);
            dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateOfMeasurementDataGridViewTextBoxColumn
            // 
            dateOfMeasurementDataGridViewTextBoxColumn.DataPropertyName = "DateOfMeasurement";
            dateOfMeasurementDataGridViewTextBoxColumn.HeaderText = "Дата измерения";
            dateOfMeasurementDataGridViewTextBoxColumn.Name = "dateOfMeasurementDataGridViewTextBoxColumn";
            // 
            // heightcmDataGridViewTextBoxColumn
            // 
            heightcmDataGridViewTextBoxColumn.DataPropertyName = "Height_cm";
            heightcmDataGridViewTextBoxColumn.HeaderText = "Рост см";
            heightcmDataGridViewTextBoxColumn.Name = "heightcmDataGridViewTextBoxColumn";
            // 
            // weightkgDataGridViewTextBoxColumn
            // 
            weightkgDataGridViewTextBoxColumn.DataPropertyName = "Weight_kg";
            weightkgDataGridViewTextBoxColumn.HeaderText = "Вес, кг";
            weightkgDataGridViewTextBoxColumn.Name = "weightkgDataGridViewTextBoxColumn";
            // 
            // bMIDataGridViewTextBoxColumn
            // 
            bMIDataGridViewTextBoxColumn.DataPropertyName = "BMI";
            bMIDataGridViewTextBoxColumn.HeaderText = "Индекс массы тела";
            bMIDataGridViewTextBoxColumn.Name = "bMIDataGridViewTextBoxColumn";
            bMIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headcircDataGridViewTextBoxColumn
            // 
            headcircDataGridViewTextBoxColumn.DataPropertyName = "Head_circ";
            headcircDataGridViewTextBoxColumn.HeaderText = "Охват головы, см";
            headcircDataGridViewTextBoxColumn.Name = "headcircDataGridViewTextBoxColumn";
            // 
            // legslenDataGridViewTextBoxColumn
            // 
            legslenDataGridViewTextBoxColumn.DataPropertyName = "Legs_len";
            legslenDataGridViewTextBoxColumn.HeaderText = "Длина ноги, см";
            legslenDataGridViewTextBoxColumn.Name = "legslenDataGridViewTextBoxColumn";
            // 
            // handslenDataGridViewTextBoxColumn
            // 
            handslenDataGridViewTextBoxColumn.DataPropertyName = "Hands_len";
            handslenDataGridViewTextBoxColumn.HeaderText = "Длина руки, см";
            handslenDataGridViewTextBoxColumn.Name = "handslenDataGridViewTextBoxColumn";
            // 
            // torsolenDataGridViewTextBoxColumn
            // 
            torsolenDataGridViewTextBoxColumn.DataPropertyName = "Torso_len";
            torsolenDataGridViewTextBoxColumn.HeaderText = "Длина туловища, см";
            torsolenDataGridViewTextBoxColumn.Name = "torsolenDataGridViewTextBoxColumn";
            // 
            // abdominalcircDataGridViewTextBoxColumn
            // 
            abdominalcircDataGridViewTextBoxColumn.DataPropertyName = "Abdominal_circ";
            abdominalcircDataGridViewTextBoxColumn.HeaderText = "Охват живота, см";
            abdominalcircDataGridViewTextBoxColumn.Name = "abdominalcircDataGridViewTextBoxColumn";
            // 
            // waistcircDataGridViewTextBoxColumn
            // 
            waistcircDataGridViewTextBoxColumn.DataPropertyName = "Waist_circ";
            waistcircDataGridViewTextBoxColumn.HeaderText = "Охват талии, см";
            waistcircDataGridViewTextBoxColumn.Name = "waistcircDataGridViewTextBoxColumn";
            // 
            // hipscircDataGridViewTextBoxColumn
            // 
            hipscircDataGridViewTextBoxColumn.DataPropertyName = "Hips_circ";
            hipscircDataGridViewTextBoxColumn.HeaderText = "Охват бедер, см";
            hipscircDataGridViewTextBoxColumn.Name = "hipscircDataGridViewTextBoxColumn";
            // 
            // chestcircDataGridViewTextBoxColumn
            // 
            chestcircDataGridViewTextBoxColumn.DataPropertyName = "Chest_circ";
            chestcircDataGridViewTextBoxColumn.HeaderText = "Охват груди, см";
            chestcircDataGridViewTextBoxColumn.Name = "chestcircDataGridViewTextBoxColumn";
            // 
            // neckcircDataGridViewTextBoxColumn
            // 
            neckcircDataGridViewTextBoxColumn.DataPropertyName = "Neck_circ";
            neckcircDataGridViewTextBoxColumn.HeaderText = "Охват шеи, см";
            neckcircDataGridViewTextBoxColumn.Name = "neckcircDataGridViewTextBoxColumn";
            // 
            // bicepsDataGridViewTextBoxColumn
            // 
            bicepsDataGridViewTextBoxColumn.DataPropertyName = "Biceps";
            bicepsDataGridViewTextBoxColumn.HeaderText = "Охват бицепса, см";
            bicepsDataGridViewTextBoxColumn.Name = "bicepsDataGridViewTextBoxColumn";
            // 
            // tricepsDataGridViewTextBoxColumn
            // 
            tricepsDataGridViewTextBoxColumn.DataPropertyName = "Triceps";
            tricepsDataGridViewTextBoxColumn.HeaderText = "Охват трицепса, см";
            tricepsDataGridViewTextBoxColumn.Name = "tricepsDataGridViewTextBoxColumn";
            // 
            // thighcircDataGridViewTextBoxColumn
            // 
            thighcircDataGridViewTextBoxColumn.DataPropertyName = "Thigh_circ";
            thighcircDataGridViewTextBoxColumn.HeaderText = "Охват бедер, см";
            thighcircDataGridViewTextBoxColumn.Name = "thighcircDataGridViewTextBoxColumn";
            // 
            // calfcircDataGridViewTextBoxColumn
            // 
            calfcircDataGridViewTextBoxColumn.DataPropertyName = "Calf_circ";
            calfcircDataGridViewTextBoxColumn.HeaderText = "Охват икры, см";
            calfcircDataGridViewTextBoxColumn.Name = "calfcircDataGridViewTextBoxColumn";
            // 
            // rowVersionDataGridViewImageColumn1
            // 
            rowVersionDataGridViewImageColumn1.DataPropertyName = "RowVersion";
            rowVersionDataGridViewImageColumn1.HeaderText = "RowVersion";
            rowVersionDataGridViewImageColumn1.Name = "rowVersionDataGridViewImageColumn1";
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
            // antropDatasBindingSource
            // 
            antropDatasBindingSource.DataMember = "AntropDatas";
            antropDatasBindingSource.DataSource = personBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
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
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 579);
            Controls.Add(toolStripContainer1);
            Name = "Form2";
            Padding = new Padding(5);
            Text = "Антропометрические данные";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)antropDatasBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripContainer toolStripContainer1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private BindingSource personBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateOfMeasurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightcmDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightkgDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bMIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn headcircDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legslenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn handslenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn torsolenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn abdominalcircDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn waistcircDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hipscircDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn chestcircDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn neckcircDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bicepsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tricepsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thighcircDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calfcircDataGridViewTextBoxColumn;
        private DataGridViewImageColumn rowVersionDataGridViewImageColumn1;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private BindingSource antropDatasBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditBookDataGridViewTextBoxColumn;
        private DataGridViewImageColumn rowVersionDataGridViewImageColumn;
    }
}