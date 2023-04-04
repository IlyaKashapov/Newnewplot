namespace Plot
{
    public partial class FuncForm : Form
    {
        public FuncForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Function.GetFunction(this.textBox1.Text))
            {
                label1.Text = Function.FuncRPN;
                label2.Text = "";
                for (int i = -5; i < 5; i ++) this.label2.Text += Function.FuncValue(i).ToString() + ";;;    ";
                label2.Text += Function.FuncValue(5).ToString();
                return;
            }
            else new Error().ShowDialog();
        }
    }
}
