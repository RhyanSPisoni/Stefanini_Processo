using System;
using Microsoft.AspNetCore.Mvc;
using StefaniniServer.DTO;
using StefaniniServer.Models;
using StefaniniServer.Views;

namespace StefaniniServer.Controllers
{
    [ApiController]
    [Route("People")]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public async Task<List<PessoaView>> SearchPeople()
        {
            try
            {
                return await Services.ServPessoa.SearchPeople();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpGet]
        [Route("Search")]
        public async Task<List<PessoaView>> SearchListPeople(List<int> ids)
        {
            try
            {
                return await Services.ServPessoa.SearchListPeople(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpPost]
        [Route("New")]
        public async Task<Confirmation> NewPeople([FromBody] List<Pessoa> pessoa)
        {
            try
            {
                return await Services.ServPessoa.NewPeople(pessoa);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpPatch]
        [Route("Update")]
        public async Task<Confirmation> UpdatePeople([FromBody] PessoaDTO pessoa)
        {
            try
            {
                return await Services.ServPessoa.UpdatePeople(pessoa);
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
                return await Services.ServPessoa.DeletePeople(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }
        }
    }
}