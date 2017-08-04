using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class studentclassassoc : System.Web.UI.Page
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

        if (!IsPostBack)
        {
            String[] Studentcol = new String[] { "Student_ID", "First_Name", "Last_Name" };
            String[] Classcol = new String[] { "class_id", "shift_time" };
            List<String> lst_student = Bookie.BuildList("Student", Studentcol);
            List<String> lst_Class = Bookie.BuildList("Class", Classcol);

            for (int i = 0; i < lst_student.Count; i++)
            {
                DDLSTU.Items.Add(lst_student[i]);
            }
            for (int i = 0; i < lst_Class.Count; i++)
            {
                DDLCLS.Items.Add(lst_Class[i]);
            }

            string g = DDLSTU.SelectedItem.Text;
            string P = DDLCLS.SelectedItem.Text;
        }

    }



    protected void Enrollbtn_Click(object sender, EventArgs e)
    {
        AssociationInfo ai = new AssociationInfo();
        string input1=DDLSTU.SelectedItem.Text;
        string input2 =DDLCLS.SelectedItem.Text;
        string pattern = " ";

        String[] substringSTU = Regex.Split(input1, pattern);
        String[] substringCls = Regex.Split(input2, pattern);

        ai.Association_ID = Convert.ToDecimal(index.Text);
        ai.Student_ID = Convert.ToDecimal(substringSTU[0]);
        ai.First_Name = substringSTU[1];
        ai.Last_Name = substringSTU[2];
        ai.Class_ID = substringCls[0];
        ai.Shift_Time = Convert.ToDecimal(substringCls[1]);

        Bookie.CreateAssociation(ai);

        Response.Write("Enrolled successufully");



    }
}