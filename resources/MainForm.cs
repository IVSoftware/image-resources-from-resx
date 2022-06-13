using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resources
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCard1_Click(object sender, EventArgs e)
        {
            var card = new Card(1, "Green", Resources.Image1);
            pictureBox1.Image = card.Image;
        }

        private void buttonCard2_Click(object sender, EventArgs e)
        {
            var card = new Card(2, "Red", Resources.Image2);
            pictureBox1.Image = card.Image;
        }
    }

    class Card
    {
        public Card(int value, string name, Image image)
        {
            Value = value;
            Name = name;
            Image = image;
        }

        public int Value { get; }
        public string Name { get;  }
        public Image Image { get; }
    }
}
