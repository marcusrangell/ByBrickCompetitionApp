using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using FixMe.Entities;
using FixMe.Options;

namespace FixMe.Runners
{
    public class RunFaster
    {
        private readonly RunnerOptions options;

        private object[] _all_the_cheats;

        public RunFaster()
        {
            options = new RunnerOptions();
            _all_the_cheats = Fill.FillDataObjectArray();
        }
        
        [Benchmark]
        public void Run() 
        {               
            
            for (int i = 0; i<_all_the_cheats.Count(); i++)
            {                    
                var cheatType = _all_the_cheats[i];
                if (cheatType is Cuirckle)
                {
                        
                    using (StreamWriter sw = File.AppendText(options.CuirckleFilePath))
                    {
                        var _irckle = cheatType as Cuirckle;
                        double circumference = _irckle.Calculate;
                        sw.WriteLine($"Circumference of circle: {_irckle.RandomRadius}:{circumference}");
                        sw.Flush();
                    }
                        
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(options.AtrangleFilePath))
                    {
                        var _angle = cheatType as Atrangle;
                        double area = _angle.Calculate;
                        sw.WriteLine($"Area of triangle: {area}");
                        sw.Flush();
                    }
                }
            }                                   
        }
    }
}
