using System;

namespace ML
{
    public class Dados
    {

        public int ID { get; set; }
        public string Savenome { get; set; }

        public int Hp { get; set; }
        public int HpMax { get; set; }
        public int Sede { get; set; }

        public int HorasNoSol { get; set; }

        /// <summary>
        ///  1=muda, 2=brotopequeno, 3=brotomedio
        /// </summary>
        public int EstagioCrescimento { get; set; }

        public bool Seca { get; set; }

        public bool Morrendo { get; set; }

        public bool Morta { get; set; }

        public bool PegandoSol { get; set; }

        public int Pontos { get; set; }

        public int SemSedeConsecutivas { get; set; }

        public int HorasNoSolConsecutivas { get; set; }

        public int BasePontos { get; set; }

        public int Solo { get; set; }

      public int  CiclosEventualidade{get;set;}

        public int CicloFertilizante { get; set; }

        public int CicloFlorescimento { get; set; }

        public bool Florescida { get; set; }
        public bool Pulgoes { get; set; }
        public bool Acaros { get; set; }
        //public bool Conchonilhas { get; set; }

    }

    public class SaveItem
    {
        public int Id { get; set; }

        public string Savenome { get; set; }

        public string Hp { get; set; }

        public string EstagioCrescimento { get; set; }

        public string Status { get; set; }
    }



}
