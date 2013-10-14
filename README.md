Stretcher
================

Extension methods for .NET built-in types.

##Nuget Package

    Install-Package Stretcher

##Usage

````C#
using Stretcher;
````

````C#
//RoundUpToTen
var myValue = 5;
var roundedValue = myValue.RoundUpToTen();

//Result = 10
````

````C#
//ToOrdinal
var myValue = 21;
var ordinalValue = myValue.ToOrdinal();

//Result = 21st
````

````C#
//ReplaceInner
var myValue = "This is my string.";
var newString = originalString.ReplaceInner("isn't", 5, 2);

//Result = This isn't my string.
````

````C#
//MarkdownToHtml
var markdown = "**bolded text**";
var html = markdown.MarkdownToHtml();

//Result = <p><strong>bolded text</strong></p>

markdown = "    <script>var test = 'markdownRocks!'</script>";
html = markdown.MarkdownToHtml("prettyprint");

//Result = <pre class="prettyprint"><code>&lt;script&gt;var test = 'markdownRocks!'&lt;/script&gt;</code></pre>
````

See Program.cs in Demo for more.

##License

The MIT License (MIT)

Copyright (c) 2013 Scott Smith

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
