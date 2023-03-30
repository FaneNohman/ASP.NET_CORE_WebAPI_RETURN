using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public readonly static List<Person> people =
            new List<Person> {
                new Person { Id = 1, FirstName = "Jhon", LastName = "Smith", Region= "NY", BirthDate= "1995/04/23", WorkPlace= "Google NY", Position= "Software Developer" },
                new Person { Id = 2, FirstName = "Almat", LastName = "Rakhym", Region= "ALA", BirthDate= "1992/12/03", WorkPlace= "Prime Source", Position= "Software Tester" },
                new Person { Id = 3, FirstName = "Aleksandr", LastName = "Smirnov", Region= "AST", BirthDate= "1996/10/20", WorkPlace= "Epam KZ", Position= "Back-end Developer" },
                new Person { Id = 4, FirstName = "Paul", LastName = "Walker", Region= "FRN", BirthDate= "1999/02/12", WorkPlace= "Amazon", Position= "Full-Stack Developer" },
                new Person { Id = 5, FirstName = "Dos", LastName = "Qairat", Region= "UKA", BirthDate= "1997/01/14", WorkPlace= "Booking", Position= "Front-End Developer" }
            };

        [HttpGet(Name = "GetPeople")]
        public IEnumerable<Person> Get()
        {
            return people
            .ToArray();
        }
    }
}
