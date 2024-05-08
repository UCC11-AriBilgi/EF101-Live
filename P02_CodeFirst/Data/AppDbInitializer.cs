using P02_CodeFirst.Entities;

namespace P02_CodeFirst.Data
{
    public class AppDbInitializer
    {
        // Bu class veri üretecek ve VT tarafına gönderecek

        public static void SeedData(IApplicationBuilder applicatinBuilder)
        {
            using( var serviceScope=applicatinBuilder.ApplicationServices.CreateScope()) // Kapsam belirleniyor...
            {
                var context=serviceScope.ServiceProvider.GetService<StudentDbContext>();

                // Önceki durumlarda VT nını boş da olsa yaratmıştık.

                context.Database.EnsureCreated(); // VT var mı yok mu

                // Şimdi VT içinde belirlemiş olduğum tabloların içinde veri var mı/yok mu kontrolü

                // VT tarafındaki SClasses tablosu için
                if (!context.SClasses.Any())  
                {
                    // eğer herhangi bir kayıt yoksa buraya girmesini sağlamak için !(not/değil) operatörünü bu yüzden kullandık

                    context.SClasses.AddRange(new List<SClass>()
                    {
                        new SClass()
                        {
                            SClassName="Class 1",
                            SClassDescription="Class 1 ile ilgili bilgi"
                        },
                        new SClass()
                        {

                            SClassName="Class 2",
                            SClassDescription="Class 2 ile ilgili bilgi"
                        },
                        new SClass()
                        {

                            SClassName="Class 3",
                            SClassDescription="Class 3 ile ilgili bilgi"
                        }
                    });

                    context.SaveChanges(); // Oluşan listeyi VT deki ilgili tabloya gönderecek.

                }

                // VT tarafındaki Students tablosu için
                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()
                    {
                        new Student()
                        {
                            SFName="First Name 1",
                            SLName="Last Name 1",
                            SDoB=DateTime.Now.AddDays(-2689),
                            SClassId=1
                        },
                        new Student()
                        {
                            SFName="First Name 2",
                            SLName="Last Name 2",
                            SDoB=DateTime.Now.AddDays(-2512),
                            SClassId=1
                        },
                        new Student()
                        {
                            SFName="First Name 3",
                            SLName="Last Name 3",
                            SDoB=DateTime.Now.AddDays(-2700),
                            SClassId=2
                        },
                        new Student()
                        {
                            SFName="First Name 4",
                            SLName="Last Name 4",
                            SDoB=DateTime.Now.AddDays(-2800),
                            SClassId=3
                        },
                        new Student()
                        {
                            SFName="First Name 5",
                            SLName="Last Name 5",
                            SDoB=DateTime.Now.AddDays(-2689),
                            SClassId=2
                        }
                    });

                    context.SaveChanges();

                }
            }
        }

    }
}
