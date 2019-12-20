using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Jgrass.FiddlerPlugin
{
    public interface IFiddlerViewProvider
    {
        IList<FiddlerTabPage> BuildFiddlerTabPages();
    }
}
