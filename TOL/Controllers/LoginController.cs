using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TOL.Models;
using TOL.Models.Interface;

namespace TOL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginManager _loginManager;
        private ILogger<LoginController> _logger;
        public LoginController( ILoginManager loginManager, ILogger<LoginController> logger)
        {
            _loginManager = loginManager;
            _logger = logger;
        }
        [HttpPost]
        public ActionResult<LoginData> Login()
        {
            var response = _loginManager.Login();
            return response;
        }

    }
}