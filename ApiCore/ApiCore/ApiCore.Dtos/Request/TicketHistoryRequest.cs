﻿using ApiCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCore.Dtos.Request
{
    public class TicketHistoryRequest
    {
        public virtual string Coment { get; set; }
        public virtual DateTime FollowDate { get; set; }        
        public virtual int TicketId { get; set; }                
    }
}