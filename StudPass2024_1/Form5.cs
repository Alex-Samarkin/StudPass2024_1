using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
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
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace StudPass2024_1
{
    public partial class Form5 : Form
    {
        public PersonContext? dbContext;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.dbContext.Persons.Load<Person>();
            this.dbContext.Adresses.Load<Adress>();
            this.dbContext.EContacts.Load<EContact>();
            this.dbContext.AntropDatas.Load<AntropData>();
            this.dbContext.MeasuredDatas.Load<MeasuredData>();
            this.dbContext.QDatas.Load<QData>();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var age = new List<double>();
            var names = new List<string>();

            foreach (Person person in this.dbContext.Persons)
            {
                age.Add(person.Age);
                names.Add(person.FIO());
            }

            cartesianChart1.Series = new ISeries[]
            {
                    new LineSeries<double>
                    {
                        Values = age.ToArray()
                     }

            };
            cartesianChart1.XAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        Labels = names.ToArray(),
                        Name = "Фамилии",
                        LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };
            cartesianChart1.YAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        //Labels = names.ToArray(),
                        Name = "Возраст",
                        //LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var height = new List<int?>();
            var names = new List<string>();

            foreach (Person person in this.dbContext.Persons)
            {
                height.Add((int?)person.AntropDatas[0].Height_cm);
                names.Add(person.FIO());
            }

            cartesianChart1.Series = new ISeries[]
            {
                    new LineSeries<int?>
                    {
                        Values = height.ToArray<int?>()
                     }

            };
            cartesianChart1.XAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        Labels = names.ToArray(),
                        Name = "Фамилии",
                        LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };
            cartesianChart1.YAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        //Labels = names.ToArray(),
                        Name = "Рост, см",
                        //LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var weight = new List<int?>();
            var names = new List<string>();

            foreach (Person person in this.dbContext.Persons)
            {
                weight.Add((int?)person.AntropDatas[0].Weight_kg);
                names.Add(person.FIO());
            }

            cartesianChart1.Series = new ISeries[]
            {
                    new LineSeries<int?>
                    {
                        Values = weight.ToArray<int?>()
                     }

            };
            cartesianChart1.XAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        Labels = names.ToArray(),
                        Name = "Фамилии",
                        LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };
            cartesianChart1.YAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        //Labels = names.ToArray(),
                        Name = "Вес, кГ",
                        //LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var bmi = new List<double?>();
            var names = new List<string>();

            foreach (Person person in this.dbContext.Persons)
            {
                bmi.Add((double?)person.AntropDatas[0].BMI);
                names.Add(person.FIO());
            }

            cartesianChart1.Series = new ISeries[]
            {
                    new LineSeries<double?>
                    {
                        Values = bmi.ToArray<double?>()
                     }

            };
            cartesianChart1.XAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        Labels = names.ToArray(),
                        Name = "Фамилии",
                        LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };
            cartesianChart1.YAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        //Labels = names.ToArray(),
                        Name = "Индекс массы тела",
                        //LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var sist = new List<int?>();
            var diast = new List<int?>();
            var names = new List<string>();

            foreach (Person person in this.dbContext.Persons)
            {
                sist.Add((int?)person.MeasuredDatas[0].SisPressure);
                diast.Add((int?)person.MeasuredDatas[0].DiasPressure);
                names.Add(person.FIO());
            }

            cartesianChart1.Series = new ISeries[]
            {
                    new ColumnSeries<int?>
                    {
                        Values = sist.ToArray<int?>(),
                        IgnoresBarPosition = true
                     },
                    new ColumnSeries<int?>
                    {
                        Values = diast.ToArray<int?>(),
                        IgnoresBarPosition = true
                     }

            };
            cartesianChart1.XAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        Labels = names.ToArray(),
                        Name = "Фамилии",
                        LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };
            cartesianChart1.YAxes = new List<Axis>{
                    new Axis
                    {
                        // Use the labels property to define named labels.
                        //Labels = names.ToArray(),
                        Name = "Давление",
                        //LabelsRotation = 90,
                        LabelsPaint = new SolidColorPaint(SKColors.DarkBlue),
                        TextSize = 10,
                    }
            };

        }
    }
}
