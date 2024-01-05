using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5. a. Viết chương trình xây dựng đối tượng CD gồm có các thuộc tính sau:
//o Mã CD là số nguyên,
//o Tựa CD: chuỗi ký tự,
//o Ca sỹ: chuỗi ký tự,
//o Số bài hát: số nguyên(>0)
//o Giá thành : số thực(>0)
//-Các thuộc tính khai báo private, định nghĩa các phương thức get/set cho từng thuộc tính.
//- Viết các constructor để khởi tạo đối tượng CD.
//- Override phương thức ToString của lớp Object.

namespace BT05
{
    class CD
    {
        //Khai bao  thanh phan du lieu
        private int macd;
        private string tuacd;
        private string casi;
        private int sobaihat;
        private int dongia;

        //Phuong thuc constructor
        public CD()
        {
        }
        public CD(int macd)
        {
            this.macd = macd;
        }
        public CD(int macd, string tuacd, string casi, int sobaihat, int dongia)
        {
            this.macd = macd;
            this.tuacd = tuacd;
            this.casi = casi;
            this.sobaihat = sobaihat;
            this.dongia = dongia;
        }
        //dinh nghia cac property
        public int MaCD
        {
            set { this.macd = value; }
            get { return macd; }
        }
        public string TuaCD
        {
            set { this.tuacd = value; }
            get { return tuacd; }
        }
        public string Casi
        {
            set { this.casi = value; }
            get { return casi; }
        }
        public int SoBaiHat
        {
            set { this.sobaihat = value; }
            get { return sobaihat; }
        }
        public int DonGia
        {
            set { this.dongia = value; }
            get { return dongia; }
        }
        public string ToString()
        {
            return string.Format("{0,10} {1,30} {2,30} {3,10} {4, 15:#,##0", macd, tuacd, casi, sobaihat, dongia);
        }
    }
}