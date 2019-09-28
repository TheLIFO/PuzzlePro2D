using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace TestOpenGL
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!this.color) this.color = true;
                else this.color = false;

            this.glControl1.Invalidate();
        }

        bool loaded = false;
        bool color = false;

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.Black); // Yey! .NET Colors can be used directly!
        }
        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
                return;
        }
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded) // Play nice
                return;
            if (this.color) GL.ClearColor(Color.SkyBlue);
            else GL.ClearColor(Color.Red);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            glControl1.SwapBuffers();
        }
    }
}
