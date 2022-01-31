using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwoTableWebAPI.Models
{
    //add tables get set method
    public class JoinClass1
    {
     
        public tb_City getCity { set; get; }
        public tb_Country getCountry { set; get;}
    }
}