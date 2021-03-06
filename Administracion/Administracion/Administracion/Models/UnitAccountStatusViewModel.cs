﻿using Administracion.DomainModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Administracion.Models
{
    public class UnitAccountStatusViewModel
    {
        public virtual string Uf { get; set; }
        public virtual string Piso { get; set; }
        public virtual string Dto { get; set; }
        public virtual string Propietario { get; set; }
        public virtual decimal SaldoAnterior { get; set; }
        public virtual decimal Pagos { get; set; }
        public virtual decimal Deuda { get; set; }
        public virtual decimal Intereses { get; set; }
        public virtual decimal GastosA { get; set; }
        public virtual decimal GastosB { get; set; }
        public virtual decimal Aysa { get; set; }
        public virtual decimal Edesur { get; set; }
        public virtual decimal SiPagaAntes { get; set; }
        public virtual decimal Total { get; set; }
    }
}