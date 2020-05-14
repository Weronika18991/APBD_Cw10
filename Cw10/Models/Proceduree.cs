﻿using System;
using System.Collections.Generic;

namespace Cw10.Models
{
    public partial class Proceduree
    {
        public Proceduree()
        {
            ProcedureAnimal = new HashSet<ProcedureAnimal>();
        }

        public int IdProcedure { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProcedureAnimal> ProcedureAnimal { get; set; }
    }
}
