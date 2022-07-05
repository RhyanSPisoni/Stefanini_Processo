using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StefaniniServer.Data;
using StefaniniServer.DTO;
using StefaniniServer.Models;
using StefaniniServer.Validators;
using StefaniniServer.Views;

namespace StefaniniServer.Services
{
    public class ServCity
    {
        internal static async Task<List<CityView>> SearchCities()
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    return await Db.Cidades
                                .AsNoTracking()
                                .Select(x => new CityView
                                {
                                    Id = x.Id,
                                    Nome = x.Nome,
                                    Uf = x.Uf
                                })
                                .ToListAsync();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        internal static async Task<CityView> SearchListCity(int id)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    return await Db.Cidades
                                .AsNoTracking()
                                .Select(x => new CityView
                                {
                                    Id = x.Id,
                                    Nome = x.Nome,
                                    Uf = x.Uf
                                })
                                .FirstOrDefaultAsync();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static async Task<Confirmation> NewCities(Cidade city)
        {
            try
            {
                ValidatorGeneral.ValidatorNullString(city.Nome);

                await using (var Db = new devStefaniniContext())
                {
                    await Db.Cidades.AddAsync(city);

                    await Db.SaveChangesAsync();
                }

                return new Confirmation();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir uma nova Cidade");
            }
        }

        internal static async Task<Confirmation> UpdateCities(CidadeDTO city)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    Db.Cidades.Update(new Cidade
                    {
                        Id = city.Id,
                        Nome = city.Nome,
                        Uf = city.Uf
                    });

                    await Db.SaveChangesAsync();
                    return new Confirmation();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        internal static async Task<Confirmation> DeleteCities(int id)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    var city = Db.Cidades.FirstOrDefault(x => x.Id == id);

                    if (city != null)
                    {
                        Db.Cidades.Remove(city);
                        Db.SaveChanges();
                    }

                    return new Confirmation();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}