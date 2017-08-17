// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WorkflowProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowProvisioningState
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Ready")]
        Ready,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Deleting")]
        Deleting,
        [EnumMember(Value = "Deleted")]
        Deleted,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Moving")]
        Moving,
        [EnumMember(Value = "Updating")]
        Updating,
        [EnumMember(Value = "Registering")]
        Registering,
        [EnumMember(Value = "Registered")]
        Registered,
        [EnumMember(Value = "Unregistering")]
        Unregistering,
        [EnumMember(Value = "Unregistered")]
        Unregistered,
        [EnumMember(Value = "Completed")]
        Completed
    }
    internal static class WorkflowProvisioningStateEnumExtension
    {
        internal static string ToSerializedValue(this WorkflowProvisioningState? value)
        {
            return value == null ? null : ((WorkflowProvisioningState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WorkflowProvisioningState value)
        {
            switch( value )
            {
                case WorkflowProvisioningState.NotSpecified:
                    return "NotSpecified";
                case WorkflowProvisioningState.Accepted:
                    return "Accepted";
                case WorkflowProvisioningState.Running:
                    return "Running";
                case WorkflowProvisioningState.Ready:
                    return "Ready";
                case WorkflowProvisioningState.Creating:
                    return "Creating";
                case WorkflowProvisioningState.Created:
                    return "Created";
                case WorkflowProvisioningState.Deleting:
                    return "Deleting";
                case WorkflowProvisioningState.Deleted:
                    return "Deleted";
                case WorkflowProvisioningState.Canceled:
                    return "Canceled";
                case WorkflowProvisioningState.Failed:
                    return "Failed";
                case WorkflowProvisioningState.Succeeded:
                    return "Succeeded";
                case WorkflowProvisioningState.Moving:
                    return "Moving";
                case WorkflowProvisioningState.Updating:
                    return "Updating";
                case WorkflowProvisioningState.Registering:
                    return "Registering";
                case WorkflowProvisioningState.Registered:
                    return "Registered";
                case WorkflowProvisioningState.Unregistering:
                    return "Unregistering";
                case WorkflowProvisioningState.Unregistered:
                    return "Unregistered";
                case WorkflowProvisioningState.Completed:
                    return "Completed";
            }
            return null;
        }

        internal static WorkflowProvisioningState? ParseWorkflowProvisioningState(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return WorkflowProvisioningState.NotSpecified;
                case "Accepted":
                    return WorkflowProvisioningState.Accepted;
                case "Running":
                    return WorkflowProvisioningState.Running;
                case "Ready":
                    return WorkflowProvisioningState.Ready;
                case "Creating":
                    return WorkflowProvisioningState.Creating;
                case "Created":
                    return WorkflowProvisioningState.Created;
                case "Deleting":
                    return WorkflowProvisioningState.Deleting;
                case "Deleted":
                    return WorkflowProvisioningState.Deleted;
                case "Canceled":
                    return WorkflowProvisioningState.Canceled;
                case "Failed":
                    return WorkflowProvisioningState.Failed;
                case "Succeeded":
                    return WorkflowProvisioningState.Succeeded;
                case "Moving":
                    return WorkflowProvisioningState.Moving;
                case "Updating":
                    return WorkflowProvisioningState.Updating;
                case "Registering":
                    return WorkflowProvisioningState.Registering;
                case "Registered":
                    return WorkflowProvisioningState.Registered;
                case "Unregistering":
                    return WorkflowProvisioningState.Unregistering;
                case "Unregistered":
                    return WorkflowProvisioningState.Unregistered;
                case "Completed":
                    return WorkflowProvisioningState.Completed;
            }
            return null;
        }
    }
}