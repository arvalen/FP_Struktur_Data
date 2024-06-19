using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_Struktur_Data.Pendaftaran_SIM
{

    public class Node
    {   
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(object data)
        {
            Data = data;
            Next = null;
        }

        public Node(object data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}
