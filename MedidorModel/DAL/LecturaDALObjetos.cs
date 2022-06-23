﻿using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class LecturaDALObjetos : IntLectura
    {
        private static List<Lectura> lecturas = new List<Lectura>();

        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public List<Lectura> ObtenerLectura()
        {
            return lecturas;
        }
    }
}
