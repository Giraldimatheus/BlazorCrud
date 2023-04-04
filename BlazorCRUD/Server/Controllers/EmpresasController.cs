using BlazorCRUD.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCRUD.Server.Controllers
{
    [Route("api/empresas")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly List<Class1> _empresas;

        public EmpresasController()
        {
            _empresas = new List<Class1>
            {
                new Class1
                {
                    Id = 1,
                    NomeEmpresa = "Teste",
                    Segmento = "Tecnologia",
                    Site = "wwww.teste.com"
                },
                new Class1
                {
                    Id = 2,
                    NomeEmpresa = "Empresa 2",
                    Segmento = "Alimentos",
                    Site = "wwww.empresa2.com"
                },
                new Class1
                {
                    Id = 3,
                    NomeEmpresa = "Empresa 3",
                    Segmento = "Moda",
                    Site = "wwww.empresa3.com"
                }
            };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Class1>> GetEmpresas()
        {
            return Ok(_empresas);
        }

        [HttpGet("{id}")]
        public ActionResult<Class1> GetEmpresa(int id)
        {
            var empresa = _empresas.FirstOrDefault(h => h.Id == id);
            if (empresa == null)
            {
                return NotFound();
            }
            return Ok(empresa);
        }
    }
}
