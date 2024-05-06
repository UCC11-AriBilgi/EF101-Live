namespace P02_CodeFirst.Entities
{
    public class Person
    {
        public int PersonId { get; set; }

        public string PFName { get; set; }

        public string PLName { get; set; }

        public string PEMail { get; set; }

        public string PPhone { get; set; }

        public string PAddress { get; set; }

        public string PPostCode { get; set; }

        public string PCity { get; set; }
        
        // Gender ile ilgili bir alan da olacak. Bu herbir kayıt için farklı değerlere sahip olabileği için bu tamaman ayrı bir sınıfta bildirmekte yarar var.

        public GenderEnum PGender { get; set; } // enum burayı besleyecek-burası enum yapısına bakacak..
    }
}
