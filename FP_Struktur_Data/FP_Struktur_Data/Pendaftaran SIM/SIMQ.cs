using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP_Struktur_Data.Pendaftaran_SIM;

public class SIMQ
{   
    private int pilihan;    // Variabel untuk menyimpan pilihan menu pengguna
    private Queue sim = new Queue();    // Objek antrian untuk menyimpan pendaftar SIM
    private int counter = 1;    // Penghitung untuk nomor pendaftar
    private bool bersihkanTampilan = true;  // Status untuk membersihkan layar setelah setiap iterasi menu

    public void Run()   // Method untuk memulai program
    {
        do
        {   // Menampilkan menu dan meminta input pengguna
            TampilkanMenu();
            PilihMenu();
        } while (pilihan != 0);
    }

    private void TampilkanMenu()    // Method untuk menampilkan menu pada layar
    {
        if (bersihkanTampilan)
        {
            Console.Clear();// Membersihkan layar jika status bersihkanTampilan true

            // Menampilkan header SIMQ
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
        }
        // Menampilkan menu pilihan
        Console.WriteLine("\n=================================");
        Console.WriteLine(" || PENDAFTARAN PEMBUATAN SIM ||");
        Console.WriteLine("=================================");
        Console.WriteLine("Silahkan Pilih Menu:");
        Console.WriteLine("1. Pendaftaran");
        Console.WriteLine("2. Lihat Daftar Antrian");
        Console.WriteLine("3. Panggil Pendaftar");
        Console.WriteLine("0. Keluar");
        Console.Write("\nMasukkan Pilihan Menu: ");
    }

    private void PilihMenu()    // Method untuk memproses pilihan menu pengguna
    {
        while (true)
        {
            try
            {
                pilihan = Convert.ToInt32(Console.ReadLine());  // Mengkonversi input pengguna menjadi integer
                break;  // Jika konversi berhasil, keluar dari loop
            }
            catch (FormatException)
            {   // Menangani kesalahan format jika pengguna memasukkan selain angka
                Console.WriteLine("===Pilihan Menu Tidak Tersedia===");
                Console.WriteLine("Tekan sembarang tombol untuk melanjutkan.");
                Console.ReadKey();
                TampilkanMenu();    // Tampilkan kembali menu setelah pesan error
            }
        }

        switch (pilihan)     // Memproses pilihan menu pengguna
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
            case 0:
                Console.WriteLine("\n==========Keluar dari Program==========");
                return;
            default:
                Console.WriteLine("\n===Pilihan Menu Tidak Tersedia===");
                Console.WriteLine("Silahkan Masukkan Ulang Input Anda\n");
                break;  // Kembali ke loop untuk meminta input ulang

        }

        if (bersihkanTampilan)  // Menampilkan pesan untuk kembali ke menu jika status bersihkanTampilan true
        {
            Console.WriteLine("\nTekan sembarang tombol untuk kembali ke menu.");
            Console.ReadKey();
        }
    }


    private void Pendaftaran()  // Method untuk mendaftarkan pendaftar SIM
    {
        Console.WriteLine("\n=========================-Pendaftaran-========================");

        string no = counter.ToString("D4");  // Membuat nomor pendaftar dengan format D4 (misal: 0001, 0002, dst.)

        // Meminta input nama pendaftar 
        Console.Write("Masukkan Nama Pendaftar: ");
        string nama = Console.ReadLine();

        // Meminta input alamat pendaftar 
        Console.Write("Masukkan Alamat Pendaftar: ");
        string alamat = Console.ReadLine();

        string jenisSIM;
        // Memvalidasi input jenis SIM yang hanya boleh A, B, atau C
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

        // Mendapatkan tanggal dan waktu pendaftaran saat ini
        DateTime tanggalPendaftaran = DateTime.Now;

        // Membuat objek DataPendaftar dengan data yang dimasukkan
        DataPendaftar kartu = new DataPendaftar(no, nama, alamat, jenisSIM, tanggalPendaftaran);
        sim.Enqueue(kartu, 0);  // Menambahkan pendaftar ke dalam antrian SIM

        counter++;  // Menambahkan penghitung nomor pendaftar
    }

    private void DaftarAntrian()    // Method untuk menampilkan daftar antrian pendaftar SIM
    {
        Console.WriteLine("\n====================-Lihat Daftar Antrian-====================");
        Console.WriteLine("==============================================================");
        sim.Display();

    }

    private void KeluarAntrian()    // Method untuk memanggil pendaftar pertama dalam antrian SIM
    {
        Console.WriteLine("\nPanggil Pendaftar");
        Console.WriteLine("=================");

        if (sim.IsEmpty())  // Memeriksa apakah antrian kosong
        {
            Console.WriteLine("\nAntrian telah kosong");
        }
        else
        {
            object delData = sim.Dequeue(); // Menghapus dan mengembalikan pendaftar pertama dalam antrian

            // Menampilkan data pendaftar yang telah keluar dari antrian
            Console.WriteLine("|| No. || Nama || Alamat || Jenis SIM || Tanggal Pendaftaran ||");
            Console.WriteLine("==============================================================");
            Console.WriteLine($"{delData} telah keluar dari antrian\n");
        }
    }
}
