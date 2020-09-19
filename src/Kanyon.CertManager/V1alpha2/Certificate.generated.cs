using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.CertManager.V1alpha2
{
    public partial class Certificate : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "cert-manager.io/v1alpha2";
        [JsonProperty("kind")]
        public string Kind => "Certificate";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>CertificateSpec defines the desired state of Certificate. A valid Certificate requires at least one of a CommonName, DNSName, or URISAN to be valid.</summary> */
        public object spec { get; set; }
        /** <summary>CertificateStatus defines the observed state of Certificate</summary> */
        public object status { get; set; }
    }
}