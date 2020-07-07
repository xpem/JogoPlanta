using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Verificacoes
    {
        //
        public bool TerraQualidade { get; set; }


        public static bool VerificaEventualidade(int eventualidade, int chance)
        {
            bool res = false;

            Task.Run(async () => res = await Verificacoes.GeraEventualidade(eventualidade, chance)).Wait();

            return res;
        }

        /// <summary>
        /// 1-pulgões 2-ácaros 3-conchonilhas
        /// </summary>
        /// <param name="eventualidade"></param>
        /// <returns></returns>
        public async static Task<bool> GeraEventualidade(int eventualidade, int chance)
        {
            Random random = new Random();
            //1 pulgões - 4%
            //2 ácaros - 4%
            //3 conchonilhas - 2%
            switch (eventualidade)
            {
                case 1: chance += 1; break;
                case 2: chance += 2; break;
                    //case 3: chance-=2; break;
            }

            int chancerepeticao = random.Next(1, 100);

            if (chancerepeticao < chance)
            {
                return true;
            }
            else return false;
        }
    }
}
