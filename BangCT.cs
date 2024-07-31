using System.Windows.Forms;
using System.Xml;

namespace CSharp_BANGCT
{
    public partial class BangCT : Form
    {
        public BangCT()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btlthanhtoan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!double.TryParse(txtstartNum.Text, out _))
            {
                errorProvider1.SetError(txtstartNum, " Phải nhập số thập phân");
                return;
            }
            if (!double.TryParse(txtendNum.Text, out _))
            {
                errorProvider1.SetError(txtendNum, " Phải nhập số thập phân");
                return;
            }
            if (String.IsNullOrEmpty(txtstartNum.Text))
            {
                errorProvider1.SetError(txtstartNum, " Phải nhập giá trị vào ô này");
                return;
            }
            if (String.IsNullOrEmpty(txtendNum.Text))
            {
                errorProvider1.SetError(txtendNum, " Phải nhập giá trị vào ô này");
                return;
            }
            double startNum = Convert.ToDouble(txtstartNum.Text);
            double endNum = Convert.ToDouble(txtendNum.Text);
            double totalNum = 0, powerNum = 1, totalchan = 0, totalLe = 0;
            for (double i = startNum; i <= endNum; i++)
            {
                totalNum += i;
                powerNum *= i;
                if (i % 2 == 0)
                {
                    // Tổng chẵn
                    totalchan += i;
                }
                else
                {
                    // Tổng lẻ
                    totalLe += i;
                }
            }
            txttotalNum.Text = totalNum.ToString();
            txtpowerNum.Text = powerNum.ToString();
            txttotalChan.Text = totalchan.ToString();
            txttotalLe.Text = totalLe.ToString();



        }

        private void txttotalNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

