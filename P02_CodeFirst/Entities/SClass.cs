﻿using System.ComponentModel.DataAnnotations.Schema;

namespace P02_CodeFirst.Entities
{
    public class SClass
    {
        public int SClassId { get; set; }

        public string SClassName { get; set; }

        public string SClassDescription { get; set; }

        // Relation Definitions
        public ICollection<Student> Students { get; set; }


    }
}
