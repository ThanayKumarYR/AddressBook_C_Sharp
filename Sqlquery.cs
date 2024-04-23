using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Sqlquery
    {
        public static void Create(SqlConnection connection)
        {
            string creatTableQuery = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Contacts')BEGIN Create table Contacts(contactId int primary key identity(1,1),firstName varchar(20),lastName varchar(20),email varchar(50),phonenumber char(13),address varchar(100),City varchar(20),State varchar(20),zipcode char(6));END;";
            SqlCommand command = new SqlCommand(creatTableQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("Successfully created the table");
            command.Dispose();
            connection.Close();
        }

        public static void Insert(SqlConnection connection,Contacts contacts)
        {
            string insertTableQuery = $@"insert into Contacts (firstName,lastName,email,phonenumber,address,City,State,zipcode) values('{contacts.FirstName}','{contacts.LastName}','{contacts.Email}','{contacts.PhoneNumber}','{contacts.Address}','{contacts.City}','{contacts.State}','{contacts.ZipCode}');";
            SqlCommand command = new SqlCommand(insertTableQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("Successfully inserted into the table");
            command.Dispose();
            connection.Close();
        }

        public static void Update(SqlConnection connection,string column,string value,string firstName,string lastName)
        {
            string displayTableQuery = $@"update Contacts set {column} = '{value}' where firstName = {firstName} and lastName = {lastName}";
            SqlCommand command = new SqlCommand(displayTableQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("Successfully update the table");
            command.Dispose();
            connection.Close();
        }

        public static void Delete(SqlConnection connection,string firstName,string lastName)
        {
            string displayTableQuery = $@"delete Contacts where firstName = {firstName} and lastName = {lastName}";
            SqlCommand command = new SqlCommand(displayTableQuery,connection);
            connection.Open();
            command.ExecuteNonQuery();
            Console.WriteLine("Successfully delete the table");
            command.Dispose();
            connection.Close();
        }

        public static void Display(SqlConnection connection)
        {
            string displayTableQuery = @"select * from Contacts";
            SqlCommand command = new SqlCommand(displayTableQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            { 
                Console.WriteLine($" Id : {reader["contactId"]}, firstName :{reader["firstName"]}, lastName :{reader["lastName"]}, email :{reader["email"]}, phonenumber : {reader["phonenumber"]}, City : {reader["City"]}, State: {reader["State"]}, zipcode : {reader["zipcode"]}");
            }
            Console.WriteLine("Successfully display the table");
            reader.Close();
            command.Dispose();
            connection.Close();
        }

        public static void InitailizeList(List<Contacts> list,SqlConnection connection)
        {
            string displayTableQuery = @"select * from Contacts";
            SqlCommand command = new SqlCommand(displayTableQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int Id = Convert.ToInt32(reader["ID"]);
                string firstname = Convert.ToString(reader["firstName"]);
                string lastname = Convert.ToString(reader["lastName"]);
                string email = Convert.ToString(reader["email"]);
                string phonenumber = Convert.ToString(reader["phonenumber"]);
                string address = Convert.ToString(reader["address"]);
                string city = Convert.ToString(reader["city"]);
                string state = Convert.ToString(reader["state"]);
                string zipcode = Convert.ToString(reader["zipcode"]);
                Contacts contacts = new Contacts(Id,firstname,lastname,email,phonenumber,address,city,state,zipcode);
                list.Add(contacts);
            }
            Console.WriteLine("Successfully initialized the list");
            reader.Close();
            command.Dispose();
            connection.Close();
        }

    }
}
