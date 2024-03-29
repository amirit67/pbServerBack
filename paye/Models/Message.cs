﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Paye.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public string Timestamp { get; set; }

        public virtual Paye.Models.User FromUser { get; set; }

        [Required]
        public virtual Room ToRoom { get; set; }
    }
}