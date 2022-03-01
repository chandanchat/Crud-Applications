﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Applications.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string name {get;set;}
        public int age { get; set; }
    }
}
