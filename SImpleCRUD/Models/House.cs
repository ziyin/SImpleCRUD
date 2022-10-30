using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SImpleCRUD.Models
{
    public class House
    {
        public int ID { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public string Owner { get; set; }
        
        [Required]
        [RegularExpression(@"^\d+(.\d+)?$")]
        [Range(0.1, 200)]
        public double Size { get; set; }

        [Required]
        [Range(1, 10)]
        public int RoomNum { get; set; }

        [Required]
        [Range(1, 10)]
        public int HallNum { get; set; }

        [Required]
        [Range(1, 10)]
        public int BathNum { get; set; }

        [Required]
        [Range(0, 200)]
        [RegularExpression(@"^\d+(.\d+)?$")]
        public double year { get; set; }

        [Required]
        public string type { get; set; }

        [Required]
        [Range(1, 50)]
        public int floor { get; set; }

        [Required]
        [RegularExpression(@"^\d+(.\d+)?$")]
        [Range(0.1, 9999999)]
        public int price { get; set; }
        public string remark { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
