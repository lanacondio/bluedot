﻿using ApiCore.DomainModel;
using ApiCore.Dtos;
using ApiCore.Dtos.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCore.Services.Contracts.SpendItems
{
    public interface ISpendItemService
    {
        
        IList<SpendItem> GetAll();
        
    }
}