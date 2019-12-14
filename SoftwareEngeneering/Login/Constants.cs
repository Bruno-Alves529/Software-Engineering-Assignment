using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Constants
    {
        public static String Insert = "INSERT INTO StaffTable (Name, Surname, Gender, StaffID, StaffPassword, StaffRole, StaffDOB, StaffPhoto) VALUES (@Name, @Surname, @Gender, @StaffID, @StaffPassword, @StaffRole, @StaffDOB,  @StaffPhoto)";

        public static String InsertPatient = "INSERT INTO PatientTable (PatientID, PatientFullname, PatientDOB, PatientPhoto, PatientGender, PatientCondition, ReadingModule1, ReadingModule2, ReadingModule3, ReadingModule4) VALUES (@PatientID, @PatientFullname, @PatientDOB, @PatientPhoto, @PatientGender, @PatientCondition,  @ReadingModule1, @ReadingModule2, @ReadingModule3, @ReadingModule4)";

        public static String UpdatePatient = "Update  PatientTable SET PatientFullname = @PatientFullname, PatientDOB = @PatientDOB, PatientPhoto = @PatientPhoto, PatientCondition = @PatientCondition, ReadingModule1=@ReadingModule1, ReadingModule2 = @ReadingModule2, ReadingModule3 = @ReadingModule3, ReadingModule4 = @ReadingModule4 WHERE PatientID = @PatientID";

        public static String Delete = "DELETE FROM PatientTable WHERE PatientID = @PatientID";

        public static String InsertAlarmResponseTime = "INSERT INTO AlarmResponseTime (ModuleName, AlarmStartTime, AlarmStopTime, ElapsedTime, Remark) VALUES (@ModuleName,  @AlarmStartTime, @AlarmStopTime, @ElapsedTime, @Remark)";

        public static String InsertShiftLogTimes = "INSERT INTO ShiftLogTable (StaffName, StaffID, LoginStartTime, LoginStopTime, Remark) VALUES (@StaffName, @StaffID, @LoginStartTime, @LoginStopTime, @Remark)";
    }
}
