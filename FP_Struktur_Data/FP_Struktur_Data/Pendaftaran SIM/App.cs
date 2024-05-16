using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP_Struktur_Data.Pendaftaran_SIM;

public class App
{
    private int pilihan;
    private Queue ktp = new Queue();

    public void Run()
    {
        do
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine(" || PENDAFTARAN PEMBUATAN SIM ||");
            Console.WriteLine("=================================");
            Console.WriteLine("Silahkan Pilih Menu:");
            Console.WriteLine("1. Pendaftaran");
            Console.WriteLine("2. Lihat Daftar Antrian");
            Console.WriteLine("3. Panggil Pendaftar");
            Console.WriteLine("0. Keluar");
            Console.Write("\nMasukkan Pilihan Menu: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Pendaftaran();
                    break;
                case 2:
                    DaftarAntrian();
                    break;
                case 3:
                    KeluarAntrian();
                    break;
                default:
                    InvalidMenu();
                    break;
            }
        } while (pilihan != 0);
    }

    private void Pendaftaran()
    {
        Console.WriteLine("\n====Pendaftaran====");
        Console.Write("Masukkan No. Pendaftar: ");
        string no = Console.ReadLine();

        Console.Write("Masukkan Nama Pendaftar: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan Alamat Pendaftar: ");
        string alamat = Console.ReadLine();

        Console.Write("Masukkan Jenis SIM (A/B/C): : ");
        string jenisSIM = Console.ReadLine();

        Console.Write("Masukkan Tanggal Pendaftaran (dd/MM/yyyy): ");
        DateTime tanggalPendaftaran = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        DataPendaftar kartu = new DataPendaftar(no, nama, alamat, jenisSIM, tanggalPendaftaran);
        ktp.Enqueue(kartu, 0);
    }

    private void DaftarAntrian()
    {
        Console.WriteLine("\nLihat Daftar Antrian");
        Console.WriteLine("====================");
        ktp.Display();

    }

    private void KeluarAntrian()
    {
        Console.WriteLine("\nPanggil Pendaftar");
        Console.WriteLine("=================");
        if (ktp.IsEmpty())
        {
            Console.WriteLine("\nAntrian telah kosong");
        }
        else
        {
            object delData = ktp.Dequeue();
            Console.WriteLine("|| No. || Nama || Alamat || Jenis SIM || Tanggal Pendaftaran ||");
            Console.WriteLine("==============================================================");
            Console.WriteLine($"{delData} telah keluar dari antrian\n");
        }
    }

    private void InvalidMenu()
    {
        if (pilihan == 0)
        {
            Console.WriteLine("\n==========Keluar dari Program==========");
        }
        else
        {
            Console.WriteLine("===Pilihan Menu Tidak Tersedia===");
            Console.WriteLine("Silahkan Masukkan Ulang Input Anda\n");
        }
    }
}
