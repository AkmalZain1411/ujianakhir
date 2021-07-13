using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<string> daftarPenjualan = new List<string>();
        static void Main(string[] args)
        {
            Sales oSales = new Sales(1);
            oSales.AddItem("Coca Cola", 3);
            oSales.AddItem("Sprite", 3);
            oSales.AddItem("Fanta", 5);
            oSales.RemoveLast();
            oSales.AddItem("Coca Cola", 5);
            oSales.AddItem("Fanta", 3);
            oSales.RemoveItem(new Sales.SalesItem() { Name = "Sprite" });
            oSales.RemoveItem(new Sales.SalesItem() { Name = "Sprite" });
            oSales.ShowItems();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            if (!Items.Contains(item))
            {
                Console.WriteLine("Item tidak ditemukan");
                return false;
            }
            Items.Remove(item);
            Console.WriteLine(item.Nama + " telah diremove");
            return true;
        }
        Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
