using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudPass2024_1
{
    public class QData
    {
        public int Id { get; set; }

        [DisplayName("Дата и время измерения")]
        public DateTime? TimeOfMeasurement { get; set; } = DateTime.Now;
        [DisplayName("Вид анализа / измерения")]
        public string? Name { get; set; }
        [DisplayName("Описание / комментарий")]
        public string? Description { get; set; }
        [DisplayName("Результат")]
        public double? Value { get; set; } = 0;

        [Timestamp]
        public byte[]? RowVersion { get; set; }

        #region to link person
        public int PersonId { get; set; }
        public virtual Person Person { get; set; } = null!;
        #endregion
    }
}
