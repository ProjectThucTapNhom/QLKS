﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKS;

using System.Data;

namespace QLKS
{
    public class DAL_PhieuThue
    {
         private KetNoiData connect = new KetNoiData();
        public DataTable ThongTinPhieuThue(string MaPhieu)
        {
            DataTable tb = connect.GetDataTable(@"select * from tblPhieuThue where MaPhieu = '" + MaPhieu + "'");
            return tb;
        }

        public void ThemThongTin(EC_PhieuThue EC_PT)
        {
            connect.ThucHienLenh(@"insert into tblPhieuThue values(N'" + EC_PT.MaPhieu + "', N'" + EC_PT.MaKH + "', N'" + EC_PT.MaPh + "',N'"+EC_PT.MaPT+"')" );
        }

        public void SuaThongTin(EC_PhieuThue EC_PT)
        {
            connect.ThucHienLenh(@"update tblPhieuThue set  MaKH = N'" + EC_PT.MaKH + "', MaPh = N'" + EC_PT.MaPh +  "'  where MaPhieu = '" + EC_PT.MaPhieu + "'");
        }

        public void XoaTTPhieuThue(EC_PhieuThue EC_PT)
        {
            connect.ThucHienLenh(@"delete from tblPhieuThue where MaPhieu = '" + EC_PT.MaPhieu + "'");
        }
      
    }
}
