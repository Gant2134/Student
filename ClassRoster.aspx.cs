using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClassRoster : System.Web.UI.Page
{
    protected Bookkeeper thisnikka
    {
        get
        {
            if (Session["thisnikka"] == null)
            {
                Session["thisnikka"] = new Bookkeeper();
            }
            return (Bookkeeper)Session["thisnikka"];
        }
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        ContentPlaceHolder cphMain
                    = (ContentPlaceHolder)Master.FindControl("cphMain");
    }
}