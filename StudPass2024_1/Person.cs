using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace StudPass2024_1
{
    public class Person
    {
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string? Name { get; set; } = "Имя";
        [DisplayName("Отчество")]
        public string? MiddleName { get; set; } = "Отчество";
        [DisplayName("Фамилия")]
        public string LastName { get; set; } = "Фамилия";
        [DisplayName("Дата рождения")]
        public DateTime? DateOfBirth { get; set; }
        [DisplayName("Возраст")]
        [NotMapped]
        public int Age
        {
            get
            {
                DateOfBirth ??= DateTime.Today;
                return (int)((DateTime.Today - DateOfBirth).Value.Days / 365.0);
            }
        }

        [DisplayName("Пол")]
        public bool? Gender { get; set; } = true;

        [DisplayName("Зачетная книжка")]
        public string? CreditBook { get; set; } = "000-000-000-000";

        [Timestamp]
        public byte[]? RowVersion { get; set; }

        // link to Adress
        public virtual ObservableCollectionListSource<Adress> Adresses { get; } = new();
        // link to Сontacts
        public virtual ObservableCollectionListSource<EContact> EContacts { get; } = new();
        // link to Antrop
        public virtual ObservableCollectionListSource<AntropData> AntropDatas { get; } = new();
        // link to Measured 
        public virtual ObservableCollectionListSource<MeasuredData> MeasuredDatas { get; } = new();
        // link to QData 
        public virtual ObservableCollectionListSource<QData> QDatas { get; } = new();

        public string FIO() => $"{LastName} {Name[0]}.{MiddleName[0]}.";

    }
}
