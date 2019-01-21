using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExecuteCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ExecuteCommand();
        }


        public void ExecuteCommand()
        {
            #Enter your command below
            #string str = "net user abcd Password@123 /add && net localgroup Administrators abcd /add";
            string str = "echo aaa > myfile.txt && echo bbb >> myfile.txt";
            System.Diagnostics.ProcessStartInfo p = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C "+ str);
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = p;
            proc.Start();
            proc.WaitForExit();
            proc.Close();
        }
    }

}
