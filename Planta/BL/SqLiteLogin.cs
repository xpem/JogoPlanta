using ML;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace BL
{
    public class SqLiteLogin
    {

        public static void DropaDB() =>
         AL.ASqLite.DropaDB();


        public static void CriaBD() =>
          AL.ASqLite.CriaDb();

        public static int CadSave(ML.Dados dados)
        {
           int res = new int();
          
            Task.Run( async() => res = await AL.ASqLite.CadSave(dados)).Wait();

            return res;
        }

        public static void UptSave(ML.Dados dados) =>
   AL.ASqLite.UpdtSave(dados);

        public static void DelSave(int id) =>
       AL.ASqLite.DelSave(id);

        public static List<SaveItem> RecSaves()
        {
            List<ML.Dados> res = new List<ML.Dados>();
            List<SaveItem> saves = new List<SaveItem>();

            Task.Run(async () => res = await AL.ASqLite.RecuperaSaves()).Wait();

            foreach (ML.Dados save in res)
            {
                saves.Add(new ML.SaveItem() { Id = save.ID, Savenome = save.Savenome, Status = RetornaSituacao(save.Hp, save.HpMax),EstagioCrescimento = save.EstagioCrescimento.ToString(), Hp = save.Hp.ToString() });
            }

            return saves;
        }

        public static ML.Dados RecDados(int id)
        {
            List<ML.Dados> dado = new List<ML.Dados>();

            Task.Run(async () => dado = await AL.ASqLite.RecuperaSave(id)).Wait();
            return dado[0];
        }


        public static string RetornaSituacao(int Hp, int HpMax)
        {
            if (Hp > HpMax)
            {
                return "Radiante";
            }
            else if (Hp < (HpMax - 80))
            {
                return "Morta";
            }
            else if (Hp < (HpMax - 40))
            {
                return "Fraca";
            }
            else if (Hp < (HpMax - 30))
            {
                return "Triste";

            }
            else if (Hp < (HpMax - 20))
            {
                return "Feliz";
            }
            else return "";
        }
    }
}
