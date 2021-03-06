namespace net.openstack.Providers.Rackspace.Objects.Request
{
    using System;
    using net.openstack.Core.Domain;
    using Newtonsoft.Json;

    /// <summary>
    /// This models the JSON body containing details for the Reboot Server request.
    /// </summary>
    /// <seealso cref="ServerRebootRequest"/>
    /// <seealso href="http://docs.openstack.org/api/openstack-compute/2/content/Reboot_Server-d1e3371.html">Reboot Server (OpenStack Compute API v2 and Extensions Reference)</seealso>
    [JsonObject(MemberSerialization.OptIn)]
    internal class ServerRebootDetails
    {
        [JsonProperty("type")]
        private string _type;

        /// <summary>
        /// Gets the type of reboot to perform.
        /// </summary>
        public RebootType Type
        {
            get
            {
                if (string.IsNullOrEmpty(_type))
                    return null;

                return RebootType.FromName(_type);
            }

            private set
            {
                if (value == null)
                    _type = null;
                else
                    _type = value.Name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerRebootDetails"/>
        /// class with the specified reboot type.
        /// </summary>
        /// <param name="type">The type of reboot to perform. See <see cref="RebootType"/> for predefined values.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="type"/> is <c>null</c>.</exception>
        public ServerRebootDetails(RebootType type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            Type = type;
        }
    }
}