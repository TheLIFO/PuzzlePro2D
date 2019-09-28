using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;






namespace PuzzlePro2D
{
    static class Program
    {   /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormPuzzleBoard myForm = new FormPuzzleBoard();
            
            Application.Run(myForm);

           
        }

    }



}
