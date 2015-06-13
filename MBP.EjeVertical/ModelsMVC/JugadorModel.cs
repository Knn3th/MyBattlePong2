﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MBP.CapaTransversal.ModelsMVC
{
    public class JugadorModel
    {

        [Required]
        [StringLength(120, MinimumLength = 1, ErrorMessage = "UserName No Válido")]
        public string DescripcionPersonal { get; set; }

    }
}