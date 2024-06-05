# Struktur Data yang Digunakan dalam SIMQ

## LinkedList
- **Dalam Kelas DaftarAntrian:**
  - Variabel `First` dan `Last` digunakan untuk menunjukkan node pertama dan terakhir dalam linked list, yang mengindikasikan ujung depan dan belakang dari antrian.
  - Metode `AddFirst` dan `AddLast` digunakan untuk menambahkan elemen ke depan dan belakang linked list, yang sesuai dengan operasi enqueue dari queue.
  - Metode `RemoveFirst` digunakan untuk menghapus dan mengembalikan elemen pertama dari linked list, yang sesuai dengan operasi dequeue dari queue.
  - Metode `IsEmpty` digunakan untuk memeriksa apakah linked list kosong, yang dapat digunakan untuk memeriksa apakah antrian kosong.

## Queue
- **Dalam Kelas Queue:**
  - Objek `daftarAntrian` digunakan sebagai representasi dari antrian, yang sebenarnya adalah sebuah objek dari kelas DaftarAntrian.
  - Metode `Enqueue` digunakan untuk menambahkan objek ke dalam antrian. Terdapat logika untuk menentukan apakah objek ditambahkan ke ujung depan atau belakang antrian, bergantung pada parameter `n`.
  - Metode `Dequeue` digunakan untuk menghapus dan mengembalikan objek dari depan antrian, yang diimplementasikan dengan menggunakan metode `RemoveFirst` dari kelas `DaftarAntrian`.
  - Metode `IsEmpty` digunakan untuk memeriksa apakah antrian kosong, yang mengandalkan metode `IsEmpty` dari kelas `DaftarAntrian`.
  - Metode `Display` digunakan untuk menampilkan seluruh elemen dalam antrian, yang menggunakan metode `Display` dari kelas `DaftarAntrian`.

Jadi, linked list dan queue diimplementasikan dalam kelas DaftarAntrian untuk merepresentasikan antrian pendaftar SIM dan dalam kelas Queue untuk menyediakan antarmuka operasional bagi antrian tersebut.

## Class Node
- **Properties:**
  - `Data`: Objek untuk menyimpan data.
  - `Next`: Node berikutnya dalam linked list.
- **Methods:**
  - `Node(object data)`: Konstruktor untuk inisialisasi Node dengan data.
  - `Node(object data, Node next)`: Konstruktor untuk inisialisasi Node dengan data dan Node berikutnya.

## Class Queue
- **Fields:**
  - `daftarAntrian`: Objek DaftarAntrian untuk menyimpan data dalam antrian.
- **Methods:**
  - `Enqueue(object obj, int n)`: Memasukkan objek ke dalam antrian, menggunakan metode AddLast atau AddFirst berdasarkan nilai n.
  - `Dequeue()`: Menghapus dan mengembalikan objek dari depan antrian.
  - `IsEmpty()`: Memeriksa apakah antrian kosong.
  - `Display()`: Menampilkan semua elemen dalam antrian.
  - `Display(string no, string nama, string alamat, string jenisSIM, DateTime tanggalPendaftaran)`: Metode yang belum digunakan (tidak ada implementasi).

## Class DataPendaftar
- **Properties:**
  - `No`: Nomor pendaftar.
  - `Nama`: Nama pendaftar.
  - `Alamat`: Alamat pendaftar.
  - `JenisSIM`: Jenis SIM yang didaftarkan.
  - `TanggalPendaftaran`: Tanggal pendaftaran.
- **Methods:**
  - `DataPendaftar(string no, string nama, string alamat, string jenisSIM, DateTime tanggalPendaftaran)`: Konstruktor untuk inisialisasi data pendaftar.
  - `GetNama()`: Mengembalikan nama pendaftar.
  - `ToString()`: Representasi string dari objek DataPendaftar.

## Class DaftarAntrian
- **Properties:**
  - `First`: Node pertama dalam linked list antrian.
  - `Last`: Node terakhir dalam linked list antrian.
  - `No`: Nomor antrian.
  - `Nama`: Nama antrian.
- **Methods:**
  - `DaftarAntrian()`: Konstruktor untuk inisialisasi antrian kosong.
  - `DaftarAntrian(string namaList)`: Konstruktor untuk inisialisasi antrian dengan nama tertentu.
  - `AddFirst(object data)`: Menambahkan elemen ke depan antrian.
  - `AddLast(object data)`: Menambahkan elemen ke belakang antrian.
  - `RemoveFirst()`: Menghapus dan mengembalikan elemen pertama dari antrian.
  - `IsEmpty()`: Memeriksa apakah antrian kosong.
  - `Display()`: Menampilkan semua elemen dalam antrian.

## Class SIMQ
- **Fields:**
  - `pilihan`: Pilihan menu pengguna.
  - `sim`: Objek antrian untuk menyimpan pendaftar SIM.
  - `counter`: Penghitung untuk nomor pendaftar.
  - `bersihkanTampilan`: Status untuk membersihkan layar setelah setiap iterasi menu.
- **Methods:**
  - `Run()`: Memulai program dengan menampilkan menu dan meminta input pengguna.
  - `TampilkanMenu()`: Menampilkan menu pada layar.
  - `PilihMenu()`: Memproses pilihan menu pengguna.
  - `Pendaftaran()`: Meminta data pendaftar dan menambahkannya ke dalam antrian.
  - `DaftarAntrian()`: Menampilkan daftar pendaftar dalam antrian.
  - `KeluarAntrian()`: Memanggil pendaftar pertama dalam antrian.

## Class Program
- **Method Main()**: Memulai program dengan membuat objek SIMQ dan menjalankan program.
