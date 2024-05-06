using Microsoft.EntityFrameworkCore;
using P02_CodeFirst.Entities;

namespace P02_CodeFirst.Data
{
    public class StudentDbContext : DbContext
    {
        // Burası özel bir sınıf.VTnin yapısını içinde belirtebileceğim bir sınıf. Ve bunun için DbContext isimli sınıftan (EF e dahil) kalıtılması gerekiyor.

        // Constructor
        public StudentDbContext(DbContextOptions options) : base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // tüm context ile ilgili gereken konfigürasyon işlemleri için kullanılan bölüm
            optionsBuilder.UseSqlServer(); // SqlServer kullanacağımı belirtiyorum
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // burası modellerimiz yaratılırken eğer yapılacak bazı özel işlemler varsa kullanılır.
        }

        // Yaratılmış olan Entity/Modellerimizi VT tarafında oluşacak olan tablolar gibi tanımlıyoruz.
        // Sınıflarımızı birer DbSet olarak tanımlıyoruz. DbSet <--> tablo(db tarafındaki)

        public DbSet<Student> Students { get; set; }
        public DbSet<SClass> SClasses { get; set; }
        public DbSet<Person> Persons { get; set; }

    }
}
