﻿using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface IntMedidor
    {
        List<Medidor> ObtenerMedidor();
            
        void AgregarMedidor(Medidor medidor);

    }
}
