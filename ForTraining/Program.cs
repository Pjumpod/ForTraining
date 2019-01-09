using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForTraining
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(params string[] paramaters)
        {
            GC.Collect();
            MessageBox.Show($"Going to create garbage, currently using: {GC.GetTotalMemory(false)}");
            System.Threading.Thread.Sleep(10000);
            MessageBox.Show($"Creating garbage: {GC.GetTotalMemory(false)}");

            // allocate a ton of junk
            List<IDisposable> list = new List<IDisposable>();   // to get local references to junk so can't be garbage collected.
            for (int i = 0; i < 10000; i++)
            {
                var lclThing = new SampleDispose();
                list.Add(lclThing);
            }

            MessageBox.Show($"We have garbage: {GC.GetTotalMemory(false)}");
            System.Threading.Thread.Sleep(10000);

            MessageBox.Show($"Killing ref to garbage: {GC.GetTotalMemory(false)}");
            list.Clear();

            System.Threading.Thread.Sleep(10000);
            MessageBox.Show($"After clear list: {GC.GetTotalMemory(false)}");
            GC.Collect();
            MessageBox.Show($"forcing garbage collector: {GC.GetTotalMemory(false)}");
            System.Threading.Thread.Sleep(10000);

        }
    }

}