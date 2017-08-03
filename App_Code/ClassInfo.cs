using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClassInfo
/// </summary>
public struct ClassInfo
{
    public string Class_ID;
    public decimal Number_Credits, instructor_ID, shift_time;
    public ClassInfo(string c_ID, decimal num_Credit, decimal in_ID, decimal shift)
    {
        Class_ID = c_ID;
        Number_Credits = num_Credit;
        instructor_ID = in_ID;
        shift_time = shift;
    }
}