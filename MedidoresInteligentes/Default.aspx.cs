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
    public partial class Default : System.Web.UI.Page
    {
        private IntLectura lecturaDAL = new LecturaDALObjetos();
        private IntMedidor MedidoresDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = MedidoresDAL.ObtenerMedidor();
                this.NumMedidorDdl.DataSource = medidores;
                this.NumMedidorDdl.DataBind();
            }
        }

        protected void agregarBtn_CLick(object sender, EventArgs e)
        {
            int nummedidor = this.NumMedidorDdl.SelectedIndex;
            DateTime fecha = Fecha.SelectedDate;
            DateTime hora = Convert.ToDateTime(this.HrsLectura.Text.Trim());
            DateTime minutos = Convert.ToDateTime(this.MinLectura.Text.Trim());
            decimal valconsumo = Convert.ToDecimal(this.ValConsumo.Text.Trim());

            List<Medidor> medidors = MedidoresDAL.ObtenerMedidor();
            Medidor medidor = medidors.Find(b => b.Id_Medidor == this.NumMedidorDdl.SelectedIndex);

            Lectura lectura = new Lectura()
            {
                Fecha = fecha,
                Hora = hora,
                Minutos = minutos,
                ValorCon = valconsumo
            };

            lecturaDAL.AgregarLectura(lectura);

            this.mensajesLbl.Text = "Lectura Ingresada";
            Response.Redirect("VerLectura.aspx");
        }


    }
}