using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FixMe.Options
{
    public class RunnerOptions
    {
        /// <summary>
        /// The number of iterations our process is going to run;
        /// </summary>
        public int Iterations { get;} = 500000;

        /// <summary>
        /// The filepath that we want the cheat sheet to be printed to containing the output from the cuirckle
        /// </summary>
        public string CuirckleFilePath { get; } = "./exam-cuirckle-cheat-sheet.txt";


        /// <summary>
        /// The filepath that we want the cheat sheet to be printed to containing the output from the atrangle
        /// </summary>
        public string AtrangleFilePath { get; } = "./exam-atrangle-cheat-sheet.txt";

    }
}
