﻿using GraphQL.Types;
using InventoryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.GraphqlMutations
{
    public class ProductTypeGQLInputType:EnumerationGraphType<ProductType>
    {
    }
}
