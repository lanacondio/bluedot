﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCore.DomainModel
{
    public class Manager : Entity
    {    
         public virtual Address Home { get; set; }
         public virtual Address JobDomicile { get; set; }
         public virtual User User{ get; set; }
         public virtual DateTime StartDate{ get; set; }         
         public virtual LaboralUnion LaborUnion { get; set; }         
         public virtual double Salary{ get; set; }         
         public virtual string WorkInsurance{ get; set; }         
         public virtual bool IsAlternate{ get; set; }         
        public virtual Consortium Consortium { get; set; }

    }
}
