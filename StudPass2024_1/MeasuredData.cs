using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudPass2024_1
{
    public class MeasuredData
    {

        public int Id { get; set; }

        [DisplayName("Дата измерения")]
        public DateTime DateOfMeasurement { get; set; } = DateTime.Today;
        [DisplayName("Пульс, уд/мин")]
        public int? BPM { get; set; } = 80;
        [DisplayName("Давление нижнее, мм рт ст")]
        public int? SisPressure { get; set; } = 80;
        [DisplayName("Давление верхнее, мм рт ст")]
        public int? DiasPressure { get; set; } = 120;
        [DisplayName("Сатурация, %")]
        public double? Saturation { get; set; } = 6.2;
        [DisplayName("Концентрация глюкозы")]
        public double? Glucose { get; set; } = 6.2;
        [DisplayName("Характер ЭКГ")]
        public string? ECG { get; set; } = "без отклонений";

        [DisplayName("Острота зрения (левый глаз)")]
        public double? LeftEye { get; set; } = 1;

        [DisplayName("Астигматизм (левый глаз)")]
        public double? LeftAsph { get; set; } = 0;
        [DisplayName("Острота зрения (правый глаз)")]
        public double? RightEye { get; set; } = 1;

        [DisplayName("Астигматизм (правый глаз)")]
        public double? RightAsph { get; set; } = 0;

        // Глубина дыхания
        // Respiratory volume(DV), or depth of breathing, the volume of air inhaled and exhaled at rest(normally 300-900 ml).
        [DisplayName("Глубина дыхания, мл")]
        public int? Depth_breathing_vol { get; set; } = 600;
        // Reserve exhalation volume(ROS) - the maximum volume of air that can be exhaled additionally after a quiet exhalation(normal 1000-1500 ml). 
        [DisplayName("Резервный объем выдоха")]
        public int? Reserve_exhalation_vol { get; set; } = 1200;
        //Reserve inspiratory volume(ROS) - the maximum volume of air that can be inhaled additionally after a restful exhalation(normal 1000-2500 ml). 
        [DisplayName("Резервный объем вдоха")]
        public int? Reserve_inspiratory_vol { get; set; } = 1200;
        //Residual volume(RV) - the volume of air remaining in the lungs after maximum exhalation(500-1000 ml is normal). 
        [DisplayName("Остаточный объем")]
        public int? Residual_vol { get; set; } = 700;
        [DisplayName("ЖЕЛ расчетная")]
        [NotMapped()]
        public int VitalCapacityCalc
        {
            get
            {
                try
                {
                    return (int)(Depth_breathing_vol + Reserve_exhalation_vol + Reserve_inspiratory_vol);
                } 
                catch { return 0; }
                }
        }
        [DisplayName("ЖЕЛ измеренная")]
        public int? VitalCapacity { get; set; }


        [DisplayName("Биоимпеданс")]
        public double? BIA { get; set; } = 0;

        [Timestamp]
        public byte[]? RowVersion { get; set; }

        #region to link person
        public int PersonId { get; set; }
        public virtual Person Person { get; set; } = null!;
        #endregion
    }
}
