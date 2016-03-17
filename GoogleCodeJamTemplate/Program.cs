using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GoogleCodeJamTemplate
{
    class Program
    {
        const string fileName = "A-small-attempt";

        static void Main(string[] args)
        {
            int numCases = 0;

            TextReader textReader = new StreamReader(fileName + ".in");
            TextWriter textWriter = new StreamWriter(fileName + ".out");

            numCases = Convert.ToInt32(textReader.ReadLine());

            for (int caseNumber = 1; caseNumber <= numCases; ++caseNumber)
            {
                // Read the inputs...May be multiple lines of inputs per case
                string s = textReader.ReadLine();

                // TODO: Process inputs

                // TODO: Generate the result for this case
                string result = "The Answer";

                // Output the results
                textWriter.WriteLine(String.Format("Case #{0}: {1}\n", caseNumber, result));
                textWriter.Flush();
            }

            // Close the streams
            textReader.Close();
            textWriter.Close();
        }
    }
}
