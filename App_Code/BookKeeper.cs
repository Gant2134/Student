﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Bookkeeper
/// </summary>
public class Bookkeeper
{
    protected string connString = "Data Source=EDUCATIONPC\\SQLEXPRESS; Initial Catalog=Palette; Integrated Security=true;";
    protected SqlConnection conn;
    protected SqlCommand cmd;
    protected SqlDataReader rdr;

    public Bookkeeper()
    {

    }

    //the book keeper has to do three things.....retreve the table for viewing , modify the table, and create new tables(????), one moooore thing needs to search database for specific users or items.
    public void AddNewStudent(StudentInfo si)
    {
        using (conn = new SqlConnection(connString))// using block ensures disposal/disconnection if anything bad happens
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
               
                    string query = "Insert into Student values (" + si.Student_ID + ",'" + si.First_Name + "','" + si.Last_Name + "'," + si.Phone_Number + ",'" + si.Email + "'," + si.GPA + ");";
                    cmd = new SqlCommand(query, conn);
             
                    cmd.ExecuteNonQuery();
                    
                
                
               
            }

        }
    }

   /* public void AddNewInstructor(InstructorInfo ii)
    {

    }

    public void AddNewClass(ClassInfo ci)
    {
        using (conn = new SqlConnection(connString))// using block ensures disposal/disconnection if anything bad happens
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string query = "Insert into Class Values ('" + ci.Class_ID + "','" + ci.Number_Credits + "','" + ci.instructor_ID + "','" + ci.shift_time + "');";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

        }
    }
    */

    public Table DisplayTable(string TableName) // need the item to be passed in
    {
        Table t = new Table();
        using (conn = new SqlConnection(connString))
        {


            conn.Open();
            string query = "Select * from " + TableName + ";";
            cmd = new SqlCommand(query, conn);
            using (rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                {
                    int nFields = rdr.FieldCount;
                    String[] current_values = new String[nFields];
                    do
                    {
                        
                        //rdr.GetValues(current_values);
                        TableRow row = new TableRow();
                        for (int i = 0; i < nFields; i++)
                        {
                            String value = rdr[i].ToString();
                            TableCell column = new TableCell();
                            column.Text = value;
                            row.Cells.Add(column);

                        }
                        t.Rows.Add(row);
                    }
                    while (rdr.Read());
                }
            }
        }
        return t;
    }

    public void Searchdatabase(string TableName, string FieldName)
    {
        conn.Open();
        string query = "Select " + FieldName + " from '" + TableName + "';";
        cmd = new SqlCommand(query, conn);
        //using (rdr = cmd.ExecuteReader());
    }







}