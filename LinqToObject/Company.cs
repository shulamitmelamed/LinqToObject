using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    public enum eProffession
    {
        DEVELOPING, QA
    }
    public class Company
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public eProffession proffession { get; set; }

        public Company(int id, string city, string name, eProffession proffession)
        {
            this.Id = id;
            this.City = city;
            this.Name = name;
            this.proffession = proffession;
        }
    }
}
