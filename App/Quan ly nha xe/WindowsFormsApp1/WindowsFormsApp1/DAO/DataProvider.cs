using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class DataProvider
    {   // Tao design pattern singleton
        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } 
        }

        private DataProvider() {}

        //xac dinh chuoi de ket noi toi dau
        private string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=Quanlynhaxe;Integrated Security=True";

        //tra ra nhung dong ket qua truy van
        public DataTable ExecuteQuery(string query, object[] para = null)
        {
            DataTable data = new DataTable();

            //Su dung using de giai phong bo nho 
            using (SqlConnection connection = new SqlConnection(conn)) //ket noi client toi server
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection); //cau truy van thuc thi 

                
                if(para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); //trung gian lay du lieu ra
                adapter.Fill(data); //Do du lieu lay ra len data va hien thi 
                connection.Close();
            }
            return data;
        }

        //tra ra so dong duoc thuc thi, ma so dong thuc thi la update, insert, delete
        //tra ra so dong thanh cong 
        public int ExecuteNonQuery(string query, object[] para = null)
        {
            int data = 0;

            //Su dung using de giai phong bo nho 
            using (SqlConnection connection = new SqlConnection(conn)) //ket noi client toi server
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection); //cau truy van thuc thi 


                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }


        //tra ra so luong dong
        public object ExecuteScalar(string query, object[] para = null)
        {
            object data = 0;

            //Su dung using de giai phong bo nho 
            using (SqlConnection connection = new SqlConnection(conn)) //ket noi client toi server
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection); //cau truy van thuc thi 


                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
