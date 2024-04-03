using ComponentFactory.Krypton.Toolkit;
using PlantUml.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.pages
{
    public partial class frm_mindmap : Form
    {

        private MainForm mainForm;
        private const float defaultScaleFactor = 1.0f;
        private float scaleFactor = defaultScaleFactor;
        private float scaleStep = 0.1f;

        public frm_mindmap(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            ApplyZoom();
            cb_viewSelector.SelectedIndex = 0;
            pbx_mindmap.Image = null;

            this.txb_markdownInput.Text = "@startmindmap\n" +
                "* Main Topic\n" +
                "** Subtopic 1\n" +
                "*** Details 1.1\n" +
                "*** Details 1.2\n" +
                "** Subtopic 2\n" +
                "*** Details 2.1\n" +
                "**** Additional Details 2.1.1\n" +
                "@endmindmap";
            generateMindmap(txb_markdownInput.Text);
        }

        public async Task<Image> markdownToMindmap(string markdown)
        {

            var factory = new RendererFactory();

            var renderer = factory.CreateRenderer(new PlantUmlSettings());


            try
            {
                // Render the markdown content as PNG bytes
                var bytes = await renderer.RenderAsync(markdown, OutputFormat.Png);

                // Convert PNG bytes to Image
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    lbl_errorIndicator.ForeColor = Color.Green;
                    lbl_errorIndicator.Text = "No errors found.";
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception as needed, for example, logging the error
                Console.WriteLine($"An error occurreds: {ex.Message}");
                
                lbl_errorIndicator.ForeColor = Color.Red;
                lbl_errorIndicator.Text = ex.Message;
                
                return null; // Or throw the exception if you prefer
            }


        }

        private void btn_zoomIn_Click(object sender, EventArgs e)
        {
            scaleFactor += scaleStep;
            ApplyZoom();
        }

        private void btn_zoomOut_Click(object sender, EventArgs e)
        {
            scaleFactor -= scaleStep;
            ApplyZoom();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            scaleFactor = defaultScaleFactor;
            ApplyZoom();
        }

        private void ApplyZoom()
        {
            try
            {
                // Set new zoom level
                if (scaleFactor < 0.1f)
                    scaleFactor = 0.1f; // Set minimum zoom level
                pbx_mindmap.Width = (int)(pbx_mindmap.Image.Width * scaleFactor);
                pbx_mindmap.Height = (int)(pbx_mindmap.Image.Height * scaleFactor);
            }
            catch (Exception exception)
            {

                Console.WriteLine("Error: " + exception.Message);
            }
            
        }

        private void frm_mindmap_Load(object sender, EventArgs e)
        {
            
        }

        private void cb_viewSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_viewSelector.SelectedItem != null)
                {
                    string selectedSetting = cb_viewSelector.SelectedItem.ToString();
                    Console.WriteLine("Selected item: " + selectedSetting);

                    switch (selectedSetting)
                    {
                        case "Zoom":
                            pbx_mindmap.Location = new Point(0);
                            pbx_mindmap.SizeMode = PictureBoxSizeMode.Zoom;
                            pbx_mindmap.Dock = DockStyle.None;
                            break;
                        case "Center":
                            pbx_mindmap.Location = new Point(0);
                            pbx_mindmap.Dock = DockStyle.Fill;
                            pbx_mindmap.SizeMode = PictureBoxSizeMode.CenterImage;
                            break;
                        case "Stretch":
                            pbx_mindmap.Location = new Point(0);
                            pbx_mindmap.Dock = DockStyle.Fill;
                            pbx_mindmap.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("No item selected.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

        public static string ConvertMarkdownToPlantUML(string markdown)
        {
            // Define patterns for markdown elements
            Regex headerPattern = new Regex(@"^#+\s(.+)$", RegexOptions.Multiline);
            Regex codeBlockPattern = new Regex(@"```(?:uml)?\s*([^`]+?)\s*```", RegexOptions.Singleline);

            // Convert headers to PlantUML titles
            string ReplaceHeader(Match match)
            {
                int headerLevel = match.Value.Split()[0].Length;
                string headerText = match.Groups[1].Value;
                return $"{'=' * (7 - headerLevel)} {headerText} {'=' * (7 - headerLevel)}";
            }

            // Convert code blocks to PlantUML code blocks
            string ReplaceCodeBlock(Match match)
            {
                string codeBlock = match.Groups[1].Value;
                return $"```uml\n{codeBlock}\n```";
            }

            // Replace markdown elements with PlantUML equivalents
            string plantUmlText = headerPattern.Replace(markdown, ReplaceHeader);
            plantUmlText = codeBlockPattern.Replace(plantUmlText, ReplaceCodeBlock);

            return plantUmlText;
        }
        public async void generateMindmap(string input)
        {
            var cleanedInput = ConvertMarkdownToPlantUML(input);
            Console.WriteLine(cleanedInput);
            pbx_mindmap.Image = await markdownToMindmap(cleanedInput);
            scaleFactor = defaultScaleFactor;
            ApplyZoom();
        }
        private void btn_generateMindmap_Click(object sender, EventArgs e)
        {
            try
            {
                generateMindmap(txb_markdownInput.Text);    

            }
            catch (Exception exception)
            {
                lbl_errorIndicator.ForeColor = Color.Red;
                lbl_errorIndicator.Text = exception.Message;
                Console.WriteLine("Error: " + exception.Message);
            }
        }

        //Getters
        public ref KryptonRichTextBox getTxbMarkdownInput()
        {
            return ref txb_markdownInput;
        }

        private void btn_saveAsImage_Click(object sender, EventArgs e)
        {
            // Create save file dialog
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
            saveDialog.Title = "Save Image";
            saveDialog.FileName = "image"; // Default filename

            // Show save file dialog and get the result
            DialogResult result = saveDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Get the filename entered by the user
                string fileName = saveDialog.FileName;

                // Get the image from the PictureBox
                Image image = pbx_mindmap.Image;

                if (image != null)
                {
                    // Get the file extension from the selected filter
                    string extension = System.IO.Path.GetExtension(fileName);

                    // Save the image in the selected format
                    switch (extension.ToLower())
                    {
                        case ".jpg":
                            image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case ".png":
                            image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case ".bmp":
                            image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        default:
                            MessageBox.Show("Unsupported file format");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No image to save");
                }
            }
        }
    }
}
