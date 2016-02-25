using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmailDemo.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required, AllowHtml]
        public string Text { get; set; }
    }
}