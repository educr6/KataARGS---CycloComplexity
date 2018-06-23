using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataARGS
{
   public class ARGS
    {
        public bool hasLogin;
        public bool hasPort;
        int port;
        public bool hasDirectory;

        public void main(string[] args)
        {
            hasLogin = false;
            hasPort = false;
            hasDirectory = false;

            if (args.Length > 0)
            {
                hasLogin = args[0] == "-l";
            }

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-p" && (i + 1 < args.Length)) {
                    hasPort = int.TryParse(args[i + 1],out port);

                }
                if (args[i] == "-d" && (i + 1 < args.Length))
                {
                    if (args[i + 1] != "-p")
                        hasDirectory = true;
                }
                    
                    
            }
           

        }
    }
}
