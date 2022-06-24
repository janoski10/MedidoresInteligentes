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
    public partial class VerMedidores : System.Web.UI.Page
    {

        private IntMedidor MedidorDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
            }
        }


        //Obtener Medidores
        private void cargaGrilla()
        {
            List<Medidor> medidor = MedidorDAL.ObtenerMedidor();
            this.grillaMedidor.DataSource = medidor;
            this.grillaMedidor.DataBind();
        }


        private void cargaGrilla(List<Medidor> filtrada)
        {
            List<Medidor> medidor = MedidorDAL.ObtenerMedidor();
            this.grillaMedidor.DataSource = filtrada;
            this.grillaMedidor.DataBind();
        }

        

        //Filtrar Medidores
        protected void tipoDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoDdl_SelectedItem != null)
            {
                int nivel = Convert.ToInt32(this.tipoDdl_SelectedItem.value);
                List<Medidor> filtrada = MedidorDAL.Filtrar(tipo);
                cargaGrilla(filtrada);
            }
        }

    }
}