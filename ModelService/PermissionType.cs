﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelService
{
    public class PermissionType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
