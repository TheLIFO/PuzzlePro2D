﻿using System;
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


namespace PuzzlePro2D
{
    
    public partial class FormPuzzleBoard : Form
    {
        int width = 0;
        int height = 0;
        double xrot = 0;
        double yrot = 0;
        double zrot = 0;

        static List<PuzzlePiece> PuzzlePieces;

        public FormPuzzleBoard()
        {
            
            InitializeComponent();
            width = this.glControl1.Width;
            height = this.glControl1.Height;
            
            PuzzlePieces = new List<PuzzlePiece>();

            
            //add all 12 Puzzlepieces
            #region PuzzlepiecesAdd

            PuzzlePieces.Add(new PuzzlePiece(1, 3, Color.FromArgb(0, 255, 255), new byte[4, 5, 5] {
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(2, 5, Color.FromArgb(0, 0, 255), new byte[4, 5, 5] {
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,1,1},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {1,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {1,1,1,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,1},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(3, 4, Color.FromArgb(128, 0, 128), new byte[8, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {1,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,1},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },
                //second side
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {1,1,1,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,1,1},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(4, 5, Color.FromArgb(255, 0, 0), new byte[8, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {1,1,1,1,0},
                    {0,0,0,1,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,1,0,0,0},
                    {0,1,1,1,1},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                //second side
                {
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,1,0},
                    {1,1,1,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,1},
                    {0,1,0,0,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(5, 5, Color.FromArgb(255, 0, 255), new byte[8, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,0,0,1,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {1,1,1,0,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,1,0,0,0},
                    {0,0,0,0,0},
                },
                {
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,1,1},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },
                //second side
                {
                    {0,0,0,0,0},
                    {0,1,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {1,1,1,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,1,0,0,0},
                    {0,1,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,1,1},
                    {0,1,1,0,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(6, 5, Color.FromArgb(255, 255, 0), new byte[8, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {1,1,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,1,1},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                //second side
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {1,1,1,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,1},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(7, 4, Color.FromArgb(34, 128, 34), new byte[8, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                //second side
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(8, 5, Color.FromArgb(150, 255, 150), new byte[8, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,1,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,1,1,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                //second side
                {
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,1,1,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,0},
                    {0,1,1,0,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(9, 5, Color.FromArgb(150, 255, 50), new byte[4, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,1,0,0,0},
                    {0,1,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,1,1,1,0},
                    {0,1,0,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,0,0,1,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0},
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,0,1,0},
                    {0,1,1,1,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(10, 4, Color.FromArgb(128, 0, 0), new byte[4, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,1,0,0,0},
                    {0,0,0,0,0}
                },
                {

                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0}
                },                
                //second side
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,0,0,1,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,1,1,0,0},
                    {0,0,0,0,0}
                },

            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(11, 5, Color.FromArgb(255, 127, 80), new byte[8, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,1,0},
                    {0,1,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,0,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0},
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,1,0},
                    {0,1,0,0,0},
                    {0,0,0,0,0},
                },
                //second side
                {
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,1,1,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,1,1,0},
                    {0,0,0,1,0},
                    {0,0,0,0,0},
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,1,1,0},
                    {0,1,1,0,0},
                    {0,0,0,0,0},
                },
                {
                    {0,0,0,0,0},
                    {0,1,0,0,0},
                    {0,1,1,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0}
                }
            }
            ));

            PuzzlePieces.Add(new PuzzlePiece(12, 5, Color.FromArgb(128, 0, 128), new byte[4, 5, 5] {
                //first side
                {
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,1,0},
                    {0,0,0,1,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,0,0,1,0},
                    {0,0,1,1,0},
                    {0,1,1,0,0},
                    {0,0,0,0,0}
                },
                {
                    {0,0,0,0,0},
                    {0,1,0,0,0},
                    {0,1,1,0,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0},
                },
                {
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,1,1,0,0},
                    {0,1,0,0,0},
                    {0,0,0,0,0},
                }
            }
            ));

            #endregion

            //PuzzlePieces[1].Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            xrot++;
            yrot++;
            zrot++;
            
            this.glControl1.Invalidate();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            
        }

        private void glControl1_Load(object sender, EventArgs e)
        {            
            GL.ClearColor(Color.Black);
            
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(Color.CornflowerBlue);

            PuzzlePieces[1].Show();
            
            glControl1.SwapBuffers();
 
        }
    }
}
