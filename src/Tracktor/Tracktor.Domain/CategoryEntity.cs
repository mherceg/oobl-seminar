﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracktor.Domain
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }


		public override string ToString()
		{
			return this.Name;
		}
    }

}
