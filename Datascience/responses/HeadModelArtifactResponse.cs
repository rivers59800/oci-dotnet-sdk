/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.DatascienceService.Models;

namespace Oci.DatascienceService.Responses
{
    public class HeadModelArtifactResponse : Oci.Common.OciResponse
    {

        /// <value>
        /// For optimistic concurrency control. See [ETags for Optimistic Concurrency Control](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#eleven).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "etag")]
        public string Etag { get; set; }


        /// <value>
        /// Unique Oracle assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, then provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// The content size of the body in bytes.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-length")]
        public System.Nullable<long> ContentLength { get; set; }


        /// <value>
        /// The content disposition of the body, as described in [RFC 2616](https://tools.ietf.org/rfc/rfc2616), section 19.5.1.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-disposition")]
        public string ContentDisposition { get; set; }


        /// <value>
        /// The base-64 encoded MD5 hash of the body, as described in [RFC 2616](https://tools.ietf.org/rfc/rfc2616), section 14.15.
        /// Unavailable for objects uploaded using multipart upload.
        /// If the `content-md5` header is present, Object Storage performs an integrity check on the body of the HTTP request by computing the MD5 hash for the body and comparing it to the MD5 hash supplied in the header.
        /// If the two hashes do not match, the object is rejected and an HTTP-400 Unmatched Content MD5 error is returned with the message:
        /// \"The computed MD5 of the request body (ACTUAL_MD5) does not match the Content-MD5 header (HEADER_MD5)\"
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-md5")]
        public string ContentMd5 { get; set; }


        /// <value>
        /// The artifact modification time, as described in [RFC 2616](https://tools.ietf.org/rfc/rfc2616), section 14.29.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "last-modified")]
        public System.Nullable<System.DateTime> LastModified { get; set; }



    }
}
