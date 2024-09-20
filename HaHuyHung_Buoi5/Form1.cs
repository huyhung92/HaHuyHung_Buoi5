namespace HaHuyHung_Buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Sinhvien>li_sv = new List<Sinhvien>();
        private void btnnhap_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien(txthoten.Text, txtgioitinh.Text, txtngaysinh.Value, txtmssv.Text, txtnganhhoc.Text, Convert.ToDouble(txtdtb.Text));
            li_sv.Add(sv);
            DGV1.DataSource = null;
            DGV1.DataSource = li_sv;            
        }
    }
}
