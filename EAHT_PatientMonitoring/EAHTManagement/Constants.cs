using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHTManagement
{
    class Constants
    {
        public static String Insert = "INSERT INTO StaffTable (Name, Surname, Gender, StaffID, StaffPassword, StaffRole, StaffDOB, EmploymentDate, Email, Phone) VALUES (@Name, @Surname, @Gender, @StaffID, @StaffPassword, @StaffRole, @StaffDOB, @EmploymentDate, @Email, @Phone)";

        //public static String Search = "SELECT * FROM StaffTable " //(Name, Surname, Gender, StaffID, StaffPassword, StaffRole, StaffDOB, EmploymentDate, Email, Phone) VALUES (@Name, @Surname, @Gender, @StaffID, @StaffPassword, @StaffRole, @StaffDOB, @EmploymentDate, @Email, @Phone)";
        //public static String Search2 = "select StaffPassword from StaffTable where StaffID = '{StaffID}'";
    }
}
