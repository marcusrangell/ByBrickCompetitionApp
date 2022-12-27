using FixMe.Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Diagnostics.Tracing.Parsers.IIS_Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixMe.Options
{
    public static class Fill
    {
        internal static object[] FillDataObjectArray()
        {
            RunnerOptions options = new RunnerOptions();

            object[] objects = new object[options.Iterations];
            Random rand = new Random();

            for (int i = 0;i < options.Iterations; i++)
            {
                int check = rand.Next(options.Iterations);
                if (check % 2 == 0)
                {
                    objects[i] = new Cuirckle();
                }
                else
                {
                    objects[i] = new Atrangle();
                }
            }


            return objects;
        }
    }
}
