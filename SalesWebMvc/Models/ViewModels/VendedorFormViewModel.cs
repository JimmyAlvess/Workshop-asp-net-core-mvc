﻿using System.Collections;
using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class VendedorFormViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Departamento>Departamentos { get; set; }

    }
}
