﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
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
}