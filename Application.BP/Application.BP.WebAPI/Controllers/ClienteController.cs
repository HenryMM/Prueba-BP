using Application.BP.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.BP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            var clientes = new List<Cliente> {
               new Cliente
               {
                   Id = 1,
                   Direccion = "test direccion",
                   Estado = true,
                   Nombres = "Paul",
                   Password = "123",
                   Telefono = "09845"
               }
            };

            return Ok(clientes);
        }
    }
}
