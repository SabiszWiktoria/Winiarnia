using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Projekt1
{

    public class Artykul
    {
        public SQLiteCommand cmd = BazaDanychcs.polaczenie.CreateCommand();
        public string Marka { get; set; }
        public string Rocznik { get; set; }
        public odmiana Odmiana { get; set; }
        public smak Smak { get; set; }
        public string GdzieWyprodukowano { get; set; }
        public string Cena { get; set; }
        public int Ilosc { get; set; }
        public int Ocena { get; set; }
        public Artykul()
        {

        }
        public Artykul(string marka, string rocznik, odmiana odmiana, smak smak, string gdzieWyprodukowano, string cena, int ilosc, int ocena)
        {
            Marka = marka;
            Rocznik = rocznik;
            Odmiana = odmiana;
            Smak = smak;
            GdzieWyprodukowano = gdzieWyprodukowano;
            Cena = cena;
            Ilosc = ilosc;
            Ocena = ocena;
        }
        public int IloscRecordow()
        {
            BazaDanychcs.polaczenie.Open();
            // var cmd = BazaDanych.polaczenie.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT MAX(id) FROM [BazaWin]";
            var countResult = cmd.ExecuteScalar();
            int count = countResult is System.DBNull ? 0 : (int)(long)countResult;
            cmd.ExecuteNonQuery();
            BazaDanychcs.polaczenie.Close();
            return count + 1;
        }
        public void DodajDobazyDanych()
        {
            int id = IloscRecordow();
            if (CzyIstnieje())
            {
                MessageBox.Show($"Produkt o marce: '{Marka}', smaku: '{Smak}', roczniku:'{Rocznik}', i  odmianie='{Odmiana}. Istnieje juz w bazie danych");
            }
            else
            {
                BazaDanychcs.polaczenie.Open();
                // var cmd = BazaDanych.polaczenie.CreateCommand();
              
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT INTO [BazaWin] (Id,Marka,Rocznik, Smak ,Odmiana ,GdzieWyprodukowano ,Cena ,Ilosc ,Ocena) VALUES" +
                    $" ({id},'{Marka}','{Rocznik}','{Smak}','{Odmiana}','{GdzieWyprodukowano}',{Cena},{Ilosc},{Ocena})";
                cmd.ExecuteNonQuery();
                BazaDanychcs.polaczenie.Close();
                MessageBox.Show("Dodano nowy artykul");
            }

        }
        public string ZapytaniaUsuwania(int id)
        {
            string zapytania = $" WHERE Id=" + id;
            return zapytania;
        }
        public void Usuwanie(int id)
        {
            BazaDanychcs.polaczenie.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DELETE FROM  [BazaWin] WHERE Id = {id}";
            cmd.ExecuteNonQuery();
            BazaDanychcs.polaczenie.Close();

        }
        public void ModyfikacjaTabeli(int id, string nazwaPola, string pole)
        {

            BazaDanychcs.polaczenie.Open();
         
            cmd.CommandType = CommandType.Text;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE [BazaWin] SET {nazwaPola} = '" + pole + "' WHERE Id=" + id;
            cmd.ExecuteNonQuery();


            BazaDanychcs.polaczenie.Close();


        }
        public bool CzyIstnieje()
        {

            bool czyIstniej;
            BazaDanychcs.polaczenie.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT COUNT(Id) FROM  [BazaWin] WHERE Marka = '{Marka}' AND Smak='{Smak}' AND Rocznik='{Rocznik}' AND Odmiana='{Odmiana}'";
            var countResult = cmd.ExecuteScalar();
            if ((int)(long)countResult != 0)
            {
                //istnieje taki film
                czyIstniej = true;
            }
            else
            {
                czyIstniej = false;
            }
            cmd.ExecuteNonQuery();
            BazaDanychcs.polaczenie.Close();
            return czyIstniej;

        }
        public string WyszukiwaniePoParametrach(string cenaOd, string cenaDo, string sortujWedlug, string sortuj, Artykul a)
        {


            string zapytanie = "WHERE ";
            if (Marka != "")
            {
                zapytanie += $"Marka LIKE '%{Marka}%' AND ";
            }
            if (Rocznik != "    ")
            {
                zapytanie += $"Rocznik LIKE '%{Rocznik}%' AND ";
            }
            if (Odmiana.ToString() != "-1")
            {
                zapytanie += $"Odmiana LIKE '{Odmiana}' AND ";
            }
            if (Smak.ToString() != "-1")
            {
                zapytanie += $"Smak LIKE '{Smak}' AND ";
            }
            if (GdzieWyprodukowano != "")
            {
                zapytanie += $"GdzieWyprodukowano LIKE '%{GdzieWyprodukowano}%' AND ";
            }
            if (cenaOd != "0")
            {
                
                zapytanie += $"Cena>={cenaOd} AND ";
            }
            if (cenaDo != "0")
            {
                zapytanie += $"Cena<={cenaDo} AND ";
            }


            if (zapytanie == "WHERE ")
            {
                zapytanie = " AND";
            }
            int pocztek = (int)(zapytanie.Length) - 4;

            zapytanie = zapytanie.Remove(pocztek, 4);
            if (sortujWedlug != "")
            {
                zapytanie += $" ORDER BY {sortujWedlug} " + sortuj;
            }

            return zapytanie;

        }
        public void WyswietlanieTabeli(string zapytanie, ListView lista = null)
        {

            lista.Clear();
           
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM [BazaWin]  " + zapytanie;

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
                try
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lista.View = View.Details;


                    lista.Columns.Add("Id");
                    lista.Columns.Add("Marka                       ");
                    lista.Columns.Add("Rocznik     ");
                    lista.Columns.Add("Smak         ");
                    lista.Columns.Add("Odmiana    ");
                    lista.Columns.Add("Miejsce produkcji                           ");
                    lista.Columns.Add("Cena           ");
                    lista.Columns.Add("Ilosc      ");
                    lista.Columns.Add("Ocena    ");

                    lista.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                    lista.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    foreach (DataRow row in dt.Rows)
                    {

                        ListViewItem item1 = new ListViewItem(row["Id"].ToString());
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Marka"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Rocznik"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Smak"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Odmiana"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["GdzieWyprodukowano"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Cena"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Ilosc"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Ocena"].ToString()));

                        lista.Items.Add(item1);


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("bywa" + ex);
                }
                
            }
        }
    }
}

