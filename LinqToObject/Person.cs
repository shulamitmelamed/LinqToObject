using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int ExperienceYear { get; set; }
        public LanguageKnowledge[] languages { get; set; }
        public int[] Mark { get; set; }

        public Person(int id, string firstName, string lastName, string city, int ExperienceYear,
                       LanguageKnowledge[] languages, int[] Mark)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.ExperienceYear = ExperienceYear;
            this.languages = languages;
            this.Mark = Mark;
        }
    }
}
