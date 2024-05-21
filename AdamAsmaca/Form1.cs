using System.Drawing.Text;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox.ImageLocation = @"..\..\..\Images\adamasmaca.png";
            pictureBox.Load();
            LabelEkle();
            ButonEkle();


        }

        private string secilenKelime;
        private Label[] labels;
        private int say = 0;

        private void LabelEkle()
        {
            
            string[] kelimeler = new string[] { "TÜRKÝYE", "AMERÝKA", "RUSYA", "UGANDA", "KENYA", "ÝSPANYA", "ÇÝN", "KORE", "JAPONYA", "ÝTALYA", "UKRAYNA", "SOMALÝ" };
            Random rnd = new Random();
            secilenKelime = kelimeler[rnd.Next(kelimeler.Length)];
            Label lblBilgi = new Label();
            labels = new Label[secilenKelime.Length];
            int x=300, y=170;

            for ( int i=0; i<secilenKelime.Length; i++ ) 
            {
                Label lbl = new Label();
                lbl.Name = "lbl_" + secilenKelime[i];
                lbl.Text = "_";
                lbl.Font= new Font("Arial",25,FontStyle.Bold);
                lbl.Size = new Size(40, 40);
                lbl.Location = new Point(x,y);
                this.Controls.Add(lbl);
                labels[i] = lbl;
                x += 40;

            }
        }
        private void ButonEkle()
        {
            string[] harfler = new string[] { "A", "B", "C", "Ç", "D", "E", "F","G","Ð","H","I","Ý","J","K","L","M","N","O","Ö","P","R","S","Þ","T","U","Ü","V","Y","Z"};
            
            int x = 0, y = 0;
            for (int i = 0; i < harfler.Length; i++)
            { 
                Button btn = new Button();
                btn.Name = "btn_" + harfler[i];
                btn.Text = harfler[i];
                btn.Size = new Size(40, 40);
                btn.Click += new EventHandler(button_Click);

               if (i%5==0)
               {
                    x = 40; y += 40;
               }
               else { x += 40; }
                btn.Location = new Point(x, y);
                this.Controls.Add(btn);

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;    
            bool buldunMu=false;

            if (say <= 6)
            {
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (btn.Text == secilenKelime[i].ToString())
                    {
                        labels[i].Text = btn.Text;
                        buldunMu= true;
                    }
                }
            }
            else 
            { 
                DialogResult result= MessageBox.Show("Oyunu Kaybettiniz!!!!", "Game Over", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                { }
                else if (result == DialogResult.No)
                { }
                else if (result == DialogResult.Cancel)
                { }
            }
            if (buldunMu == false)
            { 
                say++;
                AdamAs();
            }
        }

        private void AdamAs()
        {
            switch (say)
            {
                case 1:
                    pictureBox.ImageLocation = @"..\..\..\Images\adamasmaca1.png";
                    pictureBox.Load();
                    break;
                case 2:
                    pictureBox.ImageLocation = @"..\..\..\Images\adamasmaca2.png";
                    pictureBox.Load();
                    break ;
                case 3:
                    pictureBox.ImageLocation = @"..\..\..\Images\adamasmaca3.png";
                    pictureBox.Load();
                    break;
                case 4:
                    pictureBox.ImageLocation = @"..\..\..\Images\adamasmaca4.png";
                    pictureBox.Load();
                    break;
                case 5:
                    pictureBox.ImageLocation = @"..\..\..\Images\adamasmaca5.png";
                    pictureBox.Load();
                    break;
                case 6:
                    pictureBox.ImageLocation = @"..\..\..\Images\adamasmaca6.png";
                    pictureBox.Load();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
