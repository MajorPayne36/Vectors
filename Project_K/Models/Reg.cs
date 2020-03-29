using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_K.Models
{
    public class Reg
    {
        public int Id_student { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Patronymic { get; set; }

        public string Sex { get; set; }

        public DateTime Date_of_birth { get; set; }

        public string City { get; set; }

        public string School { get; set; }

        public string Login_ { get; set; }

        public string Password_ { get; set; }
    }
}