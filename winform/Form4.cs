using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class Form4 : Form
    {
        private object[] data;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(object[] data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Chỉ cần gọi phương thức ShowData trong Form4_Load
            tbMakh.Text = data[0].ToString();
            tbTenkh.Text = data[1].ToString();
            tbMahd.Text = data[2].ToString();
            tbTenhh.Text = data[3].ToString();
            tbLoaihh.Text = data[4].ToString();
            tbDongia.Text = data[5].ToString();
            tbSoluong.Text = data[6].ToString();
            tbTongtien.Text = data[7].ToString();
        }
        
    }
}
