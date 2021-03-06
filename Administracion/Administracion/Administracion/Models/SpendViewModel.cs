﻿using Administracion.DomainModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Administracion.Models
{
    public class SpendViewModel
    {
        public virtual int Id { get; set; }
        public virtual int Month { get; set; }
        public virtual IDictionary<Manager, IList<Spend>> SalarySpends { get; set; }
        public virtual IList<Spend> SalarySpendWithoutManager { get; set; }
        public virtual IList<Spend> Spends { get; set; }
        public virtual IEnumerable<SelectListItem> SpendTypes { get; set; }
        public virtual IEnumerable<SelectListItem> SpendItems { get; set; }                
        public virtual int ConsortiumId { get; set; }
        public virtual Dictionary<string, decimal> AportesYContribucionesSpends { get; set; }
    }
}