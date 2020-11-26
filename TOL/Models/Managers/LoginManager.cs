using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOL.Models.Interface;

namespace TOL.Models.Managers
{
    public class LoginManager:ILoginManager
    {
        private ILogger<LoginManager> _logger;
        public LoginManager(ILogger<LoginManager> logger)
        {

            _logger = logger;
           
        }


        public LoginData Login()
        {
            return null;
        
        }
    }
}
