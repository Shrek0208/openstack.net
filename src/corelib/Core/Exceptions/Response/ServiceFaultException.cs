using System;
using System.Net;
using System.Runtime.Serialization;
using RestResponse = JSIStudios.SimpleRESTServices.Client.Response;

namespace net.openstack.Core.Exceptions.Response
{
    /// <summary>
    /// Represents errors with status code <see cref="HttpStatusCode.InternalServerError"/> resulting
    /// from a call to a REST API.
    /// </summary>
    [Serializable]
    public class ServiceFaultException : ResponseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceFaultException"/> class with the
        /// specified REST response.
        /// </summary>
        /// <param name="response">The REST response.</param>
        public ServiceFaultException(RestResponse response)
            : base("There was an unhandled error at the service endpoint.  Please try again later.", response)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceFaultException"/> class with the
        /// specified error message and REST response.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="response">The REST response.</param>
        public ServiceFaultException(string message, RestResponse response)
            : base(message, response)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceFaultException"/> class with
        /// serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="info"/> is <c>null</c>.</exception>
        protected ServiceFaultException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
