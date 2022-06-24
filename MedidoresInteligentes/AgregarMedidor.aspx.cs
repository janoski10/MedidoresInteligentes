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
    public partial class AgregarMedidor : System.Web.UI.Page
    {

        private IntMedidor medidorDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            Medidor medidor = new Medidor();
            medidor.Id_Medidor = this.idTxt.Text.Trim();
            medidor.Tipo = this.idTipo.DropDownList.Trim();
            this.medidorDAL.AgregarMedidor(medidor);
            Response.Redirect("VerMedidor.aspx");
        }


    }
}