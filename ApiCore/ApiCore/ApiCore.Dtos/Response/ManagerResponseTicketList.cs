﻿using ApiCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCore.Dtos.Response
{
    public class ManagerResponseTicketList
    {
        public virtual int Id { get; set; }
        public virtual UserResponse User { get; set; }
        
    }
}