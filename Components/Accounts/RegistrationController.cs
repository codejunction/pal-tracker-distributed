﻿using Microsoft.AspNetCore.Mvc;
using Users;

namespace Accounts
{
    [Route("registration"), Produces("application/json")]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationService _service;

        public RegistrationController(IRegistrationService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserInfo info)
        {
            var record = _service.CreateUserWithAccount(info.Name);
            var value = new UserInfo(record.Id, record.Name, "registration info");
            return Created($"registration/{value.Id}", value);
        }
    }
}