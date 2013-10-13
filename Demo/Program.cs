using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Stretcher;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //RoundUpToTen
            Console.WriteLine("Testing RoundUpToTen:" + Environment.NewLine);
            for (int i = 0; i <= 11; i++)
            {
                var roundedValue = i.RoundUpToTen();
                Console.WriteLine(i + " => " + roundedValue);
            }

            Console.WriteLine();
            Console.WriteLine();

            //ToOrdinal
            Console.WriteLine("Testing ToOrdinal:" + Environment.NewLine);
            for (int i = 0; i <= 30; i++)
            {
                var ordinalValue = i.ToOrdinal();
                Console.WriteLine(i + " => " + ordinalValue);
            }

            Console.WriteLine();
            Console.WriteLine();

            //ReplaceInner
            Console.WriteLine("Testing ReplaceInner:" + Environment.NewLine);
            var originalString = "This is my string.";
            var newString = originalString.ReplaceInner("isn't", 5, 2);
            Console.WriteLine(originalString + " => " + newString);

            //MarkdownToHtml
            Console.WriteLine("Testing MarkdownToHtml:" + Environment.NewLine);
            var markdown = "**bolded text**";
            var html = markdown.MarkdownToHtml();
            Console.WriteLine(markdown + " => " + html);
            markdown = "    <script>var test = 'markdownRocks!'</script>";
            html = markdown.MarkdownToHtml("prettyprint");
            Console.WriteLine(markdown + " => " + html);

            Console.ReadLine();
        }
    }
}
