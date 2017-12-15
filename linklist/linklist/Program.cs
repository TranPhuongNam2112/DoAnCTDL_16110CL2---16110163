using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCSharp
{
    public class SV
    {
        public string maSV { get; set; }
        public string hoTen { get; set; }
        public double diemNhapMon { get; set; }
        public double diemToanA1 { get; set; }
        public double diemToanA2 { get; set; }
        public double diemVatLy { get; set; }
        public double diemAnhVan { get; set; }
        public double diemTB { get; set; }
        public string xepLoai { get; set; }
        public SV(string maSV, string hoTen, double diemNhapMon, double diemToanA1, double diemToanA2,
            double diemVatLy, double diemAnhVan)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diemAnhVan = diemAnhVan;
            this.diemNhapMon = diemNhapMon;
            this.diemToanA1 = diemToanA1;
            this.diemToanA2 = diemToanA2;
            this.diemVatLy = diemVatLy;
            this.diemTB = TinhDienTB();
            this.xepLoai = XepLoai();
        }
        public double TinhDienTB()
        {
            return (diemAnhVan + diemNhapMon + diemToanA1 + diemToanA2 + diemVatLy) / 5;
        }
        public string XepLoai()
        {
            if (diemTB >= 8.0)
                return "Gioi";
            else if (diemTB >= 7.0)
                return "Kha";
            else if (diemTB >= 5.0)
                return "TB";
            else return "Yeu";
        }
    }
    public class Node
    {
        // Data
        public SV data { get; set; }
        public Node nextLink { get; set; }
        // Constructor 
        public Node(SV data)
        {
            this.data = data;
        }
    }
    public class LinkedList
    {
        // Data
        private Node head;
        private Node tail;
        //Constructor
        public LinkedList()
        {
            head = tail = null;
        }
        // Methods
        // Kiê?m tra rô~ng
        public bool IsEmpty
        {
            get
            {
                return head == null;
            }
        }
        #region "Insert Methods"
        // Thêm phâ`n tu? va`o dâ`u
        public void InsertFirst(SV data)
        {
            Node node = new Node(data);
            if (head == null)
                head = tail = node;
            else
            {
                node.nextLink = head;
                head = node;
            }
        }
        // Thêm phâ`n tu? va`o cuô´i
        public void InsertLast(SV data)
        {
            Node node = new Node(data);
            if (head == null)
                head = tail = node;
            else
            {
                tail.nextLink = node;
                tail = node;
            }
        }
        #endregion
        #region "Remove Methods"
        // Xo´a phâ`n tu? dâ`u
        public void RemoveFirst()
        {
            if (head == null)
                return;
            else
            {
                Node tam = head;
                head = tam.nextLink;
                tam = null;
                GC.Collect(); // Gia?i pho´ng vu`ng nho´
            }
        }
        // Xo´a phâ`n tu? cuô´i
        public void RemoveLast()
        {
            if (head == null)
                return;
            else
            {
                Node tam = tail;
                tail.nextLink = null;
                tam = null;
                GC.Collect();
            }
        }
        // Xo´a mô?t node co´ gia´ tri? bâ´t ki`
        public void RemoveNode(string value)
        {
            if (head.data.maSV == value)
            {
                RemoveFirst();
                return;
            }
            Node p = head;
            int t = 0;
            while (p != null)
            {
                t++;
                if (p.data.maSV == value)
                {
                    int h = 0;
                    for (Node q = head; q != p; q = q.nextLink)
                    {
                        h++;
                        if (h == t - 1)
                        {
                            q.nextLink = p.nextLink;
                            p = null;
                            GC.Collect();
                            return;
                        }
                    }
                    //Node a = p.previousLink, b = p.nextLink;
                    //a.nextLink = b;
                    //b.previousLink = a;
                    //p.nextLink = p.previousLink = null;
                    //p = null;
                    //GC.Collect();
                    //return;
                }
                p = p.nextLink;
            }

        }
        #endregion
        // Sort
        public void InterchangeSort()
        {
            for (Node p = head; p != tail; p = p.nextLink)
                for (Node q = p.nextLink; q != null; q = q.nextLink)
                    if (int.Parse(p.data.maSV) > int.Parse(q.data.maSV))
                    {
                        SV t = p.data;
                        p.data = q.data;
                        q.data = t;
                    }

        }
        // Print List
        public void PrintList( int n)
        {
            Node node = head;
            int i = 0;
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Ma so SV  ||    Ho va ten    ||  Diem AV || Diem Nhap Mon || Diem Toan A1 || Diem Toan A2 || Diem Vat Ly || Diem trung binh || Xep loai || ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");
            while (node != null)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("    {0}       ||       {1}      ||    {2}   ||     {3}       ||     {4}       ||     {5}     ||     {6}     ||      {7}       ||    {8}    ||", 
                    node.data.maSV, node.data.hoTen, node.data.diemAnhVan, node.data.diemNhapMon, node.data.diemToanA1,node.data.diemToanA2,node.data.diemVatLy,node.data.diemTB,node.data.xepLoai);
                Console.WriteLine("=============================================================================================================================================");
                i++;
                if (i >= n) break;
                node = node.nextLink;
            }

        }
    }
    class Program
    {
        public static LinkedList listSV = new LinkedList();
        //Tao Danh Sach SV
        public static void taoListSV()
        {
            listSV.InsertLast(new SV("1", "SV A", 6.7, 7.6, 3.4, 5.6, 6.6));
            listSV.InsertLast(new SV("2", "SV B", 7.4, 3.7, 5.2, 3.5, 6.4));
            listSV.InsertLast(new SV("3", "SV C", 7.1, 6.7, 4.3, 7.5, 8.4));
            listSV.InsertLast(new SV("4", "SV D", 5.6, 5.7, 5.3, 4.5, 7.4));
            listSV.InsertLast(new SV("5", "SV E", 9.1, 8.7, 8.3, 9.5, 8.4));
            listSV.InsertLast(new SV("6", "SV F", 6.1, 8.7, 5.3, 6.5, 5.4));
            listSV.InsertLast(new SV("7", "SV G", 6.2, 8.2, 5.2, 6.2, 5.2));
            listSV.InsertLast(new SV("8", "SV H", 6.3, 8.3, 5.3, 6.3, 5.3));
            listSV.InsertLast(new SV("9", "SV I", 6.4, 8.4, 5.4, 6.4, 5.4));
            listSV.InsertLast(new SV("10", "SV J", 6.5, 8.5, 5.5, 6.5, 5.5));
            listSV.InsertLast(new SV("11", "SV K", 6.5, 8.5, 5.5, 6.5, 5.6));
            listSV.InsertLast(new SV("12", "SV L", 6, 8, 5, 6, 5));
            listSV.InsertLast(new SV("13", "SV M", 6.6, 8.6, 5.6, 6.6, 5.46));
            listSV.InsertLast(new SV("14", "SV N", 6.9, 8.9, 5.9, 6.9, 5.9));
            listSV.InsertLast(new SV("15", "SV O", 6.1, 8.7, 5.3, 8.0, 5.9));
            listSV.InsertLast(new SV("16", "SV P", 6.5, 8.7, 5.3, 6.5, 5.4));
            listSV.InsertLast(new SV("17", "SV Q", 7, 8.7, 5.3, 6.5, 5.4));
            listSV.InsertLast(new SV("18", "SV R", 8.9, 8.6, 5.3, 6.5, 5.4));
            listSV.InsertLast(new SV("19", "SV S", 5.2, 7, 5.3, 6.5, 5.4));
            listSV.InsertLast(new SV("20", "SV T", 1.1, 3, 2, 5, 5));
        }
        public static void PrinListSV()
        {
            Console.Write("Chao mung cac ban den voi cuong trinh tim kiem Sinh Vien");
            Console.Write("\nNhap so luong sinh vien muon in ra man hinh: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n==========================================");
            listSV.PrintList( n);
        }
        static void Main(string[] args)
        {
            taoListSV();
            Console.WriteLine("Nhap vao so luong sinh vien muon in ra man hinh:");
            int n = int.Parse(Console.ReadLine());
            listSV.PrintList(n);
            //Bang lua chon
            Console.WriteLine("Chon 1 de xoa/Chon 2 de them");
            Console.WriteLine("Chon: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                //Xoa sinh vien theo MaSV 
                Console.WriteLine("Nhap STT can xoa: ");
                string canXoa = Console.ReadLine();
                listSV.RemoveNode(canXoa);
                n = n - 1;
                listSV.PrintList( n);
            }
            if (chon == 2)
            {
                //Them sinh vien
                Console.WriteLine("Nhap so Sv can them: ");
                string canThem = Console.ReadLine();
                SV svThem = new SV("10", "Ouip", 9.0, 9.0, 9.0, 9.0, 9.0);
                listSV.InsertLast(svThem);
                n = n + 1;
                listSV.PrintList( n);
            }
            //Sort
            listSV.InterchangeSort();   
            PrinListSV();

            Console.ReadKey();
        }
    }
}
