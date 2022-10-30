using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consultorio2
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var conexion = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\ESBA\Cuarto Cuatrimestre\PP Integración de Sistemas\Consultorio2_DB\Consultorio2\App_Data\Database1.mdf';Integrated Security=True");

            string sql = "insert into Usuarios (Nombre, Clave) values (@nombre, @clave)";
            string sql2 = "select * from usuarios where nombre='" +TextBox1.Text.Trim()+ "'and clave='" +TextBox2.Text.Trim()+ "' "; 
            
            conexion.Open();
            
            var comando = new SqlCommand(sql2 , conexion);

            //comando.Parameters.AddWithValue("nombre", TextBox1.Text);
            //comando.Parameters.AddWithValue("clave", TextBox2.Text);
            //comando.Parameters.AddWithValue("telefono", TextBox3.Text);

            SqlDataReader res = comando.ExecuteReader();
            //comando.ExecuteNonQuery();
            if (res.HasRows)
                {
                    Response.Redirect("Turnero.aspx");
                }
            else {
                    Response.Write("Nombre y clave Incorrecta, Intenta Nuevamente");
                }
            
            conexion.Close();   
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro_datos.aspx");
        }
    }

}
