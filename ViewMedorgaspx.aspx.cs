using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class ViewMedorgaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
    protected void MedorgDDL_SelectedIndexChanged(object sender, EventArgs e)
    {
        DepartDDL.DataBind();
    }
    protected void MedorgDDL_TextChanged(object sender, EventArgs e)
    {
        DepartDDL.DataBind();
    }
    protected void grid_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("ViewShedule.aspx"); 
    }
}