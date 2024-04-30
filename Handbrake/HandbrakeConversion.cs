using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbrake
{
    public class HandbrakeConversion
    {
        public static void ConvertFile(string inputFile)
        {
            string handbrakePath = "C:\\handbrake\\HandBrakeCLI.exe";

            var folderPath = Path.GetDirectoryName(inputFile);
            var fileName = Path.GetFileName(inputFile);
            var outputFile = Path.Combine(folderPath, $"Converted_{fileName}");

            Console.WriteLine("Converting file {0}", inputFile);

            string additionalOptions = "--preset=\"Fast 1080p30\"";
            string arguments = $"-i \"{inputFile}\" -o \"{outputFile}\" {additionalOptions}";

            using (var handbrake = Process.Start(handbrakePath, arguments))
            {
                handbrake.WaitForExit();
            }

            File.AppendAllText(Path.Combine(folderPath, "log.txt"), fileName);

            Console.WriteLine("Conversion completed!");

        }

    }
}

