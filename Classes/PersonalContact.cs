using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_management_system
{
    public class PersonalContact : Contact // inherit from Contact
    {
        private string contactHomeTel;
        public string ContactHomeTel { get => contactHomeTel; set => contactHomeTel = value; }

        public PersonalContact(string iD1, string contactFName, string contactLName, string contactTel, string contactHomeTel, string contactEmail, string contactAddr1, string contactAddr2, string contactCity, string contactPostcode)
        : base(iD1, contactFName, contactLName, contactTel, contactEmail, contactAddr1, contactAddr2, contactCity, contactPostcode)
        {
            ContactHomeTel = contactHomeTel;
        }
           

    }
}
