using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;


namespace CapaPresentacion
{
    public partial class PlatosPrincipal : System.Web.UI.Page
    {
        PlatoNegocio plato = new PlatoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void BInsertar_Click(object sender, EventArgs e)
        {
            HttpPostedFile imagen = FUFotografia.PostedFile;
            int tamañoFotografia = imagen.ContentLength;
            byte[] fotografia = new byte[tamañoFotografia];
            imagen.InputStream.Read(fotografia, 0, tamañoFotografia);

            plato.InsertarPlato(TBDescripcion.Text, TBPrecio.Text, RBDisponible.Text, TBnombre.Text, ref fotografia);

            

        }
    }
}