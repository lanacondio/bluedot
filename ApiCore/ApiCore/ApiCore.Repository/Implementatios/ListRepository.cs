﻿using ApiCore.DomainModel;
using ApiCore.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCore.Repository.Implementatios
{
    public class ListRepository : Repository<List>, IListRepository
    {
    	public IList<List> GetByConsortium(int id)
    	{
    		var result = this.Context.Set<List>().Where(x => x.Consortium.Id == id)
                .ToList();
            return result;

    	}
    }
}
