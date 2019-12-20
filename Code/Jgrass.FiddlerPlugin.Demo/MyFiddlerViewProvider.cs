using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jgrass.FiddlerPlugin.Demo
{
    class MyFiddlerViewProvider : IFiddlerViewProvider
    {
        public IList<FiddlerTabPage> BuildFiddlerTabPages()
        {
            var title = "Jgrass.Demo";
            var fiddlerTabPage = new FiddlerTabPage(title, new MyFiddlerTabPage());
            return new List<FiddlerTabPage>()
            {
                fiddlerTabPage
            };
        }
    }
}
