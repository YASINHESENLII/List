using System.Collections.Immutable;
using System.Globalization;
using System.Text.Encodings.Web;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Programinglanguage> languages = new List<Programinglanguage>();
            languages.Add(new Programinglanguage { Name = "C#", Year = 2001 });
            languages.Add(new Programinglanguage { Name = "C++", Year = 1983 });
            languages.Add(new Programinglanguage { Name = "Java", Year = 1995 });
            languages.Add(new Programinglanguage { Name = "Javascript", Year = 1996 });
            languages.Add(new Programinglanguage { Name = "C", Year = 1972 });


            languages.Sort((a, b) => a.Year.CompareTo(b.Year));

            foreach (var item in languages)
            {
                Console.WriteLine(item.Name + " " + item.Year);
            }
        }
    }
}