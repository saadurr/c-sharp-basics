using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestApiCRUD.Models
{
    public class Employee
    {
        [Key]
        public string ID { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="Longer than allowed limit")]
        public string Name { get; set; }
        public string Designation { get; set; }
    }
}
