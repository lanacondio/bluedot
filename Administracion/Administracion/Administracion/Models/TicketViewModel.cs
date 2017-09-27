﻿using Administracion.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Administracion.Models
{
    public class TicketViewModel
    {
        public virtual int Id { get; set; }
        public virtual string Customer { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual int ConsortiumId { get; set; }
        public virtual Status Status { get; set; }
        public virtual DateTime OpenDate { get; set; }
        public virtual DateTime CloseDate { get; set; }
        public virtual DateTime LimitDate { get; set; }
        public virtual int FunctionalUnitId { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual int WorkerId { get; set; }
        public virtual int CreatorId { get; set; }
    }
}