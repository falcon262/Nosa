using Microsoft.AspNetCore.Mvc;
using PwC.Nosa.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Nosa.Controllers
{
    public class NosaUserController : NosaController
    {
        private readonly IUserAppService _userAppService;

        public NosaUserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateLosAsync()
        {
            var Id = Request.Form["id"].First();
            var los = Request.Form["los"].First();

            await _userAppService.UpdateUserLosAsync(Guid.Parse(Id), los);

            return Ok();
        }

    }
}
