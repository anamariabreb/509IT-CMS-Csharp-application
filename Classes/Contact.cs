using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_management_system
{
    public class Contact
    {
        private string ID;
        private string contactFName;
        private string contactLName;
        private string contactTel;
        private string contactEmail;
        private string contactAddr1;
        private string contactAddr2;
        private string contactCity;
        private string contactPostcode;

        public Contact(string iD1, string contactFName, string contactLName, string contactTel, string contactEmail, string contactAddr1, string contactAddr2, string contactCity, string contactPostcode)
        {
            ID1 = iD1;
            ContactFName = contactFName;
            ContactLName = contactLName;
            ContactTel = contactTel;
            ContactEmail = contactEmail;
            ContactAddr1 = contactAddr1;
            ContactAddr2 = contactAddr2;
            ContactCity = contactCity;
            ContactPostcode = contactPostcode;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string ContactFName { get => contactFName; set => contactFName = value; }
        public string ContactLName { get => contactLName; set => contactLName = value; }
        public string ContactTel { get => contactTel; set => contactTel = value; }
        public string ContactEmail { get => contactEmail; set => contactEmail = value; }
        public string ContactAddr1 { get => contactAddr1; set => contactAddr1 = value; }
        public string ContactAddr2 { get => contactAddr2; set => contactAddr2 = value; }
        public string ContactCity { get => contactCity; set => contactCity = value; }
        public string ContactPostcode { get => contactPostcode; set => contactPostcode = value; }

    }
}
