using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace contact_management_system.dbConn
{
    public class personalDbConn : dbConn //inheritance from parent dbConn
    {
        //Add Contact including Home Telephone
        public void insertContact
            (
                PersonalContact persCon
            )
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `PersonalContact` " +
                "(`ID`, `contactFName`, `contactLName`, `contactTel`, `contactHomeTel`, `contactEmail`, `contactAddr1`, `contactAddr2`, `ContactCity`, `contactPostcode`) " +
                "VALUES " +
                "(NULL,@contactFName, @contactLName, @contactTel, @contactHomeTel, @contactEmail, @contactAddr1, @contactAddr2, @contactCity, @contactPostcode);";
            comm.Parameters.AddWithValue("@contactFName", persCon.ContactFName);
            comm.Parameters.AddWithValue("@contactLName", persCon.ContactLName);
            comm.Parameters.AddWithValue("@contactTel", persCon.ContactTel);
            comm.Parameters.AddWithValue("@contactHomeTel", persCon.ContactHomeTel);
            comm.Parameters.AddWithValue("@contactEmail", persCon.ContactEmail);
            comm.Parameters.AddWithValue("@contactAddr1", persCon.ContactAddr1);
            comm.Parameters.AddWithValue("@contactAddr2", persCon.ContactAddr2);
            comm.Parameters.AddWithValue("@contactCity", persCon.ContactCity);
            comm.Parameters.AddWithValue("@contactPostcode", persCon.ContactPostcode);
            comm.ExecuteNonQuery();
            connClose();
        }

        // Update Contact
        public void updateContact
            (
            PersonalContact persCon
            )
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `PersonalContact` " +
                "SET contactFName=@contactFName, contactLName=@contactLName, contactTel=@contactTel, contactHomeTel=@contactHomeTel, contactEmail=@contactEmail, " +
                "contactAddr1=@contactAddr1, contactAddr2=@contactAddr2, contactCity=@contactCity, contactPostcode=@contactPostcode " +
                "WHERE ID=@ID;";
            comm.Parameters.AddWithValue("@contactFName", persCon.ContactFName);
            comm.Parameters.AddWithValue("@contactLName", persCon.ContactLName);
            comm.Parameters.AddWithValue("@contactTel", persCon.ContactTel);
            comm.Parameters.AddWithValue("@contactHomeTel", persCon.ContactHomeTel);
            comm.Parameters.AddWithValue("@contactEmail", persCon.ContactEmail);
            comm.Parameters.AddWithValue("@contactAddr1", persCon.ContactAddr1);
            comm.Parameters.AddWithValue("@contactAddr2", persCon.ContactAddr2);
            comm.Parameters.AddWithValue("@contactCity", persCon.ContactCity);
            comm.Parameters.AddWithValue("@contactPostcode", persCon.ContactPostcode);
            comm.Parameters.AddWithValue("@ID", persCon.ID1);
            comm.ExecuteNonQuery();
            connClose();
        }

        // Delete Contact
        public void deleteContact(string ID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `PersonalContact` WHERE ID = @ID";
            comm.Parameters.AddWithValue("@ID", ID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
