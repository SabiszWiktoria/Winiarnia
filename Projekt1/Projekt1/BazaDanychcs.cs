using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.SQLite;


namespace Projekt1
{
    public class BazaDanychcs
    {
        private static SQLiteConnection _polaczenie;

        public static SQLiteConnection polaczenie
        {
            get
            {
                if (_polaczenie == null)
                {
                    var sciezka = Path.GetFullPath($@"{Environment.CurrentDirectory}\..\..\BazaDanych.sqlite");// zwaraca obecna sciezke do bazy danych 
                    _polaczenie = new SQLiteConnection($@"Data Source={sciezka};");


                    StworzTabele1();
                   
                }
                return _polaczenie;
            }
        }

        private static void StworzTabele1()
        {
            try
            {
                _polaczenie.Open();

                var sprawdzCzyIstniejeTabela = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='BazaWin';", _polaczenie);
                var czyIstnieje = sprawdzCzyIstniejeTabela.ExecuteScalar();

                if (czyIstnieje == null)
                {

                    var str = @"CREATE TABLE BazaWin (
                                Id             INT          NOT NULL,
                                Marka          VARCHAR (50) NULL,
                                Rocznik        INT NULL,
                                Smak         VARCHAR (50) NULL,
                                Odmiana          VARCHAR (50) NULL,
                                GdzieWyprodukowano     VARCHAR (20) NULL,
                                Cena    float (2)   NULL,
                                Ilosc      INT NULL,
                                Ocena  INT NULL,
                                PRIMARY KEY ([Id] ASC)
                                                            );";

                    var stworzTabele = new SQLiteCommand(str, _polaczenie);
                    stworzTabele.ExecuteNonQuery();
                }
                sprawdzCzyIstniejeTabela = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='Koszyk';", _polaczenie);
                czyIstnieje = sprawdzCzyIstniejeTabela.ExecuteScalar();
                if (czyIstnieje == null)
                {

                    var str = @"CREATE TABLE Koszyk (
                                Id             INT          NOT NULL,
                                IdProduktu          INT NOT NULL,
                                IloscP      INT NULL,
                              
                                
                                PRIMARY KEY ([Id] ASC)
                                                            );";

                    var stworzTabele = new SQLiteCommand(str, _polaczenie);
                    stworzTabele.ExecuteNonQuery();

                }
            }


            finally
            {
                _polaczenie.Close();
            }


        }
        
    }

}

