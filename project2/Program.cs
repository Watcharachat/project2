using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static string Name;
        public static string Surname;
        public static string Age;
        public static string Address;
        public static string Height;
        public static string Weight;
        public static string Dominant_Foot;
        public static string Standing;
        public static string Phonenumber;
        public static string Team;
        public static string Birthday;
        public static string Changteam;
        public static string P;
        public static string W;
        public static string L;
        public static string F;
        public static string A;


    }

}
