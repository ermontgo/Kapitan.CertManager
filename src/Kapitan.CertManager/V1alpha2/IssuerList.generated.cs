using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Core;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.CertManager.V1alpha2
{
    public partial class IssuerList : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "cert-manager.io/v1alpha2";
        [JsonProperty("kind")]
        public string Kind => "IssuerList";

        /** <summary>List of issuers. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md</summary> */
        public List<Issuer> items { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary> */
        public object metadata { get; set; }
    }
}