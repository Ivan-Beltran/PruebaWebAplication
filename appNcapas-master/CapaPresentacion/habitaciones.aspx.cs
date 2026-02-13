using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class habitaciones : System.Web.UI.Page
    {
        CNHabitaciones bll= new CNHabitaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                CargarGrid();
            }
        }

        protected void CargarGrid()
        {
            GridView1.DataSource = bll.LoadHabitaciones();
            GridView1.DataBind();
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtnumero.Text);
            string descripcion = txtdescripcion.Text;
            int cantidad = Convert.ToInt32(txtcant.Text);

            bool correcto = bll.agregarHabitacion(numero, descripcion, cantidad);
            if (correcto)
            {
                Response.Write("<script>alert('Habitación agregada correctamente');</script>");
                CargarGrid();
            }
            else
            {
                Response.Write("<script>alert('Error al agregar la habitación');</script>");
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            if (bll.EliminarHabitacion(id))
            {
                CargarGrid();
            }
            
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            CargarGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            GridViewRow row = GridView1.Rows[e.RowIndex];

            int numero = int.Parse((row.Cells[1].Controls[0] as System.Web.UI.WebControls.TextBox).Text);
            string descripcion = (row.Cells[2].Controls[0] as System.Web.UI.WebControls.TextBox).Text;
            int cantidad = int.Parse((row.Cells[3].Controls[0] as System.Web.UI.WebControls.TextBox).Text);

            if (bll.ModificarHabitacion(id, numero, descripcion, cantidad))
            {
                GridView1.EditIndex = -1;
                CargarGrid();
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            CargarGrid();

        }
    }
}