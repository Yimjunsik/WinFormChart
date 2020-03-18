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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'database1DataSet.Employee' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);
            this.chart1.Series[0].XValueMember = "Name";
            this.chart1.Series[0].YValueMembers = "Age";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.employeeTableAdapter.Update(this.database1DataSet.Employee);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.DataBind();
        }
    }
}
