using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;


// 220072233 AK KIbambe 
// db => ujstafflab3
// table name => ujstaffportal

namespace kibambe_ak_220072233_labexe3
{
  public partial class index : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // create staff
    protected void CreateStaff_Click(object sender, EventArgs e)
    {
      BusinessLayer.Algorithms.StaffId = idNo.Text;
      BusinessLayer.Algorithms.StaffName = firstname.Text;
      BusinessLayer.Algorithms.StaffLastname = lastname.Text;
      // 
      email.Text = BusinessLayer.Algorithms.makeStaffEmail();
      age.Text = BusinessLayer.Algorithms.getAge();
    }

    // save staff
    protected void SaveStaff_Click(object sender, EventArgs e) {
      BusinessLayer.Algorithms.AddStaff();

      ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage",
        "alert('User Added')", true);

      clear_();
    }

    // read staffs
    protected void ReadStaff_Click(object sender, EventArgs e)
    {
      ujstaffs.DataSource = BusinessLayer.Algorithms.GetStaff();
      ujstaffs.DataBind();
    }

    // clear web form and components.
    protected void ClearStaffs_Click(object sender, EventArgs e){ Response.Redirect("~/index.aspx"); }

    // exit the uj portal
    protected void ExitPortal_Click(object sender, EventArgs e) { Environment.Exit(0); }


    public void clear_() {
      firstname.Text = "";
      lastname.Text = "";
      idNo.Text = "";
      email.Text = "";
      age.Text = "";
    }
  }
}