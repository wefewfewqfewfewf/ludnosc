using WinFormsApp12.ModelDanych;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        Pobieracz pobieracz;
        public Form1()
        {
            InitializeComponent();
            pobieracz = new Pobieracz();
            pobieracz.PobierzDanezBazy();
        }
        public void PokazDane()
        {
            richTextBox1.Clear();
            foreach (Osoba osoba in pobieracz.listaOsob)
                richTextBox1.Text += osoba.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pobieracz.listaOsob.Sort();
            PokazDane();
        }
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(444, 424);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(637, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private RichTextBox richTextBox1;
        private Button button1;

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}