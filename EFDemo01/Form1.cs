using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFDemo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string conStr = string.Format("server=188.188.1.208;uid=Goods_Test;pwd=Goods_123456;database=BJR-WMS-V3");
            SqlConnection sqlConn = new SqlConnection(conStr);
            sqlConn.Open();

            string sqlStr = "SELECT * FROM [BCL_Goods]";
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter(sqlStr, sqlConn);
            dapter.Fill(table);
            this.dgv.DataSource = table;

            sqlConn.Close();
        }
    }
}
