using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Struktur_Data.Pendaftaran_SIM
{
    public class DataPendaftar
    {   // Properties untuk data pendaftar
        private string No { get; set; }
        private string Nama { get; set; }
        private string Alamat { get; set; }
        private string JenisSIM { get; set; }
        private DateTime TanggalPendaftaran { get; set; }

        // Konstruktor untuk inisialisasi data pendaftar// Konstruktor untuk inisialisasi data pendaftar
        public DataPendaftar(string no, string nama, string alamat, string jenisSIM, DateTime tanggalPendaftaran)
        {
            this.No = no;
            this.Nama = nama;
            this.Alamat = alamat;
            this.JenisSIM = jenisSIM;
            this.TanggalPendaftaran = tanggalPendaftaran;
        }

        // Method untuk mendapatkan nama pendaftar
        public string GetNama()
        {
            return Nama;
        }

        public override string ToString()    // Override method ToString untuk representasi string dari objek DataPendaftar
        {
            return string.Format("  {0}   {1}   {2}   {3}   {4}\n", No, Nama, Alamat, JenisSIM, TanggalPendaftaran.ToString("dd/MM/yyyy HH:mm:ss"));
        }
    }
}
