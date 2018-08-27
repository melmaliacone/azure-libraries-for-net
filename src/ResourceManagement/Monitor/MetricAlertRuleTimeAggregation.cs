// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// Defines values for MetricAlertRuleTimeAggregation.
    /// </summary>
    public sealed partial class MetricAlertRuleTimeAggregation : ExpandableStringEnum<MetricAlertRuleTimeAggregation>
    {
        public static readonly MetricAlertRuleTimeAggregation Average = Parse("Average");
        public static readonly MetricAlertRuleTimeAggregation Minimum = Parse("Minimum");
        public static readonly MetricAlertRuleTimeAggregation Maximum = Parse("Maximum");
        public static readonly MetricAlertRuleTimeAggregation Total = Parse("Total");
    }
}