using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Background_imager_form : Form
    {
        private string[] image_array;
        int current_image_index = 0;
        public Background_imager_form()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("sldkjsd");
        }

        private void get_images_button_click(object sender, EventArgs e)
        {
            String excerpt_string = get_excerpt();
            String attributes_text = get_attribution_text();
            String keywords_text = get_keywords();
            System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://flask-api-imager.herokuapp.com/get_background");

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "excerpt="+excerpt_string;
            postData += "&attribution="+attributes_text;
            postData += "&keywords=" + keywords_text;
            byte[] data = encoding.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            try
            {
                // show progress bar
                user_docs.Text = user_docs.Text + " Please wait while we process your request";
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.RunWorkerAsync();
                fetch_images(request);
                /**/

            }
            catch (Exception err)
            {
                get_images_button.BackColor = System.Drawing.Color.Red;
                excerpt_textbox.Text = err.Message + "\n";
            }

        }

        public void fetch_images(HttpWebRequest request)
        {

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            String responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            this.image_array = responseString.Split('#');
            load_image();
            download_button.Visible = true;
            next_button.Visible = true;
            back_button.Visible = true;
            first_button.Visible = true;
            last_button.Visible = true;
            image_picture_box.Visible = true;
            user_docs.Visible = false;
        }
               


        public string FixBase64ForImage(string Image)
        {
            System.Text.StringBuilder sbText = new System.Text.StringBuilder(Image, Image.Length);
            sbText.Replace("\r\n", String.Empty); sbText.Replace(" ", String.Empty);
            return sbText.ToString();
        }

        private void load_image(int index=0)
        {
            Byte[] bitmapData = Convert.FromBase64String(FixBase64ForImage(this.image_array[index]));
            System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(bitmapData);
            Bitmap bitImage = new Bitmap((Bitmap)Image.FromStream(streamBitmap));
            image_picture_box.SizeMode = PictureBoxSizeMode.StretchImage;
            image_picture_box.Image = bitImage;
        }
      
        private String get_excerpt()
        {
            String excerpt = excerpt_textbox.Text.Trim();
            if (excerpt.Length == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                MessageBox.Show("Quote cannot be empty. Using 'Hello World' instead", "Warning", buttons);
                excerpt = "Hello World";                
            }
            return excerpt;
        }

        private String get_attribution_text()
        {
            return attribute_textbox.Text.Trim();
        }

        private String get_keywords()
        {
            return keywords_textbox.Text.Trim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            download_button.Visible = false;
            next_button.Visible = false;
            back_button.Visible = false;
            first_button.Visible = false;
            last_button.Visible = false;
            image_picture_box.Visible = false;
            user_docs.Text = "With the Background Imager, You can add beautiful backgrounds to text. \n" +
                "Just paste / write your text, and fill in the attributions(who said the words). \n " +
                "You may also add spedcific keyword to use to perform your search. ";
        }

        private void images_list_view_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void results_box_Enter(object sender, EventArgs e)
        {
            
        }

        private void excerpt_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!is_index_ideal(false))
            {
                is_index_ideal(true);
                load_image(this.current_image_index);
            }
            else
            {
                is_index_ideal(true);
                this.current_image_index = this.current_image_index - 1;
                load_image(this.current_image_index);
            }
        }

        private void first_button_Click(object sender, EventArgs e)
        {
            this.current_image_index = 0;
            is_index_ideal(false);
            is_index_ideal(true);
            this.load_image();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
         
            if(!is_index_ideal(true))
            {
                is_index_ideal(false);
                load_image(this.current_image_index);
            }
            else
            {
                is_index_ideal(false);
                this.current_image_index = this.current_image_index + 1;
                load_image(this.current_image_index);
            }
        }

        private void last_button_Click(object sender, EventArgs e)
        {
            this.current_image_index = this.image_array.Length - 1;
            is_index_ideal(false);
            is_index_ideal(true);
            load_image(this.current_image_index);
        }

        private Boolean is_index_ideal(bool is_next_button)
        {
            int current_index = this.current_image_index;
            if (is_next_button)
            {
                if (current_index + 1 >= this.image_array.Length)
                {
                    next_button.Enabled = false;
                    return false;
                }
                else
                {
                    next_button.Enabled = true;
                    return true;
                }
            }
            else
            {
                if (current_index - 1 < 0)
                {
                    back_button.Enabled = false;
                    return false;
                }
                else
                {
                    back_button.Enabled = true;
                    return true;
                }
            }
        }

        private void download_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                image_picture_box.Image.Save(sfd.FileName, format);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            excerpt_textbox.Clear();
            keywords_textbox.Clear();
            attribute_textbox.Clear();
        }

    }
}
