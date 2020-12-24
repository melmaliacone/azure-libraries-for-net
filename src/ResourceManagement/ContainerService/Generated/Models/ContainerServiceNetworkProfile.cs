// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Profile of network configuration.
    /// </summary>
    public partial class ContainerServiceNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceNetworkProfile
        /// class.
        /// </summary>
        public ContainerServiceNetworkProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceNetworkProfile
        /// class.
        /// </summary>
        /// <param name="networkPlugin">Network plugin used for building
        /// Kubernetes network. Possible values include: 'azure',
        /// 'kubenet'</param>
        /// <param name="networkPolicy">Network policy used for building
        /// Kubernetes network. Possible values include: 'calico',
        /// 'azure'</param>
        /// <param name="networkMode">Network mode used for building Kubernetes
        /// network. Possible values include: 'transparent', 'bridge'</param>
        /// <param name="podCidr">A CIDR notation IP range from which to assign
        /// pod IPs when kubenet is used.</param>
        /// <param name="serviceCidr">A CIDR notation IP range from which to
        /// assign service cluster IPs. It must not overlap with any Subnet IP
        /// ranges.</param>
        /// <param name="dnsServiceIP">An IP address assigned to the Kubernetes
        /// DNS service. It must be within the Kubernetes service address range
        /// specified in serviceCidr.</param>
        /// <param name="dockerBridgeCidr">A CIDR notation IP range assigned to
        /// the Docker bridge network. It must not overlap with any Subnet IP
        /// ranges or the Kubernetes service address range.</param>
        /// <param name="outboundType">The outbound (egress) routing method.
        /// Possible values include: 'loadBalancer',
        /// 'userDefinedRouting'</param>
        /// <param name="loadBalancerSku">The load balancer sku for the managed
        /// cluster. Possible values include: 'standard', 'basic'</param>
        /// <param name="loadBalancerProfile">Profile of the cluster load
        /// balancer.</param>
        public ContainerServiceNetworkProfile(NetworkPlugin networkPlugin = default(NetworkPlugin), NetworkPolicy networkPolicy = default(NetworkPolicy), NetworkMode networkMode = default(NetworkMode), string podCidr = default(string), string serviceCidr = default(string), string dnsServiceIP = default(string), string dockerBridgeCidr = default(string), OutboundType outboundType = default(OutboundType), LoadBalancerSku loadBalancerSku = default(LoadBalancerSku), ManagedClusterLoadBalancerProfile loadBalancerProfile = default(ManagedClusterLoadBalancerProfile))
        {
            NetworkPlugin = networkPlugin;
            NetworkPolicy = networkPolicy;
            NetworkMode = networkMode;
            PodCidr = podCidr;
            ServiceCidr = serviceCidr;
            DnsServiceIP = dnsServiceIP;
            DockerBridgeCidr = dockerBridgeCidr;
            OutboundType = outboundType;
            LoadBalancerSku = loadBalancerSku;
            LoadBalancerProfile = loadBalancerProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets network plugin used for building Kubernetes network.
        /// Possible values include: 'azure', 'kubenet'
        /// </summary>
        [JsonProperty(PropertyName = "networkPlugin")]
        public NetworkPlugin NetworkPlugin { get; set; }

        /// <summary>
        /// Gets or sets network policy used for building Kubernetes network.
        /// Possible values include: 'calico', 'azure'
        /// </summary>
        [JsonProperty(PropertyName = "networkPolicy")]
        public NetworkPolicy NetworkPolicy { get; set; }

        /// <summary>
        /// Gets or sets network mode used for building Kubernetes network.
        /// Possible values include: 'transparent', 'bridge'
        /// </summary>
        [JsonProperty(PropertyName = "networkMode")]
        public NetworkMode NetworkMode { get; set; }

        /// <summary>
        /// Gets or sets a CIDR notation IP range from which to assign pod IPs
        /// when kubenet is used.
        /// </summary>
        [JsonProperty(PropertyName = "podCidr")]
        public string PodCidr { get; set; }

        /// <summary>
        /// Gets or sets a CIDR notation IP range from which to assign service
        /// cluster IPs. It must not overlap with any Subnet IP ranges.
        /// </summary>
        [JsonProperty(PropertyName = "serviceCidr")]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// Gets or sets an IP address assigned to the Kubernetes DNS service.
        /// It must be within the Kubernetes service address range specified in
        /// serviceCidr.
        /// </summary>
        [JsonProperty(PropertyName = "dnsServiceIP")]
        public string DnsServiceIP { get; set; }

        /// <summary>
        /// Gets or sets a CIDR notation IP range assigned to the Docker bridge
        /// network. It must not overlap with any Subnet IP ranges or the
        /// Kubernetes service address range.
        /// </summary>
        [JsonProperty(PropertyName = "dockerBridgeCidr")]
        public string DockerBridgeCidr { get; set; }

        /// <summary>
        /// Gets or sets the outbound (egress) routing method. Possible values
        /// include: 'loadBalancer', 'userDefinedRouting'
        /// </summary>
        [JsonProperty(PropertyName = "outboundType")]
        public OutboundType OutboundType { get; set; }

        /// <summary>
        /// Gets or sets the load balancer sku for the managed cluster.
        /// Possible values include: 'standard', 'basic'
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerSku")]
        public LoadBalancerSku LoadBalancerSku { get; set; }

        /// <summary>
        /// Gets or sets profile of the cluster load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerProfile")]
        public ManagedClusterLoadBalancerProfile LoadBalancerProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PodCidr != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(PodCidr, "^([0-9]{1,3}\\.){3}[0-9]{1,3}(\\/([0-9]|[1-2][0-9]|3[0-2]))?$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "PodCidr", "^([0-9]{1,3}\\.){3}[0-9]{1,3}(\\/([0-9]|[1-2][0-9]|3[0-2]))?$");
                }
            }
            if (ServiceCidr != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(ServiceCidr, "^([0-9]{1,3}\\.){3}[0-9]{1,3}(\\/([0-9]|[1-2][0-9]|3[0-2]))?$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ServiceCidr", "^([0-9]{1,3}\\.){3}[0-9]{1,3}(\\/([0-9]|[1-2][0-9]|3[0-2]))?$");
                }
            }
            if (DnsServiceIP != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(DnsServiceIP, "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "DnsServiceIP", "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
                }
            }
            if (DockerBridgeCidr != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(DockerBridgeCidr, "^([0-9]{1,3}\\.){3}[0-9]{1,3}(\\/([0-9]|[1-2][0-9]|3[0-2]))?$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "DockerBridgeCidr", "^([0-9]{1,3}\\.){3}[0-9]{1,3}(\\/([0-9]|[1-2][0-9]|3[0-2]))?$");
                }
            }
            if (LoadBalancerProfile != null)
            {
                LoadBalancerProfile.Validate();
            }
        }
    }
}
