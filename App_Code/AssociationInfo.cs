using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AssociationInfo
/// </summary>
public struct AssociationInfo
{

    public decimal Association_ID, Shift_Time, Student_ID;
    public string First_Name, Last_Name, Class_ID;
        public AssociationInfo(decimal assID , Decimal stu_ID, string f_Name, string l_Name,string clas_ID, decimal shif_Tim)
        {
        Association_ID = assID;
        Student_ID = stu_ID;
        First_Name = f_Name;
        Last_Name = l_Name;
        Class_ID = clas_ID;
        Shift_Time = shif_Tim;


        }
}