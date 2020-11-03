using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTraSua.DTO
{
    public class Bill
    {
        public Bill(DateTime? ngayvao, DateTime? ngayra, int id, int trangthai)
        {

            this.Ngayvao = ngayvao;
            this.Ngayra = ngayra;
            this.ID = id;
            this.Trangthai = trangthai;
        }
        public Bill(DataRow row)
        {


            this.Ngayvao = (DateTime?)row["ngayvao"];

            var ngayraTemp = row["ngayra"];
            if (ngayraTemp.ToString() != "")
                this.Ngayra = (DateTime?)ngayraTemp;
            this.ID = (int)row["id"];

            this.Trangthai = (int)row["trangthai"];

        }


        private int trangthai;
        private DateTime? ngayvao;
        private DateTime? ngayra;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public DateTime? Ngayra { get => ngayra; set => ngayra = value; }
        public DateTime? Ngayvao { get => ngayvao; set => ngayvao = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
