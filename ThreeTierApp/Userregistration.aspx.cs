using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussinesslogic;
using BussinessObject;

namespace ThreeTierApp
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Name')", true);
            }

            else if (txAddress.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Address')", true);
            }
            else if (txtEmailid.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter EmailID')", true);
            }
            else if (txtmobile.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Mobile no')", true);
            }
            else
            {
                UserBO ObjUBO = new UserBO();
                /*
                 calling BussinessObject (UserBO) 
                 And passing all value from Control to it.
                */

                ObjUBO.Name = txtname.Text;
                ObjUBO.address = txAddress.Text;
                ObjUBO.EmailID = txtEmailid.Text;
                ObjUBO.Mobilenumber = txtmobile.Text;

                UserBL objUBL = new UserBL();

                int result = objUBL.SaveUserregisrationBL(ObjUBO);

                if (result > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data saved successfully By Using 3 tier by :-sai')", true);
                }

                /*
                 Calling Bussinesslogic (UserBL) 
                 And Passing Value To it  
                */
            }



        }



    }
}