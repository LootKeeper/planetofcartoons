using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace planetofcartoons.ControllersExtend
{
    public static class ControllerBaseExtension
    {
        public static JsonResult Json(this ControllerBase controller, object value)
        {
            return new JsonResult(value);
        }
    }
}
