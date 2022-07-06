using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StefaniniServer.Data;
using StefaniniServer.DTO;
using StefaniniServer.Models;
using StefaniniServer.Views;

namespace StefaniniServer.Services
{
    public class ServPerson
    {
        internal static async Task<List<PersonView>> SearchPeople()
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    return await Db.Pessoas
                                .AsNoTracking()
                                .Select(x => new PersonView
                                {
                                    Id = x.Id,
                                    Nome = x.Nome,
                                    Cpf = x.Cpf,
                                    Cidade = x.IdCidadeNavigation.Nome,
                                    Idade = x.Idade
                                })
                                .ToListAsync();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        internal static async Task<List<PersonView>> SearchListPeople(int id)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    return await Db.Pessoas
                                .AsNoTracking()
                                .Select(x => new PersonView
                                {
                                    Id = x.Id,
                                    Nome = x.Nome,
                                    Cpf = x.Cpf,
                                    Cidade = x.IdCidadeNavigation.Nome,
                                    Idade = x.Idade
                                })
                                .Where(x => x.Id == id)
                                .ToListAsync();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        internal static async Task<Confirmation> NewPeople(Pessoa person)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    await Db.Pessoas.AddAsync(person);

                    await Db.SaveChangesAsync();
                }

                return new Confirmation();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        internal static async Task<Confirmation> UpdatePeople(PessoaDTO person)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    Db.Pessoas.Update(new Pessoa
                    {
                        Id = person.Id,
                        Nome = person.Nome,
                        Cpf = person.Cpf,
                        IdCidade = person.IdCidade,
                        Idade = person.Idade
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

        internal static async Task<Confirmation> DeletePeople(int id)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    var person = Db.Pessoas.FirstOrDefault(x => x.Id == id);

                    if (person != null)
                    {
                        Db.Pessoas.Remove(person);
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