using BenchmarkDotNet.Attributes;
using FixMe.Entities;
using FixMe.Options;
using System.Text;

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
            using StreamWriter swc = new(options.CuirckleFilePath, true, Encoding.UTF8, 65536);
            using StreamWriter swt = new(options.AtrangleFilePath, true, Encoding.UTF8, 65536);

            for (int i = 0; i < _all_the_cheats.Count(); i++)
            {
                var cheatType = _all_the_cheats[i];
                if (cheatType is Cuirckle)
                {
                    {
                        var _irckle = cheatType as Cuirckle;
                        double circumference = _irckle.Calculate;
                        swc.WriteLine($"Circumference of circle: {_irckle.RandomRadius}:{circumference}");
                    }
                }
                else
                {
                    {
                        var _angle = cheatType as Atrangle;
                        double area = _angle.Calculate;
                        swt.WriteLine($"Area of triangle: {area}");
                    }
                }
            }
        }
    }
}
