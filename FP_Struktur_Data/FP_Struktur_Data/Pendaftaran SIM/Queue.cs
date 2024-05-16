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
        private List daftarAntrian;

        public Queue()
        {
            daftarAntrian = new List("Antrian");
        }

        public void Enqueue(object obj, int n)
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

        public object Dequeue()
        {
            return daftarAntrian.RemoveFirst();
        }

        public bool IsEmpty()
        {
            return daftarAntrian.IsEmpty();
        }

        public void Display()
        {
            daftarAntrian.Display();
        }

        public void Display(string no, string nama, string alamat, string jenisSIM, DateTime tanggalPendaftaran)
        {
            daftarAntrian.Display();
        }

    }
}
