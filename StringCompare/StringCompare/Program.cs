using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {


            string text = @$"New application development can specify the net5.0 target framework moniker (TFM) for all project types, including class libraries. Sharing code between .NET 5 workloads is simplified in that all you need is the net5.0 TFM.
            For .NET 5.0 apps and libraries, the net5.0 Target Framework Moniker (TFM) combines and replaces the netcoreapp and netstandard TFMs. However, if you plan to share code between .NET Framework, .NET Core, and .NET 5 workloads, you can do so by specifying netstandard2.0 as your TFM. For more information, see .NET Standard.Developers writing .NET 5 apps will have access to the latest C# version and features. .NET 5 is paired with C# 9, which brings many new features to the language.
            Here are a few highlights:Records: reference types with value-based equality semantics and non-destructive mutation supported by a new with expression.
            Relational pattern matching: Extends pattern matching capabilities to relational operators for comparative evaluations and expressions, including logical patterns - new keywords and, or, and not. Developers writing .NET 5 apps will have access to the latest C# version and features. .NET 5 is paired with C# 9, which brings many new features to the language. Here are a few highlights:
            Records: reference types with value-based equality semantics and non-destructive mutation supported by a new with expression.
            Relational pattern matching: Extends pattern matching capabilities to relational operators for comparative evaluations and expressions, including logical patterns - new keywords and, or, and not.";

            string searchTerm = "data,object,c#,the";

            //Convert the string into an array of words  
            string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Create the query.  Use ToLowerInvariant to match "data" and "Data"   
            var matchQuery = from word in source
                             where searchTerm.Split(',').Contains(word.ToLowerInvariant())
                             select word;


            // Count the matches, which executes the query.  
            int wordCount = matchQuery.Count();
            Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, searchTerm);

            // Keep console window open in debug mode  
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
