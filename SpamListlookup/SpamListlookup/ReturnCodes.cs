using System;
using System.Collections.Generic;
using System.Text;

namespace SpamListlookup
{
   public class ReturnCodes
    {
        public ReturnCodes()
        { }


        private static String[] returnCodes = { "127.0.0.2", "127.0.0.3", "127.0.0.4", "127.0.0.5", "127.0.0.6", "127.0.0.7", "127.0.0.10", "127.0.0.11" };

        public static bool isInReturnCodes(string returnCode)
        {
            foreach (string str in returnCodes)
            {
                if (returnCode == str)
                    return true;
            }
                return false;
        }
    }
}
