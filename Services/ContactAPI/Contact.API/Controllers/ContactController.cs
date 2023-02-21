using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public IContactService contactService;

        public ContactController(IContactService ContactService)
        {
            contactService = ContactService;
        }

        [HttpGet("{Id}")]
        public ContactDTO Get(int Id)
        {
            return contactService.GetContactById(Id);
        }
    }
}

