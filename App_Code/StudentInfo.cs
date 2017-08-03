using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// sql code 
///
///   Student_ID decimal(4,0) primary key, First_Name varchar(20) not null, Last_Name varchar(20) not null, 
///-- Phone_number decimal(10,0) not null, Email varchar(40) not null, GPA decimal (3,2));
/// </summary>
public struct StudentInfo
{
    public decimal Student_ID, Phone_Number, GPA;
    public string First_Name, Last_Name, Email;
    public StudentInfo(decimal stuID, string fname, string lname, decimal pnumber, string email, decimal gpa)
    {
        Student_ID = stuID;
        First_Name = fname;
        Last_Name = lname;
        Phone_Number = pnumber;
        Email = email;
        GPA = gpa;
    }
}