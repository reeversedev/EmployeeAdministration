﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeAdministration.Controllers
{
    public class TestController : Controller
    {
        public ActionResult GetView()
        {
            return View("MyView");
        }
    }
}