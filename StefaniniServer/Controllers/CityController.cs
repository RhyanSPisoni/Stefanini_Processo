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
    [Route("City")]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public async Task<List<CityView>> SearchCities()
        {
            try
            {
                return await ServCity.SearchCities();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }

        }

        [HttpGet]
        [Route("Search")]
        public async Task<CityView> SearchListCity(int id)
        {
            try
            {
                return await ServCity.SearchListCity(id);
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
            try
            {
                return await ServCity.NewCities(city);
            }
            catch (System.Exception e)
            {

                throw new Exception($"Erro Interno : {e.Message}");
            }
        }

        [HttpPatch]
        [Route("Update")]
        public async Task<Confirmation> UpdateCities([FromBody] CidadeDTO city)
        {
            try
            {
                return await ServCity.UpdateCities(city);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<Confirmation> DeleteCities([FromRoute] int id)
        {
            try
            {
                return await ServCity.DeleteCities(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Erro Interno : {e.Message}");
            }
        }
    }
}