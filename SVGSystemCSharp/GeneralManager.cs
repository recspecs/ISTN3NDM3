using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace SVGSystemCSharp
{
    public partial class GeneralManager : Form
    {
        clsResize gmResize;
        SvgDbContext dbContext;


        public GeneralManager()
        {
            InitializeComponent();



            //setup form resizing 
            gmResize = new clsResize(this);
            this.Load += new EventHandler(_Load);
            this.Resize += new EventHandler(_Resize);
        }

        private static void ConfigureCrystalReports()
        {
        }

        private void GeneralManager_Load(object sender, EventArgs e)
        {
            ConfigureCrystalReports();

            
            LogoPanelGM.Height = this.Height/7;
            BlueStripGM.SuspendLayout();
            BlueStripGM.Location = new Point(LogoPanelGM.Left, LogoPanelGM.Bottom);
            BlueStripGM.Size = new Size(LogoPanelGM.Width, LogoPanelGM.Height / 10);
            BlueStripGM.ResumeLayout(true);




        }

        private void _Load(object sender, EventArgs e)
        {
            gmResize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            gmResize._resize();
        }



        private void LogoPanelGM_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, LogoPanelGM.Width, LogoPanelGM.Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.Gray, Color.DarkGray,LinearGradientMode.Vertical);
            graphics.FillRectangle(b, gradient_rectangle);

        }

        private void GeneralManager_Layout(object sender, LayoutEventArgs e)
        {
            
           

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
