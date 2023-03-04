using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projelib
{
    
   
    static class Program
    {
      
        
         
        //string student_id_sarasari;
        //student_id_sarasari= student_id;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         //   string student_id;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new masoollib());
        }
    }
}
