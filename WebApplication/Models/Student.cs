using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Student:BaseEntity
    {[StringLength(50)]
    [DisplayName("Öğrenci Adı")]
        public string Name { get; set; }
        [StringLength(50)]
        [DisplayName("Öğrenci Soyadı")]
        public string Surname { get; set; }
        [StringLength(20)]
        [DisplayName("Öğrenci Numarası")]
        public string StudentId { get; set; }
    }
}