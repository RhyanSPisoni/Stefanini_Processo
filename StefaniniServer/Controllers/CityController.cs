using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StefaniniServer.DTO;
using StefaniniServer.Models;
using StefaniniServer.Views;

namespace StefaniniServer.Controllers
{
    [ApiController]
    [Route("Cities")]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public async Task<List<CityView>> SearchCities()
        {
            try
            {
                return await Services.ServCity.SearchCities();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpGet]
        [Route("Search")]
        public async Task<List<CityView>> SearchListCities(List<int> ids)
        {
            try
            {
                return await Services.ServCity.SearchListCities(ids);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpPost]
        [Route("New")]
        public async Task<Confirmation> NewCities([FromBody] Cidade city)
        {

            return await Services.ServCity.NewCities(city);


        }

        [HttpPatch]
        [Route("Update")]
        public async Task<Confirmation> UpdateCities([FromBody] CidadeDTO city)
        {
            try
            {
                return await Services.ServCity.UpdateCities(city);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<Confirmation> DeleteCities(int id)
        {
            try
            {
                return await Services.ServCity.DeleteCities(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }
        }
    }
}