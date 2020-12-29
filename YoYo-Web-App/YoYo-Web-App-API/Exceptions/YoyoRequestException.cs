using System;
using System.Collections.Generic;
using System.Text;

namespace YoYo_Web_App_API.Exceptions
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class YoyoRequestException : Exception
    {
        public YoyoRequestException(string message): base(message)
        {
            
        }
    }
}
