/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the CreateService operation.
    /// Creates a service, which defines the configuration for the following entities:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For public and private DNS namespaces, one of the following combinations of DNS records
    /// in Amazon Route 53:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AAAA
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A and AAAA
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// SRV
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CNAME
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Optionally, a health check
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After you create the service, you can submit a <a>RegisterInstance</a> request, and
    /// AWS Cloud Map uses the values in the configuration to create the specified entities.
    /// </para>
    ///  
    /// <para>
    /// For the current limit on the number of instances that you can register using the same
    /// namespace and using the same service, see <a href="http://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">AWS
    /// Cloud Map Limits</a> in the <i>AWS Cloud Map Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateServiceRequest : AmazonServiceDiscoveryRequest
    {
        private string _creatorRequestId;
        private string _description;
        private DnsConfig _dnsConfig;
        private HealthCheckConfig _healthCheckConfig;
        private HealthCheckCustomConfig _healthCheckCustomConfig;
        private string _name;
        private string _namespaceId;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed <code>CreateService</code>
        /// requests to be retried without the risk of executing the operation twice. <code>CreatorRequestId</code>
        /// can be any unique string, for example, a date/time stamp.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the service.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DnsConfig. 
        /// <para>
        /// A complex type that contains information about the Amazon Route 53 records that you
        /// want AWS Cloud Map to create when you register an instance. 
        /// </para>
        /// </summary>
        public DnsConfig DnsConfig
        {
            get { return this._dnsConfig; }
            set { this._dnsConfig = value; }
        }

        // Check to see if DnsConfig property is set
        internal bool IsSetDnsConfig()
        {
            return this._dnsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckConfig. 
        /// <para>
        ///  <i>Public DNS namespaces only.</i> A complex type that contains settings for an optional
        /// Route 53 health check. If you specify settings for a health check, AWS Cloud Map associates
        /// the health check with all the Route 53 DNS records that you specify in <code>DnsConfig</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a health check configuration, you can specify either <code>HealthCheckCustomConfig</code>
        /// or <code>HealthCheckConfig</code> but not both.
        /// </para>
        ///  </important> 
        /// <para>
        /// For information about the charges for health checks, see <a href="http://aws.amazon.com/cloud-map/pricing/">AWS
        /// Cloud Map Pricing</a>.
        /// </para>
        /// </summary>
        public HealthCheckConfig HealthCheckConfig
        {
            get { return this._healthCheckConfig; }
            set { this._healthCheckConfig = value; }
        }

        // Check to see if HealthCheckConfig property is set
        internal bool IsSetHealthCheckConfig()
        {
            return this._healthCheckConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckCustomConfig. 
        /// <para>
        /// A complex type that contains information about an optional custom health check.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a health check configuration, you can specify either <code>HealthCheckCustomConfig</code>
        /// or <code>HealthCheckConfig</code> but not both.
        /// </para>
        ///  </important>
        /// </summary>
        public HealthCheckCustomConfig HealthCheckCustomConfig
        {
            get { return this._healthCheckCustomConfig; }
            set { this._healthCheckCustomConfig = value; }
        }

        // Check to see if HealthCheckCustomConfig property is set
        internal bool IsSetHealthCheckCustomConfig()
        {
            return this._healthCheckCustomConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you want to assign to the service.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The ID of the namespace that you want to use to create the service.
        /// </para>
        /// </summary>
        public string NamespaceId
        {
            get { return this._namespaceId; }
            set { this._namespaceId = value; }
        }

        // Check to see if NamespaceId property is set
        internal bool IsSetNamespaceId()
        {
            return this._namespaceId != null;
        }

    }
}