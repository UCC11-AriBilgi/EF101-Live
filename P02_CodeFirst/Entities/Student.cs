using System.ComponentModel.DataAnnotations.Schema;

namespace P02_CodeFirst.Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        // Data Annotations
        [Column(TypeName ="NVarchar(20)")] // boyut belirleme
        public string SFName { get; set; }

        [Column(TypeName = "NVarchar(30)")]
        public string SLName { get; set; }

        public DateTime SDoB { get; set; } // date of birth

        // Relations
        public virtual SClass SClass { get; set; } // Öğrencinin bulunduğu sınıf


    }
}
