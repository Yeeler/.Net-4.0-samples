using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbColumn
{
    public class Client
    {
        [PrimaryKey]
        [DbColumn("client_id")]
        public int ClientId { get; set; }

        [DbColumn("last_name")]
        public string LastName { get; set; }

        [DbColumn("first_name")]
        public string FirstName { get; set; }

        [DbColumn("email")]
        public string Email { get; set; }
    }
}
