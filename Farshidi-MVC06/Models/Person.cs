using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Farshidi_MVC06.Models
{
    public class Person
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string CountryName { get; set; }
        public string Address{ get; set; }

    }
}