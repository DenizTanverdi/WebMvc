using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Teacher:BaseEntity
    {
        [StringLength(50)]
        [DisplayName("Eğitmen Adı")]
        public string Name { get; set; }
        [StringLength(50)]
        [DisplayName("Eğitmen Soyadı")]
        public string Surname { get; set; }
        [StringLength(20)]
        [DisplayName("Eğitmen Branşı")]
        public string Brans { get; set; }
        public virtual  ICollection<ClassRoom> Classrooms { get; set; }
    }
}