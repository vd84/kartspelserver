using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace kartspelserver.Models
{

    public class User
    {
        private string username {get; set;};
        private string interests;
    }

}
