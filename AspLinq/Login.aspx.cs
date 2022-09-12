using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspLinq
{
    public partial class Login : System.Web.UI.Page
    {
        DataLinqDataContext db = new DataLinqDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] != null)
            {
                Response.Redirect("UsersList.aspx");
            }
        }

        protected void login_Click(object sender, EventArgs e)
        {
            var checkuser = from x in db.users where x.username == username_log.Text select x;
            if(checkuser.Count() > 0)
            {
                try
                {
                    var checkpass = (from x in db.users where (x.username == username_log.Text && x.password == password_log.Text) select x).First();
                }catch(Exception err)
                {
                   
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('" + err.Message.ToString() + "')", true);
                    return;
                }
                Session["userlogin"] = username_log.Text;
                Response.Redirect("UsersList.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User tidak ditemukan')", true);
            }
        }
    }
}