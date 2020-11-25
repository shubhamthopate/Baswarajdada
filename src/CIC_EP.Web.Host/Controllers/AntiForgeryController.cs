﻿using Microsoft.AspNetCore.Antiforgery;

namespace CIC_EP.Web.Controllers
{
    public class AntiForgeryController : CIC_EPControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
