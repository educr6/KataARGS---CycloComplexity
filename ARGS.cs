using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataARGS
{
    public class ARGS
    {
        public bool hasLogin = false;
        public bool hasPort = false;
        int port;
        public bool hasDirectory = false;


        public void hasPortMethod(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-p")
                {
                    if (i + 1 < args.Length)
                        hasPort = int.TryParse(args[i + 1], out port);

                }


            }
        }

        public void hasDirectoryMethod(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                
                if (args[i] == "-d")
                {
                    if (i + 1 < args.Length)
                    {
                        if (args[i + 1] != "-p")
                            hasDirectory = true;
                    }

                }


            }

        }

        public void main(string[] args)
        {
           

            if (args.Length > 0)
            {
                hasLogin = args[0] == "-l";
            }

            hasDirectoryMethod(args);
            hasPortMethod(args);
           

        }
    }
}
