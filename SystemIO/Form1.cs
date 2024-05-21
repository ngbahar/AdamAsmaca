using Microsoft.VisualBasic.ApplicationServices;

namespace SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Klasör oluþturma
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = Directory.CreateDirectory(@"C: \Users\Toshiba\Desktop");
            MessageBox.Show(info.FullName);
        }

        //Klasör silme
        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C: \Users\Toshiba\Desktop"))
            { Directory.Delete(@"C: \Users\Toshiba\Desktop"); }
            else
            { MessageBox.Show("Dosya bulunamadý...."); }

        }

        //Klasör taþýma
        private void button3_Click(object sender, EventArgs e)
        {
            Directory.Move(@"C: \Users\Toshiba\Desktop", @"C: \Users\Toshiba\Desktop\BAA\New");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectoryInfo fi = new DirectoryInfo(@"C: \Users\Toshiba\Desktop\BAA\New");
            string message = $"Klasör Adý: {fi.Name} \nKlasör oluþma tarihi: {fi.CreationTime.ToShortDateString()} \nSon eriþim tarihi: {fi.LastAccessTime} \nYazýlma Tarihi: {fi.LastWriteTime} \nKök dizini: {fi.Root}";
            MessageBox.Show(message);
        }

        //Dosya oluþturma
        private void button5_Click(object sender, EventArgs e)
        {
            File.Create(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt");
            //File.Copy() kopyalama
            //File.Delete() silme
            //File.Exists() varmý yokmu kontrolü
            //File.Move("varolanadres","taþýnacakadres")
        }

        //Yazma iþlemi
        private void button6_Click(object sender, EventArgs e)
        {
            List<string> isimler = new List<string> { "nil", "güneþ", "bahar" };
            File.WriteAllLines(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt", isimler);

            //File.WriteAllText(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt","Merhaba dünya!! \n\tGunesssss");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Tüm dosyayý okur
            string info = File.ReadAllText(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt");
            MessageBox.Show(info);

            //satýr sastýr okur
            string[] readline = File.ReadAllLines(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt");
            foreach (var item in readline)
            { MessageBox.Show(item); }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(@"C: \Users\Toshiba\Desktop\BAA\New\new.txt");
            string message = $"Varmi: {fileInfo.Exists}\nOluþturma tarihi: {fileInfo.CreationTime}\nTam adý: {fileInfo.FullName}";
            MessageBox.Show(message);
        }

        //Sürücü bilgileri
        private void button9_Click(object sender, EventArgs e)
        {
            DriveInfo driveInfo = new DriveInfo("C");
            string message = $"kullanýlabilri alan: {driveInfo.AvailableFreeSpace}\ntoplam boyut: {driveInfo.TotalSize}";
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
