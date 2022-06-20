using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class Medidor
    {
        private int numMedidor;
        private int tipo;
        private Lectura valorCon;

        private string tipoTxt
        {
            get
            {
                string tipoTxt = "";
                switch (tipo)
                {
                    case 1: tipoTxt = "Inteligente";
                        break;
                    case 2: tipoTxt = "Antiguo";
                        break;
                }
                return tipoTxt;
            }
        }
        public int NumMedidor { get => numMedidor; set => numMedidor = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public Lectura ValorCon { get => valorCon; set => valorCon = value; }
        
    }
}
