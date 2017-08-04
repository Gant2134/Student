using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
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
    }
 




    protected void StuRosterbtn_Click(object sender, EventArgs e)
    {

        Response.Redirect("StudentRoster.aspx");
                
    }

    protected void ClsRoster_Click(object sender, EventArgs e)
    {
       
        
        
        Session["Tablename"] = "Class";
        Response.Redirect("ClassRoster.aspx");

    }

    protected void stuclsassoc_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentclassassoc.aspx");
    }

    protected void Homebtn_Click(object sender, EventArgs e)
    {
        Session["Tablename"] = "Class";
        Response.Redirect("Home.aspx");
  

    }

    protected void inputBtn_Click(object sender, EventArgs e)
    {
        if((string)Session["TableName"]== "Student")
        {

        }
        else if ((string)Session["TableName"] == "Class")
        {

        }
        else
        {

        }
    }

    protected void mngstubtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentADD.aspx");
    }
}
