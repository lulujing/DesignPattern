using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchlistDemo.Models
{
    public class Wathlist
    {
        public int ProgramId {get;set;}
        public int UserId { get; set; }
        public bool isActive { set; get; }
    }
}