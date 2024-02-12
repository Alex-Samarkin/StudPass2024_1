using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace StudPass2024_1
{
    public class Adress
    {
        public int Id { get; set; }
        [DisplayName("Государство")]
        public string State { get; set; } = "РФ";
        [DisplayName("Регион")]
        public string Province { get; set; } = "Северо-Запад";
        [DisplayName("Область")]
        public string Region { get; set; } = "Псковская обл";
        [DisplayName("Населенный пункт")]
        public string City { get; set; } = "Псков";
        [DisplayName("Улица")]
        public string Street { get; set; } = "Красноармейская";
        [DisplayName("Дом")]
        public string House { get; set; } = "4";
        [DisplayName("Корпус")]
        public string Building { get; set; } = "1";
        [DisplayName("Квартира/Комната")]
        public string Apartment { get; set; } = "1";

        #region to link person
        public int PersonId { get; set; }
        public virtual Person Person { get; set; } = null!;
        #endregion
    }
}
