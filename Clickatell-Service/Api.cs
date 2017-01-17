using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clickatell_Service
{
    class Api
    {
        public static string SendSMS(string Token, string JsonArray)
        {
            return Rest.Post(Token, JsonArray);
        }
        
    }
}
