using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class CD
    {
        private int MaCD;
        private string TuaCD;
        private string casi;
        private int Sobaihat;
        private int Giathanh;


        public CD()
        {

        }
        public CD(int MaCD)
        {
            this.MaCD = MaCD;
        }
        public CD(int MaCD, string TuaCD, string casi, int Sobaihat, int Giathanh)
        {
            this.MaCD = MaCD;
            this.TuaCD = TuaCD;
            this.casi = casi;
            this.Sobaihat = Sobaihat;
            this.Giathanh = Giathanh;
        }
        public int macd
        {
            get { return MaCD; }
            set { this.MaCD = value; }
        }
        public string tuaCD
        {
            get { return TuaCD; }
            set { this.TuaCD = value; }
        }
        public string Casi
        {
            get { return casi; }
            set { this.casi = value; }
        }
        public int sobaihat
        {
            get { return Sobaihat; }
            set { this.Sobaihat = value; }

        }
        public int giathanh
        {
            get {return Giathanh; }
            set { this.Giathanh = value; }
        }
        public string ToString()
        {
            return string.Format("{0,20} {1,30} {2,25} {3,20} {4,20:#,##0}", macd, tuaCD, casi, sobaihat, giathanh);
        }
    }
}
