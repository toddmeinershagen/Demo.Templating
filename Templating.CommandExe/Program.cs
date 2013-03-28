using System;
using System.Collections.Generic;
using System.Diagnostics;
using Templating.CommandExe.Rz;
using Templating.CommandExe.St;

namespace Templating.CommandExe
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Execute();
        }

        public void Execute()
        {
            var watch = new Stopwatch();
            watch.Start();

            RenderRazorTemplate();
            RenderStringTemplate();

            watch.Stop();
            Console.WriteLine("Time elapsed:  {0} ms", watch.Elapsed.Milliseconds);
            Console.ReadLine();
        }

        private void RenderRazorTemplate()
        {
            var model = GetModel();
            var templateService = new TemplatesService(new FileSystemService(), new RazorTemplateEngine());
            var result = templateService.Parse("First", model);

            Console.WriteLine(result);
        }

        private void RenderStringTemplate()
        {
            var model = GetModel();
            var templateService = new TemplatesService(new FileSystemService(), new StringTemplateEngine());
            var result = templateService.Parse("Second", model);

            Console.WriteLine(result);
        }

        private object GetModel()
        {
            return new
                {
                    Id = 10,
                    CreatedDate = DateTime.Now,
                    Name = "Name1",
                    Price = 123.45356,
                    Items = new List<KeyValuePair<string, bool>>
                        {
                            new KeyValuePair<string, bool>("Item1", false),
                            new KeyValuePair<string, bool>("Item2", true),
                            new KeyValuePair<string, bool>("Item3", false),
                            new KeyValuePair<string, bool>("Item4", false),
                            new KeyValuePair<string, bool>("Item5", true)
                        }
                };
        }
    }
}
