﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.DomainModel
{
    public class ConsortiumConfigurationType
    {
        public virtual string Description { get; set; }
        public virtual bool IsPercentage { get; set; }
        public virtual int Id { get; set; }
    }
}