namespace ImageToBase64
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                imageOriginal.Image = new Bitmap(open.FileName);
                imageOriginal.SizeMode = PictureBoxSizeMode.Zoom;
                // image file path  
                filePathTextBox.Text = open.FileName;
            }
        }

        public string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        public Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }


        private void imageToBase64Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (imageOriginal.Image == null)
                {
                    MessageBox.Show("Please select an image first");
                    return;
                }
                using (Image image = imageOriginal.Image.Clone() as Image)
                {
                    txtBase64.Text = "data:image/jpeg;base64," + ConvertImageToBase64(image);
                    txtBase64.Text = ConvertImageToBase64(image);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace);
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        private void base64ToImageButton_Click(object sender, EventArgs e)
        {
            if (txtBase64.Text == String.Empty)
            {
                MessageBox.Show("Please enter a base64 string first!");
                return;
            }
            else
            {
                picBase64ToImage.Image = ConvertBase64ToImage(txtBase64.Text);
                picBase64ToImage.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }
      
    }
}