using System.ComponentModel;

namespace Plot
{
    public partial class Form1 : Form
    {
        double min_x;
        double max_x = 10;
        double h = 0.1;
        int wdth;
        int hght;
        Pen pen = new Pen(Color.Black);
        Bitmap bm;
        Graphics g;
        public Form1()
        {
            InitializeComponent();



        }
        //int pix_in_one_x = 1;
        //Bitmap map = new Bitmap(100, 100);
        //Graphics g;
        private void Form1_Load(object sender, EventArgs e)
        {
            min_x = Convert.ToDouble(minx_dek.Text.Replace(',', '.'));
            max_x = Convert.ToDouble(maxx_dek.Text.Replace(',', '.'));
            hght = pic.Height;
            wdth = pic.Width;
            double pixels = wdth / (max_x - min_x);
            double len_y = hght / pixels;
            bm = new Bitmap(pic.Width, pic.Height); ;
            g = Graphics.FromImage(bm);

            g.Clear(Color.White);
            pic.Image = bm;
            
            g.DrawLine(pen, new Point(0, hght / 2), new Point(wdth, hght / 2));
            g.DrawLine(pen, new Point(Convert.ToInt32(Math.Abs(min_x) * pixels), 0), new Point(Convert.ToInt32(Math.Abs(min_x) * pixels), hght));

        }
        Koordinate Koord = new Koordinate(0, 0, 0, 0, 1, 1);
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {


            ekr_y.Text = e.Y.ToString();
            dek_y.Text = Koord.Convert_To_Y_dek(e.Y, miny_dek.Text, maxy_dek.Text, pic).ToString();
            ekr_x.Text = e.X.ToString();
            dek_x.Text = Koord.Convert_To_X_dek(e.X, minx_dek.Text, maxx_dek.Text, pic).ToString();


            //map.SetPixel(e.X, e.Y, Color.Black);
            //setpixel();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int step = 1;
            Function.GetFunction(textfunc.Text);
            for (int i = 0; i < wdth - step; i += step)
            {
                

                Koordinate k = new Koordinate();
                var x_dek = k.Convert_To_X_dek(i, minx_dek.Text, maxx_dek.Text, pic);
                var y = Convert.ToInt32(Function.FuncValue(x_dek));
                var x_dek_next = k.Convert_To_X_dek(i+step, minx_dek.Text, maxx_dek.Text, pic);
                var y_next = Convert.ToInt32(Function.FuncValue(x_dek_next));
                g.DrawLine(pen, new Point(k.Convert_To_X_ekr(x_dek, minx_dek.Text, maxx_dek.Text, pic), 
                           y), new Point(k.Convert_To_X_ekr(x_dek_next, minx_dek.Text, maxx_dek.Text, pic),
                           y_next));

            }

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }



        private void minx_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxx_dek_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        { if (textBox1.Text != "")
            {
                double x_dek = Convert.ToDouble(textBox1.Text);
                string minx = minx_dek.Text;
                string maxx = maxx_dek.Text;
                int x_ekr = Koord.Convert_To_X_ekr(x_dek, minx, maxx, pic);
                dek_y.Text = x_ekr.ToString();
            }
        }*/



    }
}


