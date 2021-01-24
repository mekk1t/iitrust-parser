using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSP
{
    public class CompositionRoot
    {
        private static CompositionRoot instance;
        private static object _lock = new object();

        public static CompositionRoot Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new CompositionRoot();
                        return instance;
                    }
                    return instance;
                }
            }
        }

        private CompositionRoot()
        {

        }

        public IWebSiteArticlesParser CreateParser()
        {
            return (IWebSiteArticlesParser) new object();
        }
    }
}
