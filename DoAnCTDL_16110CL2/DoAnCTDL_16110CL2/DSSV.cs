using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL_16110CL2
{
    public class DSSV
    {
        public NODE pHead, cur, pTail, node;
        public class NODE
        {
            public NODE pNext;
            public string MaSV;
            public string TenSV;
            public string Gioi;
            public string Khoa;
            public string Lop;
            public double Diem1;
            public double Diem2;
            public double Diem3;
            public double DTB;
        }
    }
}
