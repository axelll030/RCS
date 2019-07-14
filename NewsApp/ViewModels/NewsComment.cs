using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsApp.Models;

namespace NewsApp.ViewModels
{
    public class NewsComment
    {
        public List<Comment> Comments { get; set; }
        public News News { get; set; }
        public Comment NewComment { get; set; }
    }
}
