using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace resources
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // METHOD 1
        // Use the resource manager to access an image in a .resx file.
        private void buttonCard1_Click(object sender, EventArgs e)
        {
            var card = new Card(1, "AceOfDiamonds", Resources.AceOfDiamonds);
            pictureBox1.Image = card.Image;
            labelImageCredit.Text = "Image Credit: www.freestockphotos.biz/stockphoto/15524";
        }


        // METHOD 2
        // Use a fully qualified resource name of an image file.
        // The `BuildAction` property for the image file must
        // be set to `EmbeddedResource` for this version to work.
        private void buttonCard2_Click(object sender, EventArgs e)
        {
            // Get full names of available resources
            Debug.WriteLine(
                string.Join(
                    Environment.NewLine, 
                    typeof(MainForm).Assembly.GetManifestResourceNames()));

            var card = new Card(2, "EightOfSpades", "resources.Images.EightOfSpades.png");
            pictureBox1.Image = card.Image;
            labelImageCredit.Text = "Image Credit: www.freestockphotos.biz/stockphoto/15491";
        }
    }

    class Card
    {
        // METHOD 1
        // CTor with Image
        public Card(int value, string name, Image image)
        {
            Value = value;
            Name = name;
            Image = image;
        }

        // METHOD 2
        // CTor using string
        public Card(int value, string name, string resource)
        {
            Value = value;
            Name = name;
            Image = Image.FromStream(typeof(Card).Assembly.GetManifestResourceStream(resource));
        }

        public int Value { get; }
        public string Name { get;  }
        public Image Image { get; }
    }
}
