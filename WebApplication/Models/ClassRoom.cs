﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ClassRoom:BaseEntity
    {
        public int? StudentId { get; set; }
       
        [DisplayName("Öğrenci")]
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        public int? TeacherId { get; set; }
        [DisplayName("Öğrenci")]
        [ForeignKey("StudentId")]
        public Teacher Teacher { get; set; }
        public string ClassroomName { get; set; }
    }
}