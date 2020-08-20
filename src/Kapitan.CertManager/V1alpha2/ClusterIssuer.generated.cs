using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.CertManager.V1alpha2
{
    public partial class ClusterIssuer : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "cert-manager.io/v1alpha2";
        [JsonProperty("kind")]
        public string Kind => "ClusterIssuer";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>IssuerSpec is the specification of an Issuer. This includes any configuration required for the issuer.</summary> */
        public object spec { get; set; }
        /** <summary>IssuerStatus contains status information about an Issuer</summary> */
        public object status { get; set; }
    }
}