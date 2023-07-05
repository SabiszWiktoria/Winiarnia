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
    /*
     *  var str = @"CREATE TABLE Koszyk (
                                Id             INT          NOT NULL,
                                IdProduktu          INT NOT NULL,
                                IloscP      INT NULL,
                                
                                PRIMARY KEY ([Id] ASC)
                                                            );"
     */
    class Koszyk
    {
        public SQLiteCommand cmd = BazaDanychcs.polaczenie.CreateCommand();  
        public List<Artykul> Artykuly { get; set; }
        public int Ilosc { get; set; }
        public int IdProduktu { get; set; }

        public Koszyk(List<Artykul> artykuly, int ilosc, int idProduktu)
        {

            Artykuly = artykuly;
            Ilosc = ilosc;
            IdProduktu = idProduktu;
        }
        public Koszyk()
        {

        }
        public int IloscRecordow()
        {
            BazaDanychcs.polaczenie.Open();
            
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT MAX(id) FROM [Koszyk]";
            var countResult = cmd.ExecuteScalar();
            int count = countResult is System.DBNull ? 0 : (int)(long)countResult;
            cmd.ExecuteNonQuery();
            BazaDanychcs.polaczenie.Close();
            return count + 1;
        }
        public void WyswietlanieTabeli2(ListView lista = null)
        {
            lista.Clear();
            cmd.CommandType = CommandType.Text;
            string zapytanie = $" SELECT * FROM [BazaWin] ";



            cmd.CommandText = zapytanie;

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
        public void WyswietlanieTabeli( ListView lista = null)
        {
            lista.Clear();
            cmd.CommandType = CommandType.Text;
            string zapytanie = $" SELECT * FROM Koszyk INNER JOIN BazaWin ON BazaWin.Id = Koszyk.IdProduktu ";
            

           
            cmd.CommandText =  zapytanie;

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
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["IloscP"].ToString()));
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
        public float Zlicz(ListView lista = null)
        {
            float cena = 0;
            float wynik = 0;
            int liczba = 0;
            for (int i = 0; i < lista.Items.Count; i++)
            {
                cena = float.Parse(lista.Items[i].SubItems[6].Text);
                liczba = int.Parse(lista.Items[i].SubItems[7].Text);
                wynik += cena * liczba;
            }
            return wynik;
        }
        public void UsuwanieDanych()
        {
            string zapytyanie = "DELETE FROM Koszyk";
            BazaDanychcs.polaczenie.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = zapytyanie;
           
            cmd.ExecuteNonQuery();
            BazaDanychcs.polaczenie.Close();
            
        }
        public void WyswietlanieTabeli1( int id, ListView lista = null)
        {
            lista.Clear();
            cmd.CommandType = CommandType.Text;
            string zapytanie = $" SELECT * FROM Koszyk INNER JOIN BazaWin ON BazaWin.Id = Koszyk.IdProduktu AND Koszyk.Id = "+id;



            cmd.CommandText = zapytanie;

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
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["IloscP"].ToString()));
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
        public bool CzyIstnieje()
        {

            bool czyIstniej;
            BazaDanychcs.polaczenie.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT COUNT(Id) FROM  [Koszyk] WHERE IdProduktu = {IdProduktu}";
            var countResult = cmd.ExecuteScalar();
            if ((int)(long)countResult != 0)
            {
                //istnieje 
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
        public void DodajDobazyDanych()
        {
            int id = IloscRecordow();
            if (CzyIstnieje())
            {
                MessageBox.Show($"Produkt znajduje sie w koszyku o id {IdProduktu}");
            }
            else
            {
                BazaDanychcs.polaczenie.Open();
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT INTO [Koszyk] (Id,IdProduktu,IloscP) VALUES" +
                    $" ({id},{IdProduktu},{Ilosc})";
                cmd.ExecuteNonQuery();
                BazaDanychcs.polaczenie.Close();
                MessageBox.Show("Dodano nowy artykul");
            }

        }
        public string ZapytaniaUsuwania(int id)
        {
            string zapytania = $" WHERE Id = " + id;
            return zapytania;
        }
        public void Usuwanie(int id)
        {
            BazaDanychcs.polaczenie.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DELETE FROM  [Koszyk] WHERE Id =" + id;
            cmd.ExecuteNonQuery();
            BazaDanychcs.polaczenie.Close();

        }
        public void ModyfikacjaTabeli(int id, int ilosc)
        {

            BazaDanychcs.polaczenie.Open();

            cmd.CommandType = CommandType.Text;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE [Koszyk] SET IloscP = {ilosc} WHERE Id=" + id;
            cmd.ExecuteNonQuery();


            BazaDanychcs.polaczenie.Close();


        }

    }
}
