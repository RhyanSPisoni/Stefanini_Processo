using System.Linq;
using Microsoft.EntityFrameworkCore;
using StefaniniServer.Data;
using StefaniniServer.DTO;
using StefaniniServer.Models;
using StefaniniServer.Views;

namespace StefaniniServer.Services
{
    public class ServPessoa
    {
        internal async static Task<List<PessoaView>> SearchPeople()
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    return await Db.Pessoas
                                .AsNoTracking()
                                .Select(x => new PessoaView
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

        internal async static Task<Confirmation> NewPeople(List<Pessoa> pessoa)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
                    pessoa.ForEach(e =>
                    {
                        Db.Pessoas.AddAsync(e);
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

        internal static async Task<Confirmation> UpdatePeople(PessoaDTO pessoa)
        {
            try
            {
                await using (var Db = new devStefaniniContext())
                {
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