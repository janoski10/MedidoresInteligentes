using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DTO
{
    public class Lectura
    {
        private Medidor id_medidor;
        private DateTime fecha;
        private DateTime hora;
        private DateTime minutos;
        private decimal valorCon;

        public Medidor Id_Medidor { get => id_medidor; set => id_medidor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public DateTime Minutos { get => minutos; set => minutos = value; }
        public decimal ValorCon { get => valorCon; set => valorCon = value; }

        public override string ToString()
        {
            return id_medidor + "| " + Fecha + "| " + valorCon;
        }


    }
}
}
    