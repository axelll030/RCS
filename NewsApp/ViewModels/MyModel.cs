using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.ViewModels
{
    public class MyModel
    {
        public List<News> News { get; set; }
        public List<Topic> Topics { get; set; }
        public Topic Topic { get; set; }
    }
}