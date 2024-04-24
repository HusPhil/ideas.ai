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
            
        }

        public async Task<Image> markdownToMindmap(string markdown, bool auto)
        {

            var factory = new RendererFactory();
            var settings = new PlantUmlSettings();

            var renderer = factory.CreateRenderer(settings);

            try
            {
                // Render the markdown content as PNG bytes
                var bytes = await renderer.RenderAsync(markdown, OutputFormat.Png);

                // Convert PNG bytes to Image
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    //lbl_errorIndicator.ForeColor = Color.Green;
                    //lbl_errorIndicator.Text = "No errors found.";
                    mainForm.addNotification("success", "Successfully generated!", "A mindmap was successfully generated");
                    btn_saveAsImage.Enabled = true;
                    return Image.FromStream(ms);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurreds: {ex.Message}");

                //lbl_errorIndicator.ForeColor = Color.Red;
                //lbl_errorIndicator.Text = ex.Message;
                mainForm.addNotification("error", "Failed to generate!", $"Error: {ex.Message}");
                btn_saveAsImage.Enabled = !true;
                return null; 
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
            cb_themeSelector.SelectedIndex = 0;
        }

        private static string AddTheme(string mindmapText, string theme)
        {
            // Define the regex pattern to match the theme declaration
            string pattern = @"^@startmindmap\s*(?:!theme\s+\w[\w-]*\s*)?";

            // Check if the theme is already present in the mindmap text
            if (Regex.IsMatch(mindmapText, pattern, RegexOptions.Multiline))
            {
                // If theme is present, replace it with the new theme
                mindmapText = Regex.Replace(mindmapText, pattern, $"@startmindmap\n{theme}\n", RegexOptions.Multiline);
            }
            else
            {
                // If theme is not present, insert it after @startmindmap
                mindmapText = Regex.Replace(mindmapText, @"@startmindmap\s*", $"@startmindmap\n{theme}\n", RegexOptions.Multiline);
            }

            return mindmapText;
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
                            pnl_buttons.Visible = true;
                            break;
                        case "Center":
                            pnl_buttons.Visible = !true;
                            pbx_mindmap.Location = new Point(0);
                            pbx_mindmap.Dock = DockStyle.Fill;
                            pbx_mindmap.SizeMode = PictureBoxSizeMode.CenterImage;
                            break;
                        case "Stretch":
                            pnl_buttons.Visible = !true;
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
            pbx_mindmap.Image = await markdownToMindmap(cleanedInput, false);
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
                //lbl_errorIndicator.ForeColor = Color.Red;
                //lbl_errorIndicator.Text = exception.Message;
                Console.WriteLine("Error: " + exception.Message);
                mainForm.addNotification("error", "Failed to generate!", $"Error: {exception.Message}");
            }
        }

        private void btn_saveAsImage_Click(object sender, EventArgs e)
        {
            // Create save file dialog
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
            saveDialog.Title = "Save Image";
            saveDialog.FileName = txb_title.Text;
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

                    mainForm.addNotification("success", "File saved!", "Mindmap was saved as a file");
                }
                else
                {
                    MessageBox.Show("No image to save");
                    mainForm.addNotification("erro", "File was not saved!", "Failed to save your mindmap");
                }
            }
        }

        private void cb_themeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_themeSelector.SelectedItem != null)
                {
                    string selectedSetting = cb_themeSelector.SelectedItem.ToString();
                    Console.WriteLine("Selected item: " + selectedSetting);

                    switch (selectedSetting)
                    {
                        case "None":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Amiga":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme amiga");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Aws-orange":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme aws-orange");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Black-knight":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme black-knight");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Bluegray":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme bluegray");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Blueprint":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme blueprint");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Cerulean-outline":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme cerulean-outline");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Cerulean":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme cerulean");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Crt-amber":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme crt-amber");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Crt-green":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme crt-green");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Cyborg-outline":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme cyborg-outline");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Cyborg":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme cyborg");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Hacker":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme hacker");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Lightgray":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme lightgray");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Mars":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme mars");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Materia-outline":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme materia-outline");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Materia":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme materia");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Metal":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme metal");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Mimeograph":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme mimeograph");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Minty":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme minty");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Plain":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme plain");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Reddress-darkblue":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme reddress-darkblue");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Reddress-darkgreen":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme reddress-darkgreen");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Reddress-darkorange":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme reddress-darkorange");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Reddress-darkred":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme reddress-darkred");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Reddress-lightblue":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme reddress-lightblue");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Reddress-lightgreen":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme reddress-lightgreen");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Reddress-lightorange":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme reddress-lightorange");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Reddress-lightred":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme reddress-lightred");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Sandstone":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme sandstone");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Silver":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme silver");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Sketchy-outline":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme sketchy-outline");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Sketchy":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme sketchy");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Spacelab":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme spacelab");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Spacelab-white":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme spacelab-white");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Superhero-outline":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme superhero-outline");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Superhero":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme superhero");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Toy":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme toy");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "United":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme united");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        case "Vibrant":
                            txb_markdownInput.Text = AddTheme(txb_markdownInput.Text, "!theme vibrant");
                            generateMindmap(txb_markdownInput.Text);
                            break;
                        default:
                            // Handle unknown theme
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
        //Getters
        public ref RichTextBox getTxbMarkdownInput()
        {
            return ref txb_markdownInput;
        }
        public ref TextBox getTxbTitle()
        {
            return ref txb_title;

        }

        private void pbx_mindmap_BackgroundImageChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Changed");
        }
    }
}
