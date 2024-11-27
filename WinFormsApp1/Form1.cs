namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("�Թ�յ�͹�Ѻ", "First Message");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("��ͧ��ûԴ��ԧ�������", "��㨹�",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            // input �Ѻ��Ҩҡ Textbox
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRadius.Text);
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", " Error !!");
                txtRadius.Focus();  //����� Cursor ��� Textbox
                txtRadius.SelectAll(); //��� Selected    -hv8;k,.o Textbox
                return;
            }
            // proscess �ӹǳ��鹷��
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ����� PI
            //Math.Pow(x,y)  x ¡���ѧ y

            // output ���͡��ʴ���
            lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            double Width = 0;
            if (double.TryParse(txtWidth.Text, out Width) == false)
            {
                MessageBox.Show("���������١��ͧ", " Error!!!");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            double w = 0, h = 0, sum = 0;
            //�ŧ��� ��ͤ����繵���Ţ
            w = Convert.ToInt32(txtWidth.Text);
            h = Convert.ToInt32(txtHeight.Text);
            sum = 0.5 * w * h;
            // ����ʴ��ŷ�� lblResult
            lblResult.Text = sum.ToString();

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnPolygonArea_Click(object sender, EventArgs e)
        {
            double PolygonArea = 0;
            if (double.TryParse(txtPolygonWidth.Text, out PolygonArea) == false)
            {
                MessageBox.Show("���������١��ͧ", " Error!!!");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            // �ӹǳ �ҡ���3��ô���4 * ��ҹ ���ѧ2 * 6
            double HexagonArea = Math.Sqrt(3) / 4 * Math.Pow(PolygonArea, 2) * 6;

            //����ʴ��ŷ�� lblResult
            lblResult.Text = HexagonArea.ToString();
        }
    }
}
