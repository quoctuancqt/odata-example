using System;
using System.Collections.Generic;

namespace OData.Demo.Data
{
    public class Role
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Account> Account { get; set; }
    }
}
