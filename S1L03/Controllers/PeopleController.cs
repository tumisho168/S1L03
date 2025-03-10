using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;

namespace S1L03.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People

        public ActionResult ListPeople()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel {StudentNumber = "u24885062", FirstName = "Tumisho", LastName = "Matlala", StudentEmail = "tumisho.matlala@tuks.co.za" ,MyLink= "~/Models/HTML/Student1.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u22746995", FirstName = "Kgalalelo", LastName = "Lethoko", StudentEmail = "kgalalelo.lethoko@tuks.co.za", MyLink = "~/Models/HTML/Student2.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u20731028", FirstName = "Nomvuyo", LastName = "Mthimkhulu", StudentEmail = "nomvuyo.mthimkhulu@tuks.co.za", MyLink = "~/Models/HTML/Student3.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u24753328", FirstName = "Bulelo", LastName = "Sibisi", StudentEmail = "bulelo.sibisi@tuks.co.za", MyLink = "~/Models/HTML/Student4.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u24986242", FirstName = "Palesa", LastName = "Mphephu", StudentEmail = "palesa.mphephu@tuks.co.za", MyLink = "~/Models/HTML/Student5.html" });

return View(people);

        }
 
    }
}