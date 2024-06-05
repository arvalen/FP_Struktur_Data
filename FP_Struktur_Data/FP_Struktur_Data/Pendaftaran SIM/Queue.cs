using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP_SD.Pendaftaran_SIM;

namespace FP_Struktur_Data.Pendaftaran_SIM
{
    public class Queue
    {
        private DaftarAntrian daftarAntrian;

        public Queue()
        {
            daftarAntrian = new DaftarAntrian("Antrian");
        }

        public void Enqueue(object obj, int n)  // Method untuk menambahkan objek ke dalam antrian
        {
            if (n == 0)
            {
                daftarAntrian.AddLast(obj);
            }
            else
            {
                daftarAntrian.AddFirst(obj);
            }
        }

        public object Dequeue() // Method untuk menghapus dan mengembalikan objek dari depan antrian
        {
            return daftarAntrian.RemoveFirst();
        }

        public bool IsEmpty()   // Method untuk memeriksa apakah antrian kosong
        {
            return daftarAntrian.IsEmpty();
        }

        public void Display()   // Method untuk menampilkan daftar antrian
        {
            daftarAntrian.Display();
        }

        public void Display(string no, string nama, string alamat, string jenisSIM, DateTime tanggalPendaftaran)    // Method untuk menampilkan daftar antrian
        {
            daftarAntrian.Display();
        }

    }
}
