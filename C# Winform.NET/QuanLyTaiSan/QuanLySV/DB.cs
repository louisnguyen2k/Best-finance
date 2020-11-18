using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLySV
{
    //  Class DB: chứa đối tượng connection tới DataBase
    /*
    // @conn_str: string connection tới server DataBase: "ADMIN"; tên CSDL: "QUANLYSV"; Trạng thái mở: "SSPI"
    // @conn: đối tượng connect tới DB
    */
    class DB
    {
        private static string conn_str = @"Data Source = ADMIN;
                                            Initial Catalog = QUANLYTAISAN;
                                            Integrated Security = SSPI;";
        public static SqlConnection conn = new SqlConnection(conn_str);
    }
}
