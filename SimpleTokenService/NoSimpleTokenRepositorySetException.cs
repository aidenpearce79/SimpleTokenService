﻿using System;
using System.Runtime.Serialization;

namespace Ng.Services
{
    /// <summary>
    /// Thrown when no repository is set for Simple Tokens
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class NoSimpleTokenRepositorySetException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSimpleTokenRepositorySetException"/> class.
        /// </summary>
        public NoSimpleTokenRepositorySetException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoSimpleTokenRepositorySetException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public NoSimpleTokenRepositorySetException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoSimpleTokenRepositorySetException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<see langword="Nothing" /> in Visual Basic) if no inner exception is specified.</param>
        public NoSimpleTokenRepositorySetException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoSimpleTokenRepositorySetException"/> class.
        /// </summary>
        protected NoSimpleTokenRepositorySetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}