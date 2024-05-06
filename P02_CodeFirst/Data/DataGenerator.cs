using Bogus;
using P02_CodeFirst.Entities;
using Person = P02_CodeFirst.Entities.Person;

namespace P02_CodeFirst.Data
{
    public class DataGenerator
    {
        // Burası Person classıma bağlı olarak fake/dummy veri üretecek ve bunu Bogus kütüphanesi yardımıyla gerçekleştirecek bölüm

        Faker<Person> fakerPerson;

        // Constructor
        public DataGenerator()
        {
                //fakerPerson = new Faker<Person>();
        }

        public List<Person> GeneratePerson(int count)
        {
            var personList= new List<Person>();

            //for (int i = 1; i <= count ; i++)
            //{
            //    fakerPerson = new Faker<Person>()
            //        .RuleFor(p=>p.PersonId,fd=>fd.Random.Int(1,200))
            //        .RuleFor(p=>p.PFName, fd=> fd.Name.FirstName())
            //        .RuleFor(p=>p.PLName, fd=> fd.Name.LastName())
            //}




            return new List<Person>();
        }


    }
}
