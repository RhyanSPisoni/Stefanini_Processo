using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StefaniniServer.DTO;
using StefaniniServer.Models;
using StefaniniServer.Services;
using StefaniniServer.Views;

namespace StefaniniServer.Controllers
{
    [ApiController]
    [Route("People")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public async Task<List<PersonView>> SearchPeople()
        {
            try
            {
                return await ServPerson.SearchPeople();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpGet]
        [Route("Search")]
        public async Task<List<PersonView>> SearchListPeople(int id)
        {
            try
            {
                return await ServPerson.SearchListPeople(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpPost]
        [Route("New")]
        public async Task<Confirmation> NewPeople([FromBody] List<Pessoa> person)
        {
            try
            {
                return await ServPerson.NewPeople(person);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpPatch]
        [Route("Update")]
        public async Task<Confirmation> UpdatePeople([FromBody] PessoaDTO person)
        {
            try
            {
                return await ServPerson.UpdatePeople(person);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<Confirmation> DeletePeople([FromRoute] int id)
        {
            try
            {
                return await ServPerson.DeletePeople(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }
        }
    }
}