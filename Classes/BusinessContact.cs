using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_management_system
{
    class BusinessContact : Contact // inherit from Contact
    {
        private string contactBusinessTel;
        public string ContactBusinessTel { get => contactBusinessTel; set => contactBusinessTel = value; }

        public BusinessContact(string iD1, string contactFName, string contactLName, string contactTel, string contactBusinessTel, string contactEmail, string contactAddr1, string contactAddr2, string contactCity, string contactPostcode)
        : base(iD1, contactFName, contactLName, contactTel, contactEmail, contactAddr1, contactAddr2, contactCity, contactPostcode)
        {
            ContactBusinessTel = contactBusinessTel;
        }
    }
}
