﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class AuditableEntity
    {
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifed { get; set; }
        public string LastModifedBy { get; set; }
    }
}
