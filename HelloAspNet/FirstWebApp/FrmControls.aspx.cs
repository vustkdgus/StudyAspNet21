using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LsbHobby.Items.Add("농구");
            LsbHobby.Items.Add("배구");

            CboPhoneNum.Items.Add("010-2222-1234");

            if (!Page.IsPostBack)
            {
                CtlHidden.Value = DateTime.Now.ToString();
            }
        }

        protected void BtnChange_Click(object sender, EventArgs e)
        {
            ImgChange.ImageUrl = "~/images/bbb.png";
        }

        protected void BtnOK_Click(object sender, EventArgs e)
        {
            Response.Write(CtlHidden.Value);
        }
    }
}