using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class Lectura
    {
        private Medidor numMedidor;
        private DateTime fecha;
        private DateTime hora;
        private Medidor valorCon;

        public Medidor NumMedidor { get => numMedidor; set => numMedidor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public Medidor ValorCon { get => valorCon; set => valorCon = value; }

        public override string ToString()
        {
            return numMedidor + "| " + Fecha + "| " + valorCon;
        }
    }
}
