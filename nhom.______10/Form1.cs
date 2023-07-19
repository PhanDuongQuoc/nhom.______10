using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom.______10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string masv = txtmnv.Text;
            string tensv=txttennv.Text;
            float diem = float.Parse(txtdiem.Text);
            string khoa=txtkhoa.Text;
            themsinhvien(masv, tensv, diem,khoa);
            MessageBox.Show("Thêm thành công !");
        }
        private string connnection = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLsinhvien1;Integrated Security=True";
        BindingSource bs = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connnection);
            if (sqlConnection == null) 
            {
                sqlConnection = new SqlConnection(connnection);
            }
            SqlDataAdapter adapter = new SqlDataAdapter("select *from SINHVIEN", sqlConnection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dt = new DataSet();
            adapter.Fill(dt, "SINHVIEN");
            bs = new BindingSource(dt, "SINHVIEN");
            txtmnv.DataBindings.Add("text", bs, "MASV");
            txttennv.DataBindings.Add("text", bs, "TENSV");
            txtdiem.DataBindings.Add("text", bs, "DIEM");
            txtkhoa.DataBindings.Add("text", bs, "MAK");


        }

        private void btnquaphai_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
            {
                bs.Position++;
            }
        }

        private void btnquatrai_Click(object sender, EventArgs e)
        {
            if (bs.Position > 0) 
            {
                bs.Position--;
            }
        }

        public void themsinhvien(string MASV,string TENSV,float DIEM,string MAK) 
        {
            SqlConnection sqlConnection = new SqlConnection(connnection);
            string query = "insert into SINHVIEN(MASV,TENSV,DIEM,MAK) values(@MASV,@TENSV,@DIEM,@MAK)";
            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
            sqlCommand.Parameters.Add("@MASV", MASV);
            sqlCommand.Parameters.Add("@TENSV", TENSV);
            sqlCommand.Parameters.Add("@DIEM", DIEM);
            sqlCommand.Parameters.Add("@MAK", MAK);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
           

        }


        void xoa(string ma)
        {
            /*qlConnection conn = new SqlConnection(connnection);
            string query = "delete from SINHVIEN where MASV=@ma";
            SqlCommand sqlCommand = new SqlCommand( query,conn);
            sqlCommand.CommandType= CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = conn;*/
            using (SqlConnection conn = new SqlConnection(connnection))
            {
                string query = "DELETE FROM SINHVIEN WHERE MASV = @ma";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
        }
            private void btnxoa_Click(object sender, EventArgs e)
            {
                string ma = txtmnv.Text;
                xoa(ma);
            MessageBox.Show("xóa thành công !");
           

            }

            private void btnvedau_Click(object sender, EventArgs e)
            {
                bs.Position = 0;
            }

            private void btnvecuoi_Click(object sender, EventArgs e)
            {
                bs.Position = bs.Count - 1;
            }
        }
}
