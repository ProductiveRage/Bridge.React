using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.React;
using Bridge.Html5;

namespace Bridge.React.Examples
{
    public class App
    {
        public static void Main()
        {
            React.Render(
                new MessageEntryForm("Name:"),
                Document.GetElementById("main")
            );
        }
    }
}
