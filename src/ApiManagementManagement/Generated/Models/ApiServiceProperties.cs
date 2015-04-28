// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.ApiManagement.Models;

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    /// <summary>
    /// Properties of an Api Management service resource description.
    /// </summary>
    public partial class ApiServiceProperties
    {
        private IList<AdditionalRegion> _additionalRegions;
        
        /// <summary>
        /// Optional. Gets or sets additional datacenter locations description
        /// of the Api Management service.
        /// </summary>
        public IList<AdditionalRegion> AdditionalRegions
        {
            get { return this._additionalRegions; }
            set { this._additionalRegions = value; }
        }
        
        private string _addresserEmail;
        
        /// <summary>
        /// Optional. Gets or sets addresser email.
        /// </summary>
        public string AddresserEmail
        {
            get { return this._addresserEmail; }
            set { this._addresserEmail = value; }
        }
        
        private DateTime _createdAtUtc;
        
        /// <summary>
        /// Optional. Gets or sets creation UTC date of the Api Management
        /// service.
        /// </summary>
        public DateTime CreatedAtUtc
        {
            get { return this._createdAtUtc; }
            set { this._createdAtUtc = value; }
        }
        
        private IDictionary<string, string> _customProperties;
        
        /// <summary>
        /// Optional. Gets or sets CustomProperties of the Api Management
        /// service.
        /// </summary>
        public IDictionary<string, string> CustomProperties
        {
            get { return this._customProperties; }
            set { this._customProperties = value; }
        }
        
        private IList<HostnameConfiguration> _hostnameConfigurations;
        
        /// <summary>
        /// Optional. Gets or sets custom hostname configuration of the Api
        /// Management service.
        /// </summary>
        public IList<HostnameConfiguration> HostnameConfigurations
        {
            get { return this._hostnameConfigurations; }
            set { this._hostnameConfigurations = value; }
        }
        
        private string _managementPortalEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets management portal endpoint Url of the Api
        /// Management service.
        /// </summary>
        public string ManagementPortalEndpoint
        {
            get { return this._managementPortalEndpoint; }
            set { this._managementPortalEndpoint = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets provisioning state of the Api Management
        /// service.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _proxyEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets proxy endpoint Url of the Api Management
        /// service.
        /// </summary>
        public string ProxyEndpoint
        {
            get { return this._proxyEndpoint; }
            set { this._proxyEndpoint = value; }
        }
        
        private string _publisherEmail;
        
        /// <summary>
        /// Optional. Gets or sets publisher email.
        /// </summary>
        public string PublisherEmail
        {
            get { return this._publisherEmail; }
            set { this._publisherEmail = value; }
        }
        
        private string _publisherName;
        
        /// <summary>
        /// Optional. Gets or sets publisher name.
        /// </summary>
        public string PublisherName
        {
            get { return this._publisherName; }
            set { this._publisherName = value; }
        }
        
        private ApiServiceSkuProperties _skuProperties;
        
        /// <summary>
        /// Optional. Gets or sets sku properties of the Api Management service.
        /// </summary>
        public ApiServiceSkuProperties SkuProperties
        {
            get { return this._skuProperties; }
            set { this._skuProperties = value; }
        }
        
        private IList<string> _staticIPs;
        
        /// <summary>
        /// Optional. Gets or sets static ip addresses of the Api Management
        /// service virtual machines. Available only for Standard and Premium
        /// Sku.
        /// </summary>
        public IList<string> StaticIPs
        {
            get { return this._staticIPs; }
            set { this._staticIPs = value; }
        }
        
        private string _targetProvisioningState;
        
        /// <summary>
        /// Optional. Gets or sets target provisioning state of the Api
        /// Management service.The state that is targeted for the Api
        /// Management service by the infrastructure.
        /// </summary>
        public string TargetProvisioningState
        {
            get { return this._targetProvisioningState; }
            set { this._targetProvisioningState = value; }
        }
        
        private VirtualNetworkConfiguration _virtualNetworkConfiguration;
        
        /// <summary>
        /// Optional. Gets or sets virtual network configuration of the Api
        /// Management service .
        /// </summary>
        public VirtualNetworkConfiguration VirtualNetworkConfiguration
        {
            get { return this._virtualNetworkConfiguration; }
            set { this._virtualNetworkConfiguration = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiServiceProperties class.
        /// </summary>
        public ApiServiceProperties()
        {
            this.AdditionalRegions = new LazyList<AdditionalRegion>();
            this.CustomProperties = new LazyDictionary<string, string>();
            this.HostnameConfigurations = new LazyList<HostnameConfiguration>();
            this.StaticIPs = new LazyList<string>();
        }
    }
}
