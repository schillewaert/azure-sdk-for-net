// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.AccessControl.Models
{
    /// <summary> Role Assignment response details. </summary>
    public partial class RoleAssignmentDetails
    {
        /// <summary> Initializes a new instance of RoleAssignmentDetails. </summary>
        internal RoleAssignmentDetails()
        {
        }

        /// <summary> Initializes a new instance of RoleAssignmentDetails. </summary>
        /// <param name="id"> Role Assignment ID. </param>
        /// <param name="roleId"> Role ID of the Synapse Built-In Role. </param>
        /// <param name="principalId"> Object ID of the AAD principal or security-group. </param>
        internal RoleAssignmentDetails(string id, string roleId, string principalId)
        {
            Id = id;
            RoleId = roleId;
            PrincipalId = principalId;
        }

        /// <summary> Role Assignment ID. </summary>
        public string Id { get; }
        /// <summary> Role ID of the Synapse Built-In Role. </summary>
        public string RoleId { get; }
        /// <summary> Object ID of the AAD principal or security-group. </summary>
        public string PrincipalId { get; }
    }
}
