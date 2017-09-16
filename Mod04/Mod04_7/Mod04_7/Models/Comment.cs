using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mod04_7.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "subject 不可為空白")]
        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        public string HtmlComment { get; set; }

        public int Price { get; set; }
        public bool IsApprove { get; set; }

    }
}