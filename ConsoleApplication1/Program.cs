using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintIntroInformation();

            var api = new WebApi1();
            PrintInformation("Fetching values, just to be sure API is accessible...");

            try
            {
                var results = api.Values.Get();
                results.ToList().ForEach(PrintResult);
            }
            catch (Exception e)
            {
                PrintError(e.Message);
            }

            var offset = new DateTimeOffset(2016, 05, 20, 12, 0, 0, TimeSpan.FromHours(2));
            PrintInformation("Posting offset to API...  Try #1");

            try
            {
                var response = api.Values.PostRawDate(offset);
                PrintResult(response);
            }
            catch (Exception e)
            {
                PrintError(e.Message);
            }

            PrintInformation("Posting offset to API...  Try #2");

            try
            {
                var response = api.Values.MyPostRawDateWithOperationResponseAsync(offset).GetAwaiter().GetResult();
                PrintResult(response.Body);
            }
            catch (Exception e)
            {
                PrintError(e.Message);
            }

            PrintInformation("Posting WRAPPED offset to API...  Try #3");

            try
            {
                var response = api.Values.PostWrappedRawDate(new OffsetWrapper {Offset = offset});
                PrintResult(response);
            }
            catch (Exception e)
            {
                PrintError(e.Message);
            }

            Console.ReadLine();
        }

        private static void PrintIntroInformation()
        {
            PrintInformation(
                "[Information] If I send DateTimeOffset as a primitive type parameter, it gets formatted as \"20. 05. 2016 12:00:00 + 02:00\" or with Uri.EscapeDataString" +
                " as \"20.%2005.%202016%2012%3A00%3A00%20%2B02%3A00\".\n" +
                "It should be \"2016-05-20T12:00:00\" or with Uri.EscapeDataString \"2016-05-20T12%3A00%3A00\" " +
                "which is got if date would get formated with dateTimeOffset.ToString(\"s\")", false);
        }

        private static void PrintInformation(string information, bool addLeadingLine = true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if(addLeadingLine) Console.WriteLine();
            Console.WriteLine(information);
            Console.ResetColor();
        }

        private static void PrintResult(string result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
            Console.ResetColor();
        }

        private static void PrintError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }
    }
}
