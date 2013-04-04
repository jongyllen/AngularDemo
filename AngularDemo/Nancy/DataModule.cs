using System.Collections.Generic;
using System.Linq;
using Nancy;

namespace AngularDemo.Nancy
{
    public class DataModule : NancyModule
    {
        public DataModule() : base("data")
        {
            Get["/"] = request => "Hello World";
            Get["/list"] = request => Response.AsJson(new List<string>{"1", "2", "3"});
            Get["/people"] = request => Response.AsJson(GetPeople());
            Get["/person/{id}"] = request => MakeJsonResponse(GetPerson(request.id));
        }

        private Person GetPerson(int id)
        {
            return GetPeople().FirstOrDefault(x => x.id == id);
        }

        private List<Person> GetPeople()
        {
            var people = new List<Person>
                {
                    new Person(1, "Adam"),
                    new Person(2, "Bertil"),
                    new Person(3, "Cissi"),
                    new Person(4, "Diana"),
                    new Person(5, "Someone_with_an_awful_long_name")
                };

            return people;
        }

        private Response MakeJsonResponse(object res)
        {
            Response resp;
            if (res == null)
            {
                resp = "Not Found";
                resp.StatusCode = HttpStatusCode.NotFound;
            }
            else
            {
                resp = Response.AsJson(res);
                resp.ContentType = "text/html; charset=utf-8";
            }
            return resp;
        }
    }

   

    public class Person
    {
        public string name { get; set; }
        public int id { get; set; }

        public Person(int id, string name)
        {
            this.name = name;
            this.id = id;
        }
    }
}