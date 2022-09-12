using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspLinq
{
    public partial class UsersList : System.Web.UI.Page
    {
        DataLinqDataContext db = new DataLinqDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                LoadData();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uusername = Username_log.Text, ppassword = Password_log.Text, nname = Name_log.Text, aaddress = Address_log.Text, eemail = Email_log.Text;
                var dt = new user
                {
                    username = uusername,
                    password = ppassword,
                    name = nname,
                    address = aaddress,
                    email = eemail
                };
                db.users.InsertOnSubmit(dt);
                db.SubmitChanges();
                LoadData();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User Success Insert')", true);
            }catch(Exception err)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('"+err.Message.ToString()+"')", true);
            }
            
        }

        void LoadData()
        {
            var dt = from x in db.users select x;
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Button_Update(object sender, EventArgs e)
        {
            try
            {
                int uuserid = int.Parse(UserId_log.Text);
                string uusername = Username_log.Text, ppassword = Password_log.Text, nname = Name_log.Text, aaddress = Address_log.Text, eemail = Email_log.Text;
                var dt = (from x in db.users where x.userid == uuserid select x).First();
                dt.username = uusername;
                dt.password = ppassword;
                dt.name = nname;
                dt.address = aaddress;
                dt.email = eemail;

                db.SubmitChanges();
                LoadData();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User Success Update')", true);
            }
            catch (Exception err)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('" + err.Message.ToString() + "')", true);
            }
        }

        protected void Button_Delete(object sender, EventArgs e)
        {
            try
            {
                int uuserid = int.Parse(UserId_log.Text);
                var dt = (from x in db.users where x.userid == uuserid select x).First();
                db.users.DeleteOnSubmit(dt);
                db.SubmitChanges();
                LoadData();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User success deleted')", true);
            }catch(Exception err)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('" + err.Message.ToString() + "')", true);
            }
        }

        protected void Button_ExportExcel(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/ms-excel";
            Response.AddHeader("content-disposition", "attachment; filename=UserInfo.xls");
            Response.Charset = "";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridView1.RenderControl(htw);
            Response.Output.Write(sw.ToString());
            Response.End();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }
    }
}