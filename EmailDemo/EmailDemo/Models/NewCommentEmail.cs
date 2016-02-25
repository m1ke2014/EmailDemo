﻿using Postal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailDemo.Models
{
    public class NewCommentEmail : Email
    {
        public string To { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
    }
}