// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using FixMe.Entities;
using FixMe.Options;
using FixMe.Runners;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("The not-so-smart app that needs fixing. Fix me please!");
Console.WriteLine("");
Console.WriteLine("The objective of this \"fix\" is to improve the performance");
Console.WriteLine(" - Provide as much optimisation as you deem beneficial;");
Console.WriteLine(" - When you are done, upload the code to a GitHub repository and email me the url.");
Console.WriteLine(" - Ensure that you also provide your Correlation ID that was provided to you.");
Console.WriteLine("");
Console.WriteLine("My email address: jamal.hartnett@bybrick.se");
Console.WriteLine("");
Console.WriteLine("Best of luck!!!");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("");
Console.WriteLine("Hint: use BenchmarkDotNet for your testing purposes.");
Console.WriteLine("https://github.com/dotnet/BenchmarkDotNet");

RunFaster runFaster = new RunFaster();
runFaster.Run();

//var summary = BenchmarkRunner.Run<RunFaster>();
