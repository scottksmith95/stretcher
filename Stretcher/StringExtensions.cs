using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretcher
{
    public static class StringExtensions
    {
        /// <summary>
        /// Replaces a string within the string at the given index and length.
        /// </summary>
        /// <param name="innerValue">The new string to insert.</param>
        /// <param name="startIndex">The zero-based starting character position of the string to replace.</param>
        /// <param name="length">The number of characters in the substring to replace.</param>
        /// <returns></returns>
        public static string ReplaceInner(this string original, string innerValue, int startIndex, int length)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(original.Substring(0, startIndex));
            stringBuilder.Append(innerValue);
            stringBuilder.Append(original.Substring(startIndex + length));

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Converts the markdown text to HTML.
        /// </summary>
        /// <param name="preClassName">Optional parameter to insert an HTML class for all 'pre' tags.</param>
        /// <param name="extraMode">Defaults to false.</param>
        /// <param name="safeMode">Defaults to true.</param>
        /// <returns></returns>
        public static string MarkdownToHtml(this string markdown, string preClassName = "", bool extraMode = false, bool safeMode = true)
        {
            var md = new MarkdownDeep.Markdown();
            md.ExtraMode = extraMode;
            md.SafeMode = safeMode;

            var html = md.Transform(markdown);

            if (!string.IsNullOrEmpty(preClassName))
                html = html.Replace("<pre>", "<pre class=\"" + preClassName + "\">");

            return html;
        }
    }
}
