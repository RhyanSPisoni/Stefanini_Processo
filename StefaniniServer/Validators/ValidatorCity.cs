using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StefaniniServer.Data;
using StefaniniServer.Views;

namespace StefaniniServer.Validators
{
    public class ValidatorCity
    {
        public static async void ValidatorDuplicateCity(string city)
        {
            await using (var Db = new devStefaniniContext())
            {
                var res = await Db.Cidades
                            .AsNoTracking()
                            .Where(x => x.Nome.Trim().ToUpper() == city.Trim().ToUpper())
                            .ToListAsync();

                if (res.Count >= 1)
                    throw new Exception("Essa cidade já foi registrada!");
            }
        }
    }
}