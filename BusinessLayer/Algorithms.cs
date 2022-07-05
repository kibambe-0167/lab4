using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer {
    public class Algorithms {

      // public properte
      static public string StaffName { get; set; }
      static public string StaffLastname { get; set; }
      static public string StaffEmail{ get; set; }
      static public string StaffId { get; set; }
      static public string StaffAge { get; set; }


      // receives users id and returns a users age
      static public string getAge()
      {
        string id = StaffId; // user id
        string bornYear; // to store user year born
        int year = int.Parse(id.Substring(0, 2)); // get user year born

        // make user 4 digit year born// if user is born between **00 and **09
        if (year >= 0 && year <= 9) bornYear = year < 22 ? $"200{year}" : $"19{year}";
        else bornYear = year < 22 ? $"20{year}" : $"19{year}";

        DateTime date = DateTime.Now; // define datetime object

        int age = date.Year - int.Parse(bornYear); // get age, by substraction.
        // Console.WriteLine(age + " " + bornYear);
        StaffAge = age.ToString(); // assign age to user.

        return age.ToString(); // return age for method that might use it.
      }

      // create staff email
      static public string makeStaffEmail() {
        StaffEmail = $"{StaffName.Substring(0, 1)}{StaffLastname}@uj.ac.za";
        return StaffEmail;
      }

      // access add staff method from the data layer
      static public void AddStaff() {
        DataLayer.Data.AddStaff(StaffName, StaffLastname, StaffEmail, StaffId, StaffAge);
      }
      

      // access read data method from data layer
      static public ArrayList GetStaff() { return DataLayer.Data.GetStaff(); }
  }
}
