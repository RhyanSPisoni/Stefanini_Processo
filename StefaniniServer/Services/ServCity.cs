using System.Linq;
using Microsoft.EntityFrameworkCore;
using StefaniniServer.Data;
using StefaniniServer.DTO;
using StefaniniServer.Models;
using StefaniniServer.Views;

namespace StefaniniServer.Services
{
    public class ServCity
    {
        internal async static Task<List<CityView>> SearchCities()
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

        internal async static Task<List<CityView>> SearchListCities(List<int> ids)
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
                                .Where(x => ids.Contains(x.Id))
                                .ToListAsync();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        internal async static Task<Confirmation> NewCities(List<Cidade> cities)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    cities.ForEach(e =>
                    {
                        Db.Cidades.AddAsync(e);
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