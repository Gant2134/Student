using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class StudentADD : System.Web.UI.Page
{
    protected Bookkeeper Bookie
    {
        get
        {
            if (Session["Bookie"] == null)
            {
                Session["Bookie"] = new Bookkeeper();
            }
            return (Bookkeeper)Session["Bookie"];
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ContentPlaceHolder cphMain
                   = (ContentPlaceHolder)Master.FindControl("cphMain");
    }

    protected void Updatebtn_Click(object sender, EventArgs e)
    {
        decimal sid = Convert.ToDecimal(Input1.Text);

        StudentInfo si = new StudentInfo( sid, Input2.Text, input3.Text, Convert.ToDecimal(input4.Text), input5.Text,Convert.ToDecimal(input6.Text));
       try
       {
            Bookie.AddNewStudent(si);
            Response.Write("Student added");
       }
       catch(Exception ex)
       {
            Response.Write("Connection to database could not be established.\r\n");
            Response.Write("Developer insight: " + ex.Message + "\r\n");
       }
    }
}