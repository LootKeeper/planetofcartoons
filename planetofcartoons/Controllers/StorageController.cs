using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Net.Http.Headers;

namespace planetofcartoons.Controllers
{
    public class StorageController : Controller
    {
        private IHostingEnvironment _hosting;

        public StorageController(IHostingEnvironment hosting)
        {
            this._hosting = hosting;
        }
    }
}