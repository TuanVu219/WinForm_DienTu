﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Dientu
{
     class Function
    {
        public static SqlConnection con;
        string strCon = @"SERVER= TUANVU; Database= Dientu; User Id = sa; pwd=khongcopass123;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public static void Connect()
        {
            con=new SqlConnection();
            string strCon = @"SERVER= TUANVU; Database= Dientu; User Id = sa; pwd=khongcopass123;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
           

            try
            {
                con=new SqlConnection(strCon);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Disconnect
        public static void Disconnect()
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con=null;

            }
           
        }
        // Phương thức thực thi câu lệnh lấy dữ liệu
        public static DataTable GetDataToTable(string sql)
        {
            DataTable table=new DataTable();
          
                SqlDataAdapter dap = new SqlDataAdapter(sql,con);
                dap.Fill(table);
            
            
            return table;
        }
        // Phương thức thực thi câu lệnh Insert,Update,Delete
        public static void RunSQL(string sql)
        {
           
                SqlCommand cmd;
                cmd = new SqlCommand();
                cmd.Connection= con;
                cmd.CommandText= sql;
                try
                {
                    cmd.ExecuteNonQuery(); // thực thi câu lệnh SQL nhưng ko truy vấn
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmd.Dispose();
                cmd=null;
            
        }
        // Hàm kiểm tra khóa trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();  
            dap.Fill(table);
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }
     public static void FillCombo(string sql,ComboBox cbo,string ma,string ten) {
        SqlDataAdapter dap=new SqlDataAdapter(sql,con);
        DataTable table = new DataTable();
        dap.Fill(table);    
        cbo.DataSource= table;
        cbo.ValueMember=ma; // Trường giá trị
        cbo.DisplayMember=ten;// trường hiển thị
     }
    public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        //123 => một trăm hai ba đồng
        //1,123,000=>một triệu một trăm hai ba nghìn đồng
        //1,123,345,000 => một tỉ một trăm hai ba triệu ba trăm bốn lăm ngàn đồng
        static string[] mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
        //Viết hàm chuyển số hàng chục, giá trị truyền vào là số cần chuyển và một biến đọc phần lẻ hay không ví dụ 101 => một trăm lẻ một
        private static string DocHangChuc(double so, bool daydu)
        {
            string chuoi = "";
            //Hàm để lấy số hàng chục ví dụ 21/10 = 2
            Int64 chuc = Convert.ToInt64(Math.Floor((double)(so / 10)));
            //Lấy số hàng đơn vị bằng phép chia 21 % 10 = 1
            Int64 donvi = (Int64)so%10;
            //Nếu số hàng chục tồn tại tức >=20
            if (chuc>1)
            {
                chuoi = " " + mNumText[chuc] + " mươi";
                if (donvi==1)
                {
                    chuoi += " mốt";
                }
            }
            else if (chuc==1)
            {//Số hàng chục từ 10-19
                chuoi = " mười";
                if (donvi==1)
                {
                    chuoi += " một";
                }
            }
            else if (daydu && donvi>0)
            {//Nếu hàng đơn vị khác 0 và có các số hàng trăm ví dụ 101 => thì biến daydu = true => và sẽ đọc một trăm lẻ một
                chuoi = " lẻ";
            }
            if (donvi==5 && chuc>=1)
            {//Nếu đơn vị là số 5 và có hàng chục thì chuỗi sẽ là " lăm" chứ không phải là " năm"
                chuoi += " lăm";
            }
            else if (donvi>1||(donvi==1&&chuc==0))
            {
                chuoi += " " + mNumText[donvi];
            }
            return chuoi;
        }
        private static string DocHangTram(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng trăm ví du 434 / 100 = 4 (hàm Floor sẽ làm tròn số nguyên bé nhất)
            Int64 tram = Convert.ToInt64(Math.Floor((double)so/100));
            //Lấy phần còn lại của hàng trăm 434 % 100 = 34 (dư 34)
            so = so%100;
            if (daydu || tram>0)
            {
                chuoi = " " + mNumText[tram] + " trăm";
                chuoi += DocHangChuc(so, true);
            }
            else
            {
                chuoi = DocHangChuc(so, false);
            }
            return chuoi;
        }
        private static string DocHangTrieu(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng triệu
            Int64 trieu = Convert.ToInt64(Math.Floor((double)so/1000000));
            //Lấy phần dư sau số hàng triệu ví dụ 2,123,000 => so = 123,000
            so = so%1000000;
            if (trieu>0)
            {
                chuoi = DocHangTram(trieu, daydu) + " triệu";
                daydu = true;
            }
            //Lấy số hàng nghìn
            Int64 nghin = Convert.ToInt64(Math.Floor((double)so / 1000));
            //Lấy phần dư sau số hàng nghin 
            so = so%1000;
            if (nghin>0)
            {
                chuoi += DocHangTram(nghin, daydu) + " nghìn";
                daydu = true;
            }
            if (so>0)
            {
                chuoi += DocHangTram(so, daydu);
            }
            return chuoi;
        }
        public static string ChuyenSoSangChuoi(double so)
        {
            if (so == 0)
                return mNumText[0];
            string chuoi = "", hauto = "";
            Int64 ty;
            do
            {
                //Lấy số hàng tỷ
                ty = Convert.ToInt64(Math.Floor((double)so / 1000000000));
                //Lấy phần dư sau số hàng tỷ
                so = so % 1000000000;
                if (ty > 0)
                {
                    chuoi = DocHangTrieu(so, true) + hauto + chuoi;
                }
                else
                {
                    chuoi = DocHangTrieu(so, false) + hauto + chuoi;
                }
                hauto = " tỷ";
            } while (ty > 0);
            return chuoi + " đồng";
        }
    
    public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay=DateTime.Now.ToShortDateString().Split('/');
            string d = string.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key=key+d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            if (partsTime[2].Substring(3, 2)=="PM")
            {
                partsTime[0]=ConvertTimeTo24(partsTime[0]);
            }
            if (partsTime[2].Substring(3, 2)=="AM")
            {
                if (partsTime[0].Length==1)
                    partsTime[0]="0"+partsTime[0];
            }
            partsTime[2]=partsTime[2].Remove(3, 2);
            string t;
            t=string.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key=key+t;
            return key;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
    }
}
