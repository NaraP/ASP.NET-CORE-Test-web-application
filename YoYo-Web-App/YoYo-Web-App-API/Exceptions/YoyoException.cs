using System;

namespace YoYo_Web_App_API.Exceptions
{
    
    public class YoyoException : Exception
    {

        /// <summary>Initializes a new instance of the <see cref="YoyoException" /> class.</summary>
        public YoyoException()
        { }

        /// <summary>
        ///   <br />
        /// </summary>
        /// <param name="message"></param>
        public YoyoException(string message)
            : base(message)
        { }


        /// <summary>Initializes a new instance of the <see cref="YoyoException" /> class.</summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference (<span class="keyword"><span class="languageSpecificText"><span class="cs">null</span><span class="vb">Nothing</span><span class="cpp">nullptr</span></span></span><span class="nu">a null reference (<span class="keyword">Nothing</span> in Visual Basic)</span> in Visual Basic) if no inner exception is specified.
        /// </param>
        public YoyoException(string message, Exception innerException)
            : base(message, innerException)
        { }
        
    }
}
