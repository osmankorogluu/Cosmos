﻿using Cosmos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Domain.Entities
{
    public class Category: BaseEntity
    {
        public string CategoryName { get; set; }
    }
}
