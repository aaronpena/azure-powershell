// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HDInsight ondemand linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightOnDemand")]
    [Rest.Serialization.JsonTransformation]
    public partial class HDInsightOnDemandLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the HDInsightOnDemandLinkedService
        /// class.
        /// </summary>
        public HDInsightOnDemandLinkedService()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightOnDemandLinkedService
        /// class.
        /// </summary>
        /// <param name="clusterSize">Number of worker/data nodes in the
        /// cluster. Suggestion value: 4. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="timeToLive">The allowed idle time for the on-demand
        /// HDInsight cluster. Specifies how long the on-demand HDInsight
        /// cluster stays alive after completion of an activity run if there
        /// are no other active jobs in the cluster. The minimum value is 5
        /// mins. Type: string (or Expression with resultType string).</param>
        /// <param name="version">Version of the HDInsight cluster.  Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="linkedServiceName">Azure Storage linked service to be
        /// used by the on-demand cluster for storing and processing
        /// data.</param>
        /// <param name="hostSubscriptionId">The customer’s subscription to
        /// host the cluster. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="tenant">The Tenant id/name to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="clusterResourceGroup">The resource group where the
        /// cluster belongs. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="servicePrincipalId">The service principal id for the
        /// hostSubscriptionId. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="servicePrincipalKey">The key for the service principal
        /// id.</param>
        /// <param name="clusterNamePrefix">The prefix of cluster name, postfix
        /// will be distinct with timestamp. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="clusterUserName">The username to access the cluster.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="clusterPassword">The password to access the
        /// cluster.</param>
        /// <param name="clusterSshUserName">The username to SSH remotely
        /// connect to cluster’s node (for Linux). Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="clusterSshPassword">The password to SSH remotely
        /// connect cluster’s node (for Linux).</param>
        /// <param name="additionalLinkedServiceNames">Specifies additional
        /// storage accounts for the HDInsight linked service so that the Data
        /// Factory service can register them on your behalf.</param>
        /// <param name="hcatalogLinkedServiceName">The name of Azure SQL
        /// linked service that point to the HCatalog database. The on-demand
        /// HDInsight cluster is created by using the Azure SQL database as the
        /// metastore.</param>
        /// <param name="clusterType">The cluster type. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="sparkVersion">The version of spark if the cluster type
        /// is 'spark'. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="coreConfiguration">Specifies the core configuration
        /// parameters (as in core-site.xml) for the HDInsight cluster to be
        /// created.</param>
        /// <param name="hBaseConfiguration">Specifies the HBase configuration
        /// parameters (hbase-site.xml) for the HDInsight cluster.</param>
        /// <param name="hdfsConfiguration">Specifies the HDFS configuration
        /// parameters (hdfs-site.xml) for the HDInsight cluster.</param>
        /// <param name="hiveConfiguration">Specifies the hive configuration
        /// parameters (hive-site.xml) for the HDInsight cluster.</param>
        /// <param name="mapReduceConfiguration">Specifies the MapReduce
        /// configuration parameters (mapred-site.xml) for the HDInsight
        /// cluster.</param>
        /// <param name="oozieConfiguration">Specifies the Oozie configuration
        /// parameters (oozie-site.xml) for the HDInsight cluster.</param>
        /// <param name="stormConfiguration">Specifies the Storm configuration
        /// parameters (storm-site.xml) for the HDInsight cluster.</param>
        /// <param name="yarnConfiguration">Specifies the Yarn configuration
        /// parameters (yarn-site.xml) for the HDInsight cluster.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string.</param>
        /// <param name="headNodeSize">Specifies the size of the head node for
        /// the HDInsight cluster.</param>
        /// <param name="dataNodeSize">Specifies the size of the data node for
        /// the HDInsight cluster.</param>
        /// <param name="zookeeperNodeSize">Specifies the size of the Zoo
        /// Keeper node for the HDInsight cluster.</param>
        /// <param name="scriptActions">Custom script actions to run on HDI
        /// ondemand cluster once it's up. Please refer to
        /// https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-customize-cluster-linux?toc=%2Fen-us%2Fazure%2Fhdinsight%2Fr-server%2FTOC.json&amp;bc=%2Fen-us%2Fazure%2Fbread%2Ftoc.json#understanding-script-actions.</param>
        /// <param name="virtualNetworkId">The ARM resource ID for the vNet to
        /// which the cluster should be joined after creation. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="subnetName">The ARM resource ID for the subnet in the
        /// vNet. If virtualNetworkId was specified, then this property is
        /// required. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="credential">The credential reference containing
        /// authentication information.</param>
        public HDInsightOnDemandLinkedService(object clusterSize, object timeToLive, object version, LinkedServiceReference linkedServiceName, object hostSubscriptionId, object tenant, object clusterResourceGroup, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object servicePrincipalId = default(object), SecretBase servicePrincipalKey = default(SecretBase), object clusterNamePrefix = default(object), object clusterUserName = default(object), SecretBase clusterPassword = default(SecretBase), object clusterSshUserName = default(object), SecretBase clusterSshPassword = default(SecretBase), IList<LinkedServiceReference> additionalLinkedServiceNames = default(IList<LinkedServiceReference>), LinkedServiceReference hcatalogLinkedServiceName = default(LinkedServiceReference), object clusterType = default(object), object sparkVersion = default(object), object coreConfiguration = default(object), object hBaseConfiguration = default(object), object hdfsConfiguration = default(object), object hiveConfiguration = default(object), object mapReduceConfiguration = default(object), object oozieConfiguration = default(object), object stormConfiguration = default(object), object yarnConfiguration = default(object), string encryptedCredential = default(string), object headNodeSize = default(object), object dataNodeSize = default(object), object zookeeperNodeSize = default(object), IList<ScriptAction> scriptActions = default(IList<ScriptAction>), object virtualNetworkId = default(object), object subnetName = default(object), CredentialReference credential = default(CredentialReference))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            ClusterSize = clusterSize;
            TimeToLive = timeToLive;
            Version = version;
            LinkedServiceName = linkedServiceName;
            HostSubscriptionId = hostSubscriptionId;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            ClusterResourceGroup = clusterResourceGroup;
            ClusterNamePrefix = clusterNamePrefix;
            ClusterUserName = clusterUserName;
            ClusterPassword = clusterPassword;
            ClusterSshUserName = clusterSshUserName;
            ClusterSshPassword = clusterSshPassword;
            AdditionalLinkedServiceNames = additionalLinkedServiceNames;
            HcatalogLinkedServiceName = hcatalogLinkedServiceName;
            ClusterType = clusterType;
            SparkVersion = sparkVersion;
            CoreConfiguration = coreConfiguration;
            HBaseConfiguration = hBaseConfiguration;
            HdfsConfiguration = hdfsConfiguration;
            HiveConfiguration = hiveConfiguration;
            MapReduceConfiguration = mapReduceConfiguration;
            OozieConfiguration = oozieConfiguration;
            StormConfiguration = stormConfiguration;
            YarnConfiguration = yarnConfiguration;
            EncryptedCredential = encryptedCredential;
            HeadNodeSize = headNodeSize;
            DataNodeSize = dataNodeSize;
            ZookeeperNodeSize = zookeeperNodeSize;
            ScriptActions = scriptActions;
            VirtualNetworkId = virtualNetworkId;
            SubnetName = subnetName;
            Credential = credential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of worker/data nodes in the cluster. Suggestion
        /// value: 4. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clusterSize")]
        public object ClusterSize { get; set; }

        /// <summary>
        /// Gets or sets the allowed idle time for the on-demand HDInsight
        /// cluster. Specifies how long the on-demand HDInsight cluster stays
        /// alive after completion of an activity run if there are no other
        /// active jobs in the cluster. The minimum value is 5 mins. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.timeToLive")]
        public object TimeToLive { get; set; }

        /// <summary>
        /// Gets or sets version of the HDInsight cluster.  Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.version")]
        public object Version { get; set; }

        /// <summary>
        /// Gets or sets azure Storage linked service to be used by the
        /// on-demand cluster for storing and processing data.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.linkedServiceName")]
        public LinkedServiceReference LinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets the customer’s subscription to host the cluster. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hostSubscriptionId")]
        public object HostSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the service principal id for the hostSubscriptionId.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key for the service principal id.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the Tenant id/name to which the service principal
        /// belongs. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets the resource group where the cluster belongs. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clusterResourceGroup")]
        public object ClusterResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets the prefix of cluster name, postfix will be distinct
        /// with timestamp. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clusterNamePrefix")]
        public object ClusterNamePrefix { get; set; }

        /// <summary>
        /// Gets or sets the username to access the cluster. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clusterUserName")]
        public object ClusterUserName { get; set; }

        /// <summary>
        /// Gets or sets the password to access the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clusterPassword")]
        public SecretBase ClusterPassword { get; set; }

        /// <summary>
        /// Gets or sets the username to SSH remotely connect to cluster’s node
        /// (for Linux). Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clusterSshUserName")]
        public object ClusterSshUserName { get; set; }

        /// <summary>
        /// Gets or sets the password to SSH remotely connect cluster’s node
        /// (for Linux).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clusterSshPassword")]
        public SecretBase ClusterSshPassword { get; set; }

        /// <summary>
        /// Gets or sets specifies additional storage accounts for the
        /// HDInsight linked service so that the Data Factory service can
        /// register them on your behalf.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.additionalLinkedServiceNames")]
        public IList<LinkedServiceReference> AdditionalLinkedServiceNames { get; set; }

        /// <summary>
        /// Gets or sets the name of Azure SQL linked service that point to the
        /// HCatalog database. The on-demand HDInsight cluster is created by
        /// using the Azure SQL database as the metastore.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hcatalogLinkedServiceName")]
        public LinkedServiceReference HcatalogLinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets the cluster type. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clusterType")]
        public object ClusterType { get; set; }

        /// <summary>
        /// Gets or sets the version of spark if the cluster type is 'spark'.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sparkVersion")]
        public object SparkVersion { get; set; }

        /// <summary>
        /// Gets or sets specifies the core configuration parameters (as in
        /// core-site.xml) for the HDInsight cluster to be created.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.coreConfiguration")]
        public object CoreConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies the HBase configuration parameters
        /// (hbase-site.xml) for the HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hBaseConfiguration")]
        public object HBaseConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies the HDFS configuration parameters
        /// (hdfs-site.xml) for the HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hdfsConfiguration")]
        public object HdfsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies the hive configuration parameters
        /// (hive-site.xml) for the HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hiveConfiguration")]
        public object HiveConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies the MapReduce configuration parameters
        /// (mapred-site.xml) for the HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mapReduceConfiguration")]
        public object MapReduceConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies the Oozie configuration parameters
        /// (oozie-site.xml) for the HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.oozieConfiguration")]
        public object OozieConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies the Storm configuration parameters
        /// (storm-site.xml) for the HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.stormConfiguration")]
        public object StormConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies the Yarn configuration parameters
        /// (yarn-site.xml) for the HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.yarnConfiguration")]
        public object YarnConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public string EncryptedCredential { get; set; }

        /// <summary>
        /// Gets or sets specifies the size of the head node for the HDInsight
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.headNodeSize")]
        public object HeadNodeSize { get; set; }

        /// <summary>
        /// Gets or sets specifies the size of the data node for the HDInsight
        /// cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataNodeSize")]
        public object DataNodeSize { get; set; }

        /// <summary>
        /// Gets or sets specifies the size of the Zoo Keeper node for the
        /// HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.zookeeperNodeSize")]
        public object ZookeeperNodeSize { get; set; }

        /// <summary>
        /// Gets or sets custom script actions to run on HDI ondemand cluster
        /// once it's up. Please refer to
        /// https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-customize-cluster-linux?toc=%2Fen-us%2Fazure%2Fhdinsight%2Fr-server%2FTOC.json&amp;amp;bc=%2Fen-us%2Fazure%2Fbread%2Ftoc.json#understanding-script-actions.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scriptActions")]
        public IList<ScriptAction> ScriptActions { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource ID for the vNet to which the cluster
        /// should be joined after creation. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.virtualNetworkId")]
        public object VirtualNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource ID for the subnet in the vNet. If
        /// virtualNetworkId was specified, then this property is required.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.subnetName")]
        public object SubnetName { get; set; }

        /// <summary>
        /// Gets or sets the credential reference containing authentication
        /// information.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.credential")]
        public CredentialReference Credential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ClusterSize == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClusterSize");
            }
            if (TimeToLive == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeToLive");
            }
            if (Version == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Version");
            }
            if (LinkedServiceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LinkedServiceName");
            }
            if (HostSubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostSubscriptionId");
            }
            if (Tenant == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tenant");
            }
            if (ClusterResourceGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClusterResourceGroup");
            }
            if (LinkedServiceName != null)
            {
                LinkedServiceName.Validate();
            }
            if (AdditionalLinkedServiceNames != null)
            {
                foreach (var element in AdditionalLinkedServiceNames)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (HcatalogLinkedServiceName != null)
            {
                HcatalogLinkedServiceName.Validate();
            }
            if (ScriptActions != null)
            {
                foreach (var element1 in ScriptActions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Credential != null)
            {
                Credential.Validate();
            }
        }
    }
}
