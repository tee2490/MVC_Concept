using System.ComponentModel.DataAnnotations;

namespace MVC_Concept.Models
{
    public class Product
    {
        [Display(Name="รหัส")]
        [Required(ErrorMessage ="กรุณากรอกข้อมูล")]
        public int Id { get; set; }

        [Display(Name = "ชื่อ")]
        [Required(ErrorMessage = "กรุณากรอกข้อมูล")]
        public string Name { get; set; }

        [Display(Name = "ราคา")]
        [Required(ErrorMessage = "กรุณากรอกข้อมูล")]
        public double Price { get; set; }

        [Display(Name = "จำนวน")]
        [Range(1,100,ErrorMessage ="อย่างน้อย {1} ไม่เกิน {2}")]
        public int Amount { get; set; }
    }
}
