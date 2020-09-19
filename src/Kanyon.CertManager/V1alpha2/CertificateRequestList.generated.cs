using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kanyon.Core;
using Kanyon.Kubernetes;

namespace Kanyon.Kubernetes.CertManager.V1alpha2
{
    public partial class CertificateRequestList : IManifestObject
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion => "cert-manager.io/v1alpha2";
        [JsonProperty("kind")]
        public string Kind => "CertificateRequestList";

        /** <summary>List of certificaterequests. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md</summary> */
        public List<CertificateRequest> items { get; set; }
        /** <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary> */
        public string kind { get; set; }
        /** <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary> */
        public object metadata { get; set; }
    }
}