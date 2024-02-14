using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace SQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetionString = null;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;

            sql = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", "Proba");

            connetionString = "Server= localhost\\SQLExpress; Database= Proba; Integrated Security=True;";
            con = new SqlConnection(connetionString);
            con.Open();


            //Check if table exsist
            //https://social.msdn.microsoft.com/Forums/sqlserver/en-US/a6d13bf2-f56f-40bd-9210-8a0ed4270a78/using-c-how-do-you-check-if-a-table-exists-in-sql?forum=sqlservermigration
            sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('myTable')";

            cmd = new SqlCommand(sql, con);

            int newProdID = (Int32)cmd.ExecuteScalar();
            if ((Int32)cmd.ExecuteScalar() == 0)
            {
                sql = "CREATE TABLE myTable" + "(myId INTEGER CONSTRAINT PKeyMyId PRIMARY KEY," +
                "myName CHAR(50), myAddress CHAR(255), myBalance FLOAT)";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand("DROP TABLE myTable", con);
                cmd.ExecuteNonQuery();
                sql = "CREATE TABLE myTable" + "(myId INTEGER CONSTRAINT PKeyMyId PRIMARY KEY," +
                 "myName CHAR(50), myAddress CHAR(255), myBalance FLOAT)";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

            try
            {



                // Adding records the table  
                sql = "INSERT INTO myTable(myId, myName, myAddress, myBalance) " +
                "VALUES (1001, 'Puneet Nehra', 'A 449 Sect 19, DELHI', 23.98 ) ";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                sql = "INSERT INTO myTable(myId, myName, myAddress, myBalance) " +
                "VALUES (1002, 'Anoop Singh', 'Lodi Road, DELHI', 353.64) ";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "INSERT INTO myTable(myId, myName, myAddress, myBalance) " +
                "VALUES (1003, 'Rakesh M', 'Nag Chowk, Jabalpur M.P.', 43.43) ";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "INSERT INTO myTable(myId, myName, myAddress, myBalance) " +
                "VALUES (1004, 'Madan Kesh', '4th Street, Lane 3, DELHI', 23.00) ";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();


                //Read data from table
                sql = "Select myId, myName, myAddress, myBalance from myTable";
                cmd = new SqlCommand(sql, con);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader.GetValue(0).ToString());
                    Console.WriteLine(dataReader.GetValue(1).ToString());
                    Console.WriteLine(dataReader.GetValue(2).ToString());
                    Console.WriteLine(dataReader.GetValue(3).ToString());
                    Console.WriteLine("_______________________________");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection ! ");
            }

        }
    }
}