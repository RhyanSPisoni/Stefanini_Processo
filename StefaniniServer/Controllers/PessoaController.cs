using System;
using Microsoft.AspNetCore.Mvc;
using StefaniniServer.DTO;
using StefaniniServer.Models;
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
                return await Services.ServPerson.SearchPeople();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpGet]
        [Route("Search")]
        public async Task<List<PersonView>> SearchListPeople(List<int> ids)
        {
            try
            {
                return await Services.ServPerson.SearchListPeople(ids);
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
                return await Services.ServPerson.NewPeople(person);
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
                return await Services.ServPerson.UpdatePeople(person);
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
                return await Services.ServPerson.DeletePeople(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }
        }
    }
}