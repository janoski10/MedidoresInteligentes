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
            List<Medidor> medidores = MedidoresDAL.ObtenerMedidor();
        }

        protected void agregarBtn_CLick(object sender, EventArgs e)
        {
            int nummedidor = this.NumMedidorDdl.SelectedIndex;

            DateTime fecha = this.FechaC.SelectedDate;
            DateTime hora = Convert.ToDateTime(this.HrsLectura.Text.Trim());
            DateTime minutos = Convert.ToDateTime(this.MinLectura.Text.Trim());
            decimal valconsumo = Convert.ToDecimal(this.ValConsumo.Text.Trim());


            Lectura lectura = new Lectura()
            {
                NumMedidor = nummedidor,
                Fecha = fecha,
                Hora = hora,
                
                ValorCon = valconsumo
            };

            this.mensajesLbl.Text = "Lectura Ingresada";
        }


    }
}