using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchlistDemo.Models;

namespace WatchlistDemo
{
    public class Lists
    {
       public List<Wathlist> list = new List<Wathlist>
        {
            new Wathlist { isActive=false,ProgramId=1,UserId=1 },
            new Wathlist {isActive=true,ProgramId=1,UserId=2 }
        };
            
    }
}