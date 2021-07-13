using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal

        public int ID { get; set; }
        public DateTime TanggalBeli { get; set; }
        public List<SalesItem> Items { get; private set; }

        public Sales(int newid)
        {
            this.ID = newid;
            TanggalBeli = DateTime.Now;
            Items = new List<SalesItem>();
        }
}
