﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Administracion.Models
{
    public class ConsortiumViewModel
    {
        public virtual string FriendlyName { get; set; }
        public virtual string CUIT { get; set; }
        public virtual string MailingList { get; set; }
        public virtual int AdministrationId {get; set;}
        public virtual int OwnershipId {get; set;}
    }
}