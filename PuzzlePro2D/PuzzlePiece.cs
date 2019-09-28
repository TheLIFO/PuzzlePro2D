using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace PuzzlePro2D
{
    class PuzzlePiece
    {
        double xrot = 0;
        double yrot = 0;
        double zrot = 0;

        private Color Col { get; set; }
        private int NumSpheres { get; }    
        private int ID { get; }
        
        private byte[,,] Raster;
        
        public PuzzlePiece (int ID, int NumSpheres, Color Col, byte[,,] Raster)
        {
            this.Raster = Raster;
            this.Col = Col;
            this.NumSpheres = NumSpheres;
            this.ID = ID;
        }
        
        public void Show()
        { 
            //GL.Translate(0, 0, -5);
            //GL.Rotate(xrot += 0.5f, 1, 0, 0);
            //GL.Rotate(yrot += 0.3f, 0, 1, 0);
            //GL.Rotate(zrot += 0.2f, 0, 0, 1);

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(Color.LawnGreen);
            GL.Vertex2(0, 0);
            GL.Vertex2(1, 0);
            GL.Vertex2(1, -1);
            GL.Vertex2(0, -1);


            ////backside
            //GL.Color3(255, 0, 255);
            //GL.Vertex3(1, 1, -1);
            //GL.Vertex3(1, -1, -1);
            //GL.Vertex3(-1, -1, -1);
            //GL.Vertex3(-1, 1, -1);

            ////down
            //GL.Color3(0, 255, 255);
            //GL.Vertex3(-1, -1, -1);
            //GL.Vertex3(1, -1, -1);
            //GL.Vertex3(1, -1, 1);
            //GL.Vertex3(-1, -1, 1);

            ////left
            //GL.Color3(255, 255, 0);
            //GL.Vertex3(-1, 1, -1);
            //GL.Vertex3(-1, -1, -1);
            //GL.Vertex3(-1, -1, 1);
            //GL.Vertex3(-1, 1, 1);

            ////right
            //GL.Color3(0, 0, 255);
            //GL.Vertex3(1, 1, 1);
            //GL.Vertex3(1, -1, 1);
            //GL.Vertex3(1, -1, -1);
            //GL.Vertex3(1, 1, -1);


            ////top
            //GL.Color3(0, 255, 0);
            //GL.Vertex3(-1, 1, -1);
            //GL.Vertex3(-1, 1, 1);
            //GL.Vertex3(1, 1, 1);
            //GL.Vertex3(1, 1, -1);

            ////front
            //GL.Color3(255, 0, 0);
            //GL.Vertex3(-1, 1, 1);
            //GL.Vertex3(-1, -1, 1);
            //GL.Vertex3(1, -1, 1);
            //GL.Vertex3(1, 1, 1);

            

            GL.End();
        }
    }
   
}
