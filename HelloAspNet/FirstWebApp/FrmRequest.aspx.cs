using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserId = "";
            string strPassword = string.Empty; // ="";
            string strName = "";
            string strAge = "";

            strUserId = Request.Params["TxtUserID"];//Request.QueryString["TxtUserID"]; // GET형식 가져올때
            strPassword = Request.Params["TxtPassworde"]; // 1. GET/POST 뭐든지 불러옴
            strName = Request.Form["Name"]; // post형식
            strAge = Request["Age"];

            var result = $@"입력하신 아이디는 {strUserId}이고 <br />
                            암호는 {strPassword}입니다 <br />
                            이름은 {strName}이고, <br />
                            나이는 {strAge}입니다. <br/>";
            LblResult.Text = result;

            LblAddress.Text = Request.UserHostAddress;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}