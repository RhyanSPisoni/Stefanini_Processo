using System;

namespace StefaniniServer.Validators
{
    public class ValidatorGeneral
    {
        public static void ValidatorNullString(string text)
        {
            if (text.Length < 1)
                throw new Exception("Foi informado nenhum dado para essa ação");

        }
    }
}