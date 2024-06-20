

	

 .----------------.  .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. || .--------------. |
| |    _______   | || |     _____    | || | ____    ____ | || |    ___       | |
| |   /  ___  |  | || |    |_   _|   | || ||_   \  /   _|| || |  .'   '.     | |
| |  |  (__ \_|  | || |      | |     | || |  |   \/   |  | || | /  .-.  \    | |
| |   '.___`-.   | || |      | |     | || |  | |\  /| |  | || | | |   | |    | |
| |  |`\____) |  | || |     _| |_    | || | _| |_\/_| |_ | || | \  `-'  \_   | |
| |  |_______.'  | || |    |_____|   | || ||_____||_____|| || |  `.___.\__|  | |
| |              | || |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------' 


## LinkedList
- **Dalam Kelas DaftarAntrian:**
  - Variabel `First` dan `Last` digunakan untuk menunjukkan node pertama dan terakhir dalam linked list, yang menandakan ujung depan dan belakang dari antrian.
  - Metode `AddFirst` dan `AddLast` digunakan untuk menambahkan elemen ke depan dan belakang linked list, sesuai dengan operasi enqueue pada queue.
  - Metode `RemoveFirst` digunakan untuk menghapus dan mengembalikan elemen pertama dari linked list, sesuai dengan operasi dequeue pada queue.
  - Metode `IsEmpty` digunakan untuk memeriksa apakah linked list kosong, yang berguna untuk memeriksa apakah antrian kosong.

## Queue
- **Dalam Kelas Queue:**
  - Metode `Enqueue` digunakan untuk menambahkan objek ke dalam antrian. Terdapat pengecekan untuk menentukan apakah objek harus ditambahkan ke ujung depan atau belakang antrian.
  - Metode `Dequeue` digunakan untuk menghapus dan mengembalikan objek dari depan antrian, diimplementasikan menggunakan metode `RemoveFirst` dari kelas `DaftarAntrian`.
  - Metode `IsEmpty` digunakan untuk memeriksa apakah antrian kosong, menggunakan metode `IsEmpty` dari kelas `DaftarAntrian`.
  - Metode `Display` digunakan untuk menampilkan semua elemen dalam antrian, menggunakan metode `Display` dari kelas `DaftarAntrian`.
  
  
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
  - `Enqueue(object obj, int n)`: Memasukkan objek ke dalam antrian, menggunakan metode AddLast atau AddFirst.
  - `Dequeue()`: Menghapus dan mengembalikan objek dari depan antrian.
  - `IsEmpty()`: Memeriksa apakah antrian kosong.
  - `Display()`: Menampilkan semua elemen dalam antrian.

## Class DataPendaftar
- **Properties:**
  - `No`: Nomor pendaftar.
  - `Nama`: Nama pendaftar.
  - `Alamat`: Alamat pendaftar.
  - `JenisSIM`: Jenis SIM yang didaftarkan.
  - `TanggalPendaftaran`: Tanggal pendaftaran.
- **Methods:**
  - `DataPendaftar(string no, string nama, string alamat, string jenisSIM, DateTime tanggalPendaftaran)`: Konstruktor untuk inisialisasi data pendaftar.
  - `ToString()`: Representasi string dari objek DataPendaftar.

## Class DaftarAntrian
- **Properties:**
  - `First`: Node pertama dalam linked list antrian.
  - `Last`: Node terakhir dalam linked list antrian.
  - `No`: Nomor antrian.
  - `Nama`: Nama antrian.
- **Methods:**
  - `DaftarAntrian()`: Konstruktor untuk inisialisasi antrian kosong.
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
  - `TampilkanMenu()`: Menampilkan menu pada layar.
  - `PilihMenu()`: Memproses pilihan menu pengguna.
  - `Pendaftaran()`: Meminta data pendaftar dan menambahkannya ke dalam antrian.
  - `DaftarAntrian()`: Menampilkan daftar pendaftar dalam antrian.
  - `KeluarAntrian()`: Memanggil pendaftar pertama dalam antrian.

## Class Program
- **Method Main()**: Memulai program dengan membuat objek SIMQ dan menjalankan program.
