using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudPass2024_1
{
    public class EContact
    {
        public int Id { get; set; }

        [DisplayName("Телефон")]
        public string Phone { get; set; } = "8(911)123-12-12";
        [DisplayName("Телефон 2")]
        public string Phone2 { get; set; } = "";
        
        [DisplayName("E-mail")]
        public string E_mail { get; set; } = "email@mail.ru";

        [DisplayName("E-mail2")]
        public string E_mail2 { get; set; } = "-";
        [DisplayName("Вконтакте")]
        public string VkId { get; set; } = "Vk";
        [DisplayName("Телеграм")]
        public string TgId { get; set; } = "Tg id";
        [DisplayName("Другое")]
        public string Other { get; set; } = "Name#Id";
        [DisplayName("Другое 1")]
        public string Other1 { get; set; } = "Name#Id";

        #region to link person
        public int PersonId { get; set; }
        public virtual Person Person { get; set; } = null!;
        #endregion
    }
}
