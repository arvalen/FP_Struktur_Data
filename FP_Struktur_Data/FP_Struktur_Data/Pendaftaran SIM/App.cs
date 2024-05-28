using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP_Struktur_Data.Pendaftaran_SIM;

public class App
{
    private int pilihan;
    private Queue sim = new Queue();
    private int counter = 1;

    public void Run()
    {
        do
        {
            Console.WriteLine(" .----------------.  .----------------.  .----------------.  .----------------. ");
            Console.WriteLine("| .--------------. || .--------------. || .--------------. || .--------------. |");
            Console.WriteLine("| |    _______   | || |     _____    | || | ____    ____ | || |    ___       | |");
            Console.WriteLine("| |   /  ___  |  | || |    |_   _|   | || ||_   \\  /   _|| || |  .'   '.     | |");
            Console.WriteLine("| |  |  (__ \\_|  | || |      | |     | || |  |   \\/   |  | || | /  .-.  \\    | |");
            Console.WriteLine("| |   '.___`-.   | || |      | |     | || |  | |\\  /| |  | || | | |   | |    | |");
            Console.WriteLine("| |  |`\\____) |  | || |     _| |_    | || | _| |_\\/_| |_ | || | \\  `-'  \\_   | |");
            Console.WriteLine("| |  |_______.'  | || |    |_____|   | || ||_____||_____|| || |  `.___.\\__|  | |");
            Console.WriteLine("| |              | || |              | || |              | || |              | |");
            Console.WriteLine("| '--------------' || '--------------' || '--------------' || '--------------' |");
            Console.WriteLine(" '----------------'  '----------------'  '----------------'  '----------------' ");

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
        Console.WriteLine("\n=========================-Pendaftaran-========================");

        string no = counter.ToString("D4"); 

        Console.Write("Masukkan Nama Pendaftar: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan Alamat Pendaftar: ");
        string alamat = Console.ReadLine();

        string jenisSIM;
        while (true)
        {
            Console.Write("Masukkan Jenis SIM (A/B/C): ");
            jenisSIM = Console.ReadLine().ToUpper();
            if (jenisSIM == "A" || jenisSIM == "B" || jenisSIM == "C")
            {
                break;
            }
            else
            {
                Console.WriteLine("Jenis SIM tidak valid. Masukkan hanya A, B, atau C.");
            }
        }

        DateTime tanggalPendaftaran = DateTime.Now;

        DataPendaftar kartu = new DataPendaftar(no, nama, alamat, jenisSIM, tanggalPendaftaran);
        sim.Enqueue(kartu, 0);

        counter++;
    }

    private void DaftarAntrian()
    {
        Console.WriteLine("\n====================-Lihat Daftar Antrian-====================");
        Console.WriteLine("==============================================================");
        sim.Display();

    }

    private void KeluarAntrian()
    {
        Console.WriteLine("\nPanggil Pendaftar");
        Console.WriteLine("=================");
        if (sim.IsEmpty())
        {
            Console.WriteLine("\nAntrian telah kosong");
        }
        else
        {
            object delData = sim.Dequeue();
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
