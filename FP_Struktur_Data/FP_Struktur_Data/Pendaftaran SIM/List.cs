using System;
using FP_Struktur_Data.Pendaftaran_SIM;


namespace FP_SD.Pendaftaran_SIM
{
    public class List
    {
        public Node First { get; private set; }
        public Node Last { get; private set; }
        public string No { get; private set; }
        public string Nama { get; private set; }
        public string Alamat { get; private set; }

        public List()
        {
            this.No = "List";
            this.First = this.Last = null;
        }

        public List(string namaList)
        {
            this.No = namaList;
            this.First = this.Last = null;
        }

        public void AddFirst(object data)
        {
            if (IsEmpty())
            {
                this.First = this.Last = new Node(data);
            }
            else
            {
                this.First = new Node(data, this.First);
            }
        }

        public void AddLast(object data)
        {
            if (IsEmpty())
            {
                this.First = this.Last = new Node(data);
            }
            else
            {
                this.Last = this.Last.Next = new Node(data);
            }
        }

        public object RemoveFirst()
        {
            object itemRemove = null;
            if (!IsEmpty())
            {
                itemRemove = this.First.Data;
                if (this.First == this.Last)
                {
                    this.First = this.Last = null;
                }
                else
                {
                    this.First = this.First.Next;
                }
            }
            return itemRemove;
        }

        public bool IsEmpty()
        {
            return this.First == null;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("\nAntrian kosong\n");
                return;
            }
            Console.WriteLine("========================Urutan Antrian========================");
            Console.WriteLine("|| No. || Nama || Alamat || Jenis SIM || Tanggal Pendaftaran ||");
            Console.WriteLine("==============================================================");
            Node now = this.First;
            while (now != null)
            {
                Console.WriteLine($"{now.Data}");
                now = now.Next;
            }
            Console.WriteLine("\n");
        }

    }
}
