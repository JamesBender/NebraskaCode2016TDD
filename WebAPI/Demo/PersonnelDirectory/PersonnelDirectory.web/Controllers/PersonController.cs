using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using PersonnelDirectory.Web.Models;
using PersonnelDirectory.Web.Models.ViewModels;

namespace PersonnelDirectory.web.Controllers
{
    public class PersonController : ApiController
    {
        private PersonnelModel _personModel;

        public PersonController()
        {
            AutomapperConfiguration.Configure();
            _personModel = new PersonnelModel();
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _personModel.GetAllPersonnel();
        }

        public Person GetASinglePerson(int id)
        {
            return _personModel.GetPerson(id);
        }

        public int PostANewPerson(Person person)
        {
            return _personModel.SavePerson(person);
        }
    }
}