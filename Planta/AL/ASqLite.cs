using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AL
{
    public class ASqLite
    {
        protected readonly static SQLiteAsyncConnection _database = new SQLiteAsyncConnection(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Save.db3"));

        public static void DropaDB()
        {
            _database.ExecuteAsync("drop table SAVE");
        }


        public static void CriaDb()
        {
        Task.Run(async() =>  _database.ExecuteAsync("create table if not exists SAVE(ID integer primary key autoincrement, Savenome text,Hp integer,HpMax integer,Sede integer,HorasNoSol integer,EstagioCrescimento integer," +
           "Seca integer,Morrendo integer,Morta integer,PegandoSol integer,Pontos integer,SemSedeConsecutivas integer,HorasNoSolConsecutivas integer,BasePontos integer,Solo integer, CicloFertilizante integer, Pulgoes integer,Acaros integer,CiclosEventualidade integer,Florescida integer,CicloFlorescimento integer)")).Wait();
        }
        //,Conchonilhas integer

        public static Task<List<ML.Dados>> RecuperaSaves() => _database.QueryAsync<ML.Dados>("select ID,Savenome,Hp,HpMax,Sede,HorasNoSol,EstagioCrescimento,Seca,Morrendo,Morta,PegandoSol,Pontos,SemSedeConsecutivas,HorasNoSolConsecutivas,BasePontos,Solo,CicloFertilizante,Pulgoes,Acaros,CiclosEventualidade,Florescida,CicloFlorescimento from SAVE");

        //,Conchonilhas

        public static Task<List<ML.Dados>> RecuperaSave(int id) => _database.QueryAsync<ML.Dados>($"select ID,Savenome,Hp,HpMax,Sede,HorasNoSol,EstagioCrescimento,Seca,Morrendo,Morta,PegandoSol,Pontos,SemSedeConsecutivas,HorasNoSolConsecutivas,BasePontos,Solo,CicloFertilizante,Pulgoes,Acaros,CiclosEventualidade,Florescida,CicloFlorescimento from SAVE where ID = '{id}'");

        //,Conchonilhas

        public static void DelSave(int Id) =>
            _database.ExecuteAsync($"delete from SAVE where ID = '{Id}'");

        public static void UpdtSave(ML.Dados dados) =>
           _database.ExecuteAsync($"update SAVE set Savenome = '{dados.Savenome}', Hp = '{dados.Hp}',HpMax='{dados.HpMax}',Sede='{dados.Sede}',HorasNoSol='{dados.HorasNoSol}',EstagioCrescimento = '{dados.EstagioCrescimento}',Seca = '{dados.Seca}'," +
               $"Morrendo='{dados.Morrendo}',Morta='{dados.Morta}',PegandoSol='{dados.PegandoSol}',Pontos='{dados.Pontos}',SemSedeConsecutivas='{dados.SemSedeConsecutivas}',HorasNoSolConsecutivas='{dados.HorasNoSolConsecutivas}',BasePontos='{dados.BasePontos}',Solo = '{dados.Solo}',CicloFertilizante='{dados.CicloFertilizante}',Pulgoes='{dados.Pulgoes}',Acaros='{dados.Acaros}',CiclosEventualidade ='{dados.CiclosEventualidade}',Florescida='{dados.Florescida}',CicloFlorescimento='{dados.CicloFlorescimento}' where ID = {dados.ID}");

        //,Conchonilhas='{dados.Conchonilhas}'

        public static async Task<int> CadSave(ML.Dados dados)
        {
            int resp = await _database.ExecuteAsync("insert into SAVE(Savenome,Hp,HpMax,Sede,HorasNoSol,EstagioCrescimento,Seca,Morrendo,Morta,PegandoSol,Pontos,SemSedeConsecutivas,HorasNoSolConsecutivas,BasePontos,Solo,CicloFertilizante,Pulgoes,Acaros,CiclosEventualidade,Florescida,CicloFlorescimento)" +
                $" values ('{dados.Savenome}','{dados.Hp}','{dados.HpMax}','{dados.Sede}','{dados.HorasNoSol}','{dados.EstagioCrescimento}','{dados.Seca}','{dados.Morrendo}','{dados.Morta}','{dados.PegandoSol}','{dados.Pontos}','{dados.SemSedeConsecutivas}','{dados.HorasNoSolConsecutivas}','{dados.BasePontos}','{dados.Solo}','{dados.CicloFertilizante}','{dados.Pulgoes}','{dados.Acaros}','{dados.CiclosEventualidade}','{dados.Florescida}','{dados.CicloFlorescimento}')");

            if (resp == 1)
            {
                var resp2 = await _database.ExecuteScalarAsync<int>("select last_insert_rowid()");
                return resp2;
            }
            else return 0;

        }
        //,Conchonilhas
        //,'{dados.Conchonilhas}'
    }
}
