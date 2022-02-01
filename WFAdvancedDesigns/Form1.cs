using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAdvancedDesigns
{
    public partial class Form1 : Form
    {
        public FlowLayoutPanel flowLayout { get; set; }
        public Random random { get; set; }

        public Form1()
        {
            InitializeComponent();

            flowLayout = new FlowLayoutPanel()
            {
                Width = Width,
                Height = Height,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(20)
            };
            random = new Random();
            

            for (int i = 0; i < 100; i++)
            {
                Color color = Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255));
                Label newLabel = new Label()
                {
                    Text = $"Number {i}",
                    BackColor = color
                };
                flowLayout.Controls.Add(newLabel);
            }

            splitContainer1.Panel2.Controls.Add(flowLayout);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            title.Location = new Point()
            {
                X = splitContainer1.Panel1.Width / 2 - title.Width / 2,
                Y = splitContainer1.Panel1.Height / 2 - title.Height / 2,
            };

            flowLayout.Width = splitContainer1.Panel2.Width;
            flowLayout.Height = splitContainer1.Panel2.Height;
        }
    }
}
