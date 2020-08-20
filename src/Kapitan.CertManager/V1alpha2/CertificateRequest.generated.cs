using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.CertManager.V1alpha2
{
    public partial class CertificateRequest : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "cert-manager.io/v1alpha2";
        [JsonProperty("kind")]
        public string Kind => "CertificateRequest";

        /** <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary> */
        public Core.V1.ObjectMeta metadata { get; set; }
        /** <summary>CertificateRequestSpec defines the desired state of CertificateRequest</summary> */
        public object spec { get; set; }
        /** <summary>CertificateStatus defines the observed state of CertificateRequest and resulting signed certificate.</summary> */
        public object status { get; set; }
    }
}