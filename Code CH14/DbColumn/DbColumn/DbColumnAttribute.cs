using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbColumn
{
    public class DbColumnAttribute : Attribute
    {
        public string Name { get; private set; }

        public DbColumnAttribute(string name)
        {
            this.Name = name;
        }
    }

    public class PrimaryKeyAttribute : Attribute
    {
    }
}
