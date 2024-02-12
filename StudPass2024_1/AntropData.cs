using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudPass2024_1
{
    public class AntropData
    {
        
        public int Id { get; set; }

        [DisplayName("Дата измерения")]
        public DateTime DateOfMeasurement { get; set; } = DateTime.Today;

        [Range(0, 2500)]
        [DisplayName("Рост см")]
        public int? Height_cm { get; set; } = 175;
        [DisplayName("Вес, кг")]
        public double? Weight_kg { get; set; } = 75.4;
        [DisplayName("Индекс массы тела")]
        [NotMapped]
        public double? BMI
        {
            get
            {
                Height_cm ??= 0;
                if(Height_cm==0) return 0;
                return Weight_kg / (double)( Height_cm*Height_cm)*10000f;
            }
        }
        [DisplayName("Охват головы, см")]
        public int? Head_circ { get; set; }
        [DisplayName("Длина ноги, см")]
        public int? Legs_len { get; set; }
        [DisplayName("Длина руки, см")]
        public int? Hands_len { get; set; }
        [DisplayName("Длина туловища, см")]
        public int? Torso_len { get; set; }
        [DisplayName("Охват живота, см")]
        public int? Abdominal_circ { get; set; }
        [DisplayName("Охват талии, см")]
        public int? Waist_circ { get; set; }
        [DisplayName("Охват бедер, см")]
        public int? Hips_circ { get; set; }
        [DisplayName("Охват груди, см")]
        public int? Chest_circ { get; set; }
        [DisplayName("Охват шеи, см")]
        public int? Neck_circ { get; set; }
        [DisplayName("Охват бицепса, см")]
        public int? Biceps { get; set; }
        [DisplayName("Охват трицепса, см")]
        public int? Triceps { get; set; }
        [DisplayName("Охват бедер, см")]
        public int? Thigh_circ { get; set; }
        [DisplayName("Охват икры, см")]
        public int? Calf_circ { get; set; }
        /*
        // Respiratory volume(DV), or depth of breathing, the volume of air inhaled and exhaled at rest(normally 300-900 ml). 
        public int Depth_breathing_vol { get; set; }
        // Reserve exhalation volume(ROS) - the maximum volume of air that can be exhaled additionally after a quiet exhalation(normal 1000-1500 ml). 
        public int Reserve_exhalation_vol { get; set; }
        //Reserve inspiratory volume(ROS) - the maximum volume of air that can be inhaled additionally after a restful exhalation(normal 1000-2500 ml). 
        public int Reserve_inspiratory_vol { get; set; }
        //Residual volume(RV) - the volume of air remaining in the lungs after maximum exhalation(500-1000 ml is normal). 
        public int Residual_vol { get; set; }
        */
        

        [Timestamp]
        public byte[]? RowVersion { get; set; }

        #region to link person
        public int PersonId { get; set; }
        public virtual Person Person { get; set; } = null!;
        #endregion
    }
}
