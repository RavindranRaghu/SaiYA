using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaiYAMain.Models;

namespace SaiYAMain.ViewModel{
    public class ExistingUser
    {
        public string eud {get; set;}
        public string epd {get; set;}
    }

    public class NewUser
    {
        public string ud {get; set;}
        public string pd {get; set;}
        public string un {get; set;}
        public string phone {get; set;}
    }

    
}