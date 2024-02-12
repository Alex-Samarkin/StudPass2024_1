namespace StudPass2024_1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            personBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateOfMeasurementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bPMDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sisPressureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diasPressureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saturationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            glucoseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eCGDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            leftEyeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            leftAsphDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rightEyeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rightAsphDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            depthbreathingvolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reserveexhalationvolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reserveinspiratoryvolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            residualvolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vitalCapacityCalcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vitalCapacityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bIADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rowVersionDataGridViewImageColumn1 = new DataGridViewImageColumn();
            personIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            measuredDatasBindingSource = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)measuredDatasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1 });
            toolStrip1.Location = new Point(121, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(210, 25);
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
            toolStripContainer1.ContentPanel.Size = new Size(1100, 483);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(5, 5);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1100, 533);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
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
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Size = new Size(1100, 483);
            splitContainer1.SplitterDistance = 246;
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
            dataGridView1.Size = new Size(1100, 246);
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
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, dateOfMeasurementDataGridViewTextBoxColumn, bPMDataGridViewTextBoxColumn, sisPressureDataGridViewTextBoxColumn, diasPressureDataGridViewTextBoxColumn, saturationDataGridViewTextBoxColumn, glucoseDataGridViewTextBoxColumn, eCGDataGridViewTextBoxColumn, leftEyeDataGridViewTextBoxColumn, leftAsphDataGridViewTextBoxColumn, rightEyeDataGridViewTextBoxColumn, rightAsphDataGridViewTextBoxColumn, depthbreathingvolDataGridViewTextBoxColumn, reserveexhalationvolDataGridViewTextBoxColumn, reserveinspiratoryvolDataGridViewTextBoxColumn, residualvolDataGridViewTextBoxColumn, vitalCapacityCalcDataGridViewTextBoxColumn, vitalCapacityDataGridViewTextBoxColumn, bIADataGridViewTextBoxColumn, rowVersionDataGridViewImageColumn1, personIdDataGridViewTextBoxColumn, personDataGridViewTextBoxColumn });
            dataGridView2.DataSource = measuredDatasBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1100, 233);
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
            // bPMDataGridViewTextBoxColumn
            // 
            bPMDataGridViewTextBoxColumn.DataPropertyName = "BPM";
            bPMDataGridViewTextBoxColumn.HeaderText = "Пульс, уд/мин";
            bPMDataGridViewTextBoxColumn.Name = "bPMDataGridViewTextBoxColumn";
            // 
            // sisPressureDataGridViewTextBoxColumn
            // 
            sisPressureDataGridViewTextBoxColumn.DataPropertyName = "SisPressure";
            sisPressureDataGridViewTextBoxColumn.HeaderText = "Давление нижнее, мм рт ст";
            sisPressureDataGridViewTextBoxColumn.Name = "sisPressureDataGridViewTextBoxColumn";
            // 
            // diasPressureDataGridViewTextBoxColumn
            // 
            diasPressureDataGridViewTextBoxColumn.DataPropertyName = "DiasPressure";
            diasPressureDataGridViewTextBoxColumn.HeaderText = "Давление верхнее, мм рт ст";
            diasPressureDataGridViewTextBoxColumn.Name = "diasPressureDataGridViewTextBoxColumn";
            // 
            // saturationDataGridViewTextBoxColumn
            // 
            saturationDataGridViewTextBoxColumn.DataPropertyName = "Saturation";
            saturationDataGridViewTextBoxColumn.HeaderText = "Сатурация, %";
            saturationDataGridViewTextBoxColumn.Name = "saturationDataGridViewTextBoxColumn";
            // 
            // glucoseDataGridViewTextBoxColumn
            // 
            glucoseDataGridViewTextBoxColumn.DataPropertyName = "Glucose";
            glucoseDataGridViewTextBoxColumn.HeaderText = "Концентрация глюкозы";
            glucoseDataGridViewTextBoxColumn.Name = "glucoseDataGridViewTextBoxColumn";
            // 
            // eCGDataGridViewTextBoxColumn
            // 
            eCGDataGridViewTextBoxColumn.DataPropertyName = "ECG";
            eCGDataGridViewTextBoxColumn.HeaderText = "Характер ЭКГ";
            eCGDataGridViewTextBoxColumn.Name = "eCGDataGridViewTextBoxColumn";
            // 
            // leftEyeDataGridViewTextBoxColumn
            // 
            leftEyeDataGridViewTextBoxColumn.DataPropertyName = "LeftEye";
            leftEyeDataGridViewTextBoxColumn.HeaderText = "Острота зрения (левый глаз)";
            leftEyeDataGridViewTextBoxColumn.Name = "leftEyeDataGridViewTextBoxColumn";
            // 
            // leftAsphDataGridViewTextBoxColumn
            // 
            leftAsphDataGridViewTextBoxColumn.DataPropertyName = "LeftAsph";
            leftAsphDataGridViewTextBoxColumn.HeaderText = "Астигматизм (левый глаз)";
            leftAsphDataGridViewTextBoxColumn.Name = "leftAsphDataGridViewTextBoxColumn";
            // 
            // rightEyeDataGridViewTextBoxColumn
            // 
            rightEyeDataGridViewTextBoxColumn.DataPropertyName = "RightEye";
            rightEyeDataGridViewTextBoxColumn.HeaderText = "Острота зрения (правый глаз)";
            rightEyeDataGridViewTextBoxColumn.Name = "rightEyeDataGridViewTextBoxColumn";
            // 
            // rightAsphDataGridViewTextBoxColumn
            // 
            rightAsphDataGridViewTextBoxColumn.DataPropertyName = "RightAsph";
            rightAsphDataGridViewTextBoxColumn.HeaderText = "Астигматизм (правый глаз)";
            rightAsphDataGridViewTextBoxColumn.Name = "rightAsphDataGridViewTextBoxColumn";
            // 
            // depthbreathingvolDataGridViewTextBoxColumn
            // 
            depthbreathingvolDataGridViewTextBoxColumn.DataPropertyName = "Depth_breathing_vol";
            depthbreathingvolDataGridViewTextBoxColumn.HeaderText = "Глубина дыхания, мл";
            depthbreathingvolDataGridViewTextBoxColumn.Name = "depthbreathingvolDataGridViewTextBoxColumn";
            // 
            // reserveexhalationvolDataGridViewTextBoxColumn
            // 
            reserveexhalationvolDataGridViewTextBoxColumn.DataPropertyName = "Reserve_exhalation_vol";
            reserveexhalationvolDataGridViewTextBoxColumn.HeaderText = "Резервный объем выдоха";
            reserveexhalationvolDataGridViewTextBoxColumn.Name = "reserveexhalationvolDataGridViewTextBoxColumn";
            // 
            // reserveinspiratoryvolDataGridViewTextBoxColumn
            // 
            reserveinspiratoryvolDataGridViewTextBoxColumn.DataPropertyName = "Reserve_inspiratory_vol";
            reserveinspiratoryvolDataGridViewTextBoxColumn.HeaderText = "Резервный объем вдоха";
            reserveinspiratoryvolDataGridViewTextBoxColumn.Name = "reserveinspiratoryvolDataGridViewTextBoxColumn";
            // 
            // residualvolDataGridViewTextBoxColumn
            // 
            residualvolDataGridViewTextBoxColumn.DataPropertyName = "Residual_vol";
            residualvolDataGridViewTextBoxColumn.HeaderText = "Остаточный объем";
            residualvolDataGridViewTextBoxColumn.Name = "residualvolDataGridViewTextBoxColumn";
            // 
            // vitalCapacityCalcDataGridViewTextBoxColumn
            // 
            vitalCapacityCalcDataGridViewTextBoxColumn.DataPropertyName = "VitalCapacityCalc";
            vitalCapacityCalcDataGridViewTextBoxColumn.HeaderText = "ЖЕЛ расчетная";
            vitalCapacityCalcDataGridViewTextBoxColumn.Name = "vitalCapacityCalcDataGridViewTextBoxColumn";
            vitalCapacityCalcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vitalCapacityDataGridViewTextBoxColumn
            // 
            vitalCapacityDataGridViewTextBoxColumn.DataPropertyName = "VitalCapacity";
            vitalCapacityDataGridViewTextBoxColumn.HeaderText = "ЖЕЛ измеренная";
            vitalCapacityDataGridViewTextBoxColumn.Name = "vitalCapacityDataGridViewTextBoxColumn";
            // 
            // bIADataGridViewTextBoxColumn
            // 
            bIADataGridViewTextBoxColumn.DataPropertyName = "BIA";
            bIADataGridViewTextBoxColumn.HeaderText = "Биоимпеданс";
            bIADataGridViewTextBoxColumn.Name = "bIADataGridViewTextBoxColumn";
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
            // measuredDatasBindingSource
            // 
            measuredDatasBindingSource.DataMember = "MeasuredDatas";
            measuredDatasBindingSource.DataSource = personBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 543);
            Controls.Add(toolStripContainer1);
            Name = "Form3";
            Padding = new Padding(5);
            Text = "Инструментально измеренные показатели";
            WindowState = FormWindowState.Maximized;
            Load += Form3_Load;
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
            ((System.ComponentModel.ISupportInitialize)measuredDatasBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripContainer toolStripContainer1;
        private ToolStripButton toolStripButton1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private BindingSource personBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateOfMeasurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bPMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sisPressureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diasPressureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saturationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn glucoseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eCGDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn leftEyeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn leftAsphDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rightEyeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rightAsphDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn depthbreathingvolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reserveexhalationvolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reserveinspiratoryvolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn residualvolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vitalCapacityCalcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vitalCapacityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bIADataGridViewTextBoxColumn;
        private DataGridViewImageColumn rowVersionDataGridViewImageColumn1;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private BindingSource measuredDatasBindingSource;
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