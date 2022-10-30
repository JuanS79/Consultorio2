using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consultorio2
{
    public partial class Registro_datos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var conexion = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\ESBA\Cuarto Cuatrimestre\PP Integración de Sistemas\Consultorio2_DB\Consultorio2\App_Data\Database1.mdf';Integrated Security=True");

            string sql = "insert into Usuarios (Nombre, Clave, Email, Telefono, Apellido ) values (@nombre, @clave, @email, @telefono, @apellido)";
            //string sql2 = "select * from usuarios where nombre='" + TextBox1.Text.Trim() + "'and clave='" + TextBox2.Text.Trim() + "' ";

            conexion.Open();

            var comando = new SqlCommand(sql, conexion);

            var telefono = Int64.Parse(registro_telefono.Text);

            comando.Parameters.AddWithValue("nombre", registro_nombre.Text);
            comando.Parameters.AddWithValue("clave", registro_clave.Text);
            comando.Parameters.AddWithValue("email", registro_email.Text);
            comando.Parameters.AddWithValue("telefono", telefono);
            comando.Parameters.AddWithValue("apellido", registro_apellido.Text);

            comando.ExecuteNonQuery();
            
            //SqlDataReader res = comando.ExecuteReader();
            
            /*
            if (res.HasRows)
            {
                Response.Redirect("Turnero.aspx");
            }
            else
            {
                Response.Write("Nombre y clave Incorrecta, Intenta Nuevamente");
            }
            */
            
            conexion.Close();
        }
    }
}