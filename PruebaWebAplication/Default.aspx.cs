using System;
using CapaNegocio;

namespace PruebaWebAplication
{
    public partial class Default : System.Web.UI.Page
    {
        
        CNpersonas bll= new CNpersonas();
        protected void btn444_Click(object sender, EventArgs e)
        {
            bool acceso = bll.Login(txt1.Text, txt2.Text);
            if (acceso)
            {
                Response.Redirect("Principal.aspx");

            }
            else
            {
                L1.Text = "usuario no encontrado";
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}