// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContaEmDiaProV1.Areas.Principal.Controllers
{
    [Area("Principal")]
    [Authorize]
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
