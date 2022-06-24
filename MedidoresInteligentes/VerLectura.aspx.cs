using MedidorModel.DAL;
using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresInteligentes
{
    public partial class VerMedidor : System.Web.UI.Page
    {

        private IntLectura lecturaDAL = new LecturaDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargaGrilla();
            }
        }

        private void cargaGrilla()
        {
            List<Lectura> lectura = lecturaDAL.ObtenerLectura();
            this.grillaLectura.DataSource = lectura;
            this.grillaLectura.Databind();
        }

        protected void update(object sender, EventArgs e)
        {

        }
    }
}