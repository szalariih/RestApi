using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlaMundo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OlaMundoController : ControllerBase
    {
        
        public OlaMundoController(ILogger<OlaMundoController> logger)
        {
           
        }

        [HttpGet]
        public OlaMundo ObterMensagem()
        {
            var retorno = new OlaMundo();
            retorno.Mensagem = "Olá mundo - Essa é minha primeira Web API";
            retorn retorno;
        }
    }
}
