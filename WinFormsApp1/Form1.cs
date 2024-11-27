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
            MessageBox.Show("ยินดีต้อนรับ", "First Message");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดจริงหรือไม่", "แน่ใจนะ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            // input รับค่าจาก Textbox
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRadius.Text);
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", " Error !!");
                txtRadius.Focus();  //ให้มี Cursor ที่ Textbox
                txtRadius.SelectAll(); //ให้ Selected    -hv8;k,.o Textbox
                return;
            }
            // proscess คำนวณพื้นที่
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ให้ค่า PI
            //Math.Pow(x,y)  x ยกกำลัง y

            // output นำออกไปแสดงผล
            lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            double Width = 0;
            if (double.TryParse(txtWidth.Text, out Width) == false)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", " Error!!!");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            double w = 0, h = 0, sum = 0;
            //แปลงค่า ข้อความเป็นตัวเลข
            w = Convert.ToInt32(txtWidth.Text);
            h = Convert.ToInt32(txtHeight.Text);
            sum = 0.5 * w * h;
            // นำไปแสดงผลที่ lblResult
            lblResult.Text = sum.ToString();

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnPolygonArea_Click(object sender, EventArgs e)
        {
            double PolygonArea = 0;
            if (double.TryParse(txtPolygonWidth.Text, out PolygonArea) == false)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", " Error!!!");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            // คำนวณ รากที่3หารด้วย4 * ด้าน กำลัง2 * 6
            double HexagonArea = Math.Sqrt(3) / 4 * Math.Pow(PolygonArea, 2) * 6;

            //นำไปแสดงผลที่ lblResult
            lblResult.Text = HexagonArea.ToString();
        }
    }
}
