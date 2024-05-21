using Microsoft.VisualBasic.ApplicationServices;

namespace SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Klas�r olu�turma
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = Directory.CreateDirectory(@"C: \Users\Toshiba\Desktop");
            MessageBox.Show(info.FullName);
        }

        //Klas�r silme
        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C: \Users\Toshiba\Desktop"))
            { Directory.Delete(@"C: \Users\Toshiba\Desktop"); }
            else
            { MessageBox.Show("Dosya bulunamad�...."); }

        }

        //Klas�r ta��ma
        private void button3_Click(object sender, EventArgs e)
        {
            Directory.Move(@"C: \Users\Toshiba\Desktop", @"C: \Users\Toshiba\Desktop\BAA\New");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectoryInfo fi = new DirectoryInfo(@"C: \Users\Toshiba\Desktop\BAA\New");
            string message = $"Klas�r Ad�: {fi.Name} \nKlas�r olu�ma tarihi: {fi.CreationTime.ToShortDateString()} \nSon eri�im tarihi: {fi.LastAccessTime} \nYaz�lma Tarihi: {fi.LastWriteTime} \nK�k dizini: {fi.Root}";
            MessageBox.Show(message);
        }

        //Dosya olu�turma
        private void button5_Click(object sender, EventArgs e)
        {
            File.Create(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt");
            //File.Copy() kopyalama
            //File.Delete() silme
            //File.Exists() varm� yokmu kontrol�
            //File.Move("varolanadres","ta��nacakadres")
        }

        //Yazma i�lemi
        private void button6_Click(object sender, EventArgs e)
        {
            List<string> isimler = new List<string> { "nil", "g�ne�", "bahar" };
            File.WriteAllLines(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt", isimler);

            //File.WriteAllText(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt","Merhaba d�nya!! \n\tGunesssss");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //T�m dosyay� okur
            string info = File.ReadAllText(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt");
            MessageBox.Show(info);

            //sat�r sast�r okur
            string[] readline = File.ReadAllLines(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt");
            foreach (var item in readline)
            { MessageBox.Show(item); }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt");
            string message = $"Varmi: {fileInfo.Exists}\nOlu�turma tarihi: {fileInfo.CreationTime}\nTam ad�: {fileInfo.FullName}";
            MessageBox.Show(message);
        }

        //S�r�c� bilgileri
        private void button9_Click(object sender, EventArgs e)
        {
            DriveInfo driveInfo = new DriveInfo("C");
            string message = $"kullan�labilri alan: {driveInfo.AvailableFreeSpace}\ntoplam boyut: {driveInfo.TotalSize}";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string path = @"C: \Users\Toshiba\Desktop\BAA\New\new.txt";
            string fileName =Path.GetFileName(path);
            string dirName=Path.GetDirectoryName(path);
            string fullPath=Path.GetFullPath(path);
            string extension=Path.GetExtension(path);
            string newExtension = ".csv";
            string newPath = Path.ChangeExtension(path, newExtension);
        }
    }
}
