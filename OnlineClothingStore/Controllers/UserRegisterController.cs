using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineClothingStore.Controllers
{
    public class UserRegisterController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}