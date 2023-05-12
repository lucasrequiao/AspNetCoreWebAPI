using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        
        // GET: api/<AlunoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O aluno não foi encontrado!");
            return Ok(aluno);
        }

        // POST api/<AlunoController>
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        // PATCH api/<AlunoController>/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Oliveira",
                Telefone = "12121212"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Marta",
                Sobrenome = "Kent",
                Telefone = "45454545"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Laura",
                Sobrenome = "Maria",
                Telefone = "78787878"
            }
        };
    }
}
