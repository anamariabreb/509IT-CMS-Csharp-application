using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace contact_management_system.dbConn
{
    class businessDbConn : dbConn //inheritance from parent dbConn
    {
        //Add Contact including Business Telephone
        public void insertContact
            (
                BusinessContact busCon
            )
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `BusinessContact` " +
                "(`ID`, `ContactFName`, `ContactLName`, `ContactTel`, `ContactBusinessTel`, `ContactEmail`, `ContactAddr1`, `ContactAddr2`, `ContactCity`, `ContactPostcode`) " +
                "VALUES " +
                "(NULL,@ContactFName, @ContactLName, @ContactTel, @ContactBusinessTel, @ContactEmail, @ContactAddr1, @ContactAddr2, @ContactCity, @ContactPostcode);";
            comm.Parameters.AddWithValue("@ContactFName", busCon.ContactFName);
            comm.Parameters.AddWithValue("@ContactLName", busCon.ContactLName);
            comm.Parameters.AddWithValue("@ContactTel", busCon.ContactTel);
            comm.Parameters.AddWithValue("@ContactBusinessTel", busCon.ContactBusinessTel);
            comm.Parameters.AddWithValue("@ContactEmail", busCon.ContactEmail);
            comm.Parameters.AddWithValue("@ContactAddr1", busCon.ContactAddr1);
            comm.Parameters.AddWithValue("@ContactAddr2", busCon.ContactAddr2);
            comm.Parameters.AddWithValue("@ContactCity", busCon.ContactCity);
            comm.Parameters.AddWithValue("@ContactPostcode", busCon.ContactPostcode);
            comm.ExecuteNonQuery();
            connClose();
        }

        // Update Contact
        public void updateContact
            (
                BusinessContact busCon
            )
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `BusinessContact` " +
                "SET ContactFName=@ContactFName, ContactLName=@ContactLName, ContactTel=@ContactTel,  ContactBusinessTel=@ContactBusinessTel, ContactEmail=@ContactEmail, " +
                "ContactAddr1=@ContactAddr1, ContactAddr2=@ContactAddr2, ContactCity=@ContactCity, ContactPostcode=@ContactPostcode " +
                " WHERE ID=@ID;";
            comm.Parameters.AddWithValue("@ContactFName", busCon.ContactFName);
            comm.Parameters.AddWithValue("@ContactLName", busCon.ContactLName);
            comm.Parameters.AddWithValue("@ContactTel", busCon.ContactTel);
            comm.Parameters.AddWithValue("@ContactBusinessTel", busCon.ContactBusinessTel);
            comm.Parameters.AddWithValue("@ContactEmail", busCon.ContactEmail);
            comm.Parameters.AddWithValue("@ContactAddr1", busCon.ContactAddr1);
            comm.Parameters.AddWithValue("@ContactAddr2", busCon.ContactAddr2);
            comm.Parameters.AddWithValue("@ContactCity", busCon.ContactCity);
            comm.Parameters.AddWithValue("@ContactPostcode", busCon.ContactPostcode);
            comm.Parameters.AddWithValue("@ID", busCon.ID1);
            comm.ExecuteNonQuery();
            connClose();
        }

        // Delete Contact
        public void deleteContact(string ID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `BusinessContact` WHERE ID = @ID";
            comm.Parameters.AddWithValue("@ID", ID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
