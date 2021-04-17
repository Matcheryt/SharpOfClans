using System;
using System.Net;

namespace SharpOfClans
{
    /// <summary>
    /// The exception thrown when a call to the Clash of Clans API fails.
    /// </summary>
    public class ClashApiException : Exception
    {
        /// <summary>
        /// HTTP status code that caused the exception.
        /// </summary>
        public readonly HttpStatusCode HttpStatusCode;

        /// <summary>
        /// Creates a <see cref="ClashApiException"/>.
        /// </summary>
        /// <param name="message">The exceptions' message.</param>
        /// <param name="httpStatusCode">The HTTP status code that caused the exception.</param>
        public ClashApiException(string message, HttpStatusCode httpStatusCode) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
