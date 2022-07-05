using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


// db => ujstafflab3
// table name => ujstaffportal

namespace DataLayer {
    public class Data {
      // configuration string
      static string config = "username=root;password=;database=ujstafflab3;datasource=127.0.0.1;port=3306";
      // create a mysql connection object
      static MySqlConnection connectObj = new MySqlConnection( config ) ;

      // to add uj staff to db
      static public int AddStaff( string name, string lastname, string email, string id, string age) {

        string query = $"insert into `ujstaffportal`(`firstname`,`lastname`,`email`,`idNo`,`age`) values('{name}','{lastname}','{email}','{id}','{age}')"; // query string, using string interpolation
        try {
          MySqlCommand commandObj = new MySqlCommand(query, connectObj);
          connectObj.Open(); // open mysql connection 
          MySqlDataReader readObj = commandObj.ExecuteReader(); // execute the query
          readObj.Close(); // close the reader object
          connectObj.Close(); // close mysql connection
        } // when something is not right
        catch (Exception ex) { Console.WriteLine(ex.Message); }

        return 0; // return 0
      }


      // read all staffs from the dbs
      static public ArrayList GetStaff() {
        string query = "select * from ujstaffportal"; // query string to query db
        string staff; // keep each row
        ArrayList staffs = new ArrayList();
        try {
          // create a mysql command object
          MySqlCommand commandObj = new MySqlCommand(query, connectObj);
          connectObj.Open(); // open mysql connection
          MySqlDataReader readObj = commandObj.ExecuteReader(); // run the query..
          commandObj.CommandTimeout = 60; // added cause, its failing to read data..
          // loop via all rows and extracts the data
          while (readObj.Read()) {
            staff = $"{readObj.GetValue(1)} | {readObj.GetValue(2)} | {readObj.GetValue(3)} | {readObj.GetValue(5)}";
            staffs.Add(staff); // add a staff data to list of all data..
          }
          readObj.Close(); // close the reader object
          connectObj.Close(); // close the connection object
        } // throws an exception error, when something goes wrong and display it..
        catch (Exception ex) { Console.WriteLine(ex.Message); }

        return staffs; // return  array list... data ,
      }



  }
}
