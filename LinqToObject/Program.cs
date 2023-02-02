// See https://aka.ms/new-console-template for more information
using LinqToObject;

LanguageKnowledge[] languageKnowledge = new LanguageKnowledge[3];
languageKnowledge[0] = new LanguageKnowledge(10, "Hebrew");
languageKnowledge[1] = new LanguageKnowledge(10, "English");
languageKnowledge[2] = new LanguageKnowledge(10, "Spanish");
int[] marks = new int[3] { 10, 98, 99 };
var peopleList = new List<Person>();
var companiesList = new List<Company>();

peopleList.Add(new Person(1, "Shulamit", "Melamed", "BB", 19, languageKnowledge, marks));
peopleList.Add(new Person(2, "Sara", "Melamed", "BB", 15, languageKnowledge, marks));
peopleList.Add(new Person(3, "Rivky", "Ztvebner", "BB", 28, languageKnowledge, marks));
peopleList.Add(new Person(4, "Shevi", "Chazan", "PT", 26, languageKnowledge, marks));
peopleList.Add(new Person(5, "Shoshi", "Melamed", "BB", 9, languageKnowledge, marks));
peopleList.Add(new Person(6, "Chavi", "Melamed", "BB", 9, languageKnowledge, marks));
peopleList.Add(new Person(7, "Chani", "Melamed", "BB", 6, languageKnowledge, marks));


companiesList.Add(new Company(1, "TLV", "Intel", eProffession.DEVELOPING));
companiesList.Add(new Company(2, "TLV", "MicroSoft", eProffession.DEVELOPING));
companiesList.Add(new Company(3, "TLV", "Amazon", eProffession.DEVELOPING));
companiesList.Add(new Company(4, "TLV", "Google", eProffession.DEVELOPING));
Console.WriteLine("---------------------Ex. 1-----------------");
var ex1 = from people in peopleList
          orderby people.LastName, people.FirstName
          select new { people.LastName, people.FirstName, people.City };
foreach (var item in ex1)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("---------------------Ex. 2-----------------");

var ex2 = from people in peopleList
          where people.City == "Y-M" && people.ExperienceYear >= 2
          select new { people.LastName, people.FirstName, people.City, people.ExperienceYear };
foreach (var item in ex2)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("---------------------Ex. 3-----------------");

int count = (from people in peopleList
             where people.City == "Y-M" && people.ExperienceYear >= 2
             select people).Count();
Console.WriteLine(count);
Console.WriteLine();
Console.WriteLine("---------------------Ex. 4-----------------");

var ex4 = from people in peopleList
          let avg = people.Mark.Average()
          where people.City == "Y-M" && avg > 95
          select new { people.LastName, people.FirstName, people.City, people.ExperienceYear };
foreach (var item in ex4)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("---------------------Ex. 5-----------------");
var ex5 = from people in peopleList
          let cnt = people.Mark.Count()
          where (people.Mark.Count() > 0)
          orderby people.Mark.Count() descending
          select new { people.LastName, people.FirstName, cnt };
foreach (var item in ex5)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("---------------------Ex. 6-----------------");

var ex6 = from people in peopleList
          group people by people.City into grouping
          select grouping;

foreach (var item in ex6)
{
    Console.WriteLine(item.Key);
    foreach (var p in item)
        Console.WriteLine(p.FirstName + ' ' + p.LastName);
    Console.WriteLine(item.Count());
}


