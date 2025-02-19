// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>
    /// The schedule properties for partial update. Properties not provided in the update request will not be changed.
    /// </summary>
    public partial class ScheduleUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdate __trackedResourceUpdate = new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.TrackedResourceUpdate();

        /// <summary>The frequency of this scheduled task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledFrequency? Frequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).Frequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).Frequency = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledFrequency)""); }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)__trackedResourceUpdate).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)__trackedResourceUpdate).Location = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ScheduleUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdateProperties _property;

        /// <summary>Properties of a schedule resource to be updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ScheduleUpdateProperties()); set => this._property = value; }

        /// <summary>Indicates whether or not this scheduled task is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduleEnableStatus? State { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).State = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduleEnableStatus)""); }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)__trackedResourceUpdate).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal)__trackedResourceUpdate).Tag = value ?? null /* model class */; }

        /// <summary>The target time to trigger the action. The format is HH:MM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string Time { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).Time; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).Time = value ?? null; }

        /// <summary>The IANA timezone id at which the schedule should execute.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public string TimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).TimeZone = value ?? null; }

        /// <summary>Supported type this scheduled task represents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledType? Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdatePropertiesInternal)Property).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledType)""); }

        /// <summary>Creates an new <see cref="ScheduleUpdate" /> instance.</summary>
        public ScheduleUpdate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResourceUpdate), __trackedResourceUpdate);
            await eventListener.AssertObjectIsValid(nameof(__trackedResourceUpdate), __trackedResourceUpdate);
        }
    }
    /// The schedule properties for partial update. Properties not provided in the update request will not be changed.
    public partial interface IScheduleUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdate
    {
        /// <summary>The frequency of this scheduled task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The frequency of this scheduled task.",
        SerializedName = @"frequency",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledFrequency) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledFrequency? Frequency { get; set; }
        /// <summary>Indicates whether or not this scheduled task is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether or not this scheduled task is enabled.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduleEnableStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduleEnableStatus? State { get; set; }
        /// <summary>The target time to trigger the action. The format is HH:MM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target time to trigger the action. The format is HH:MM.",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(string) })]
        string Time { get; set; }
        /// <summary>The IANA timezone id at which the schedule should execute.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IANA timezone id at which the schedule should execute.",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZone { get; set; }
        /// <summary>Supported type this scheduled task represents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Supported type this scheduled task represents.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledType? Type { get; set; }

    }
    /// The schedule properties for partial update. Properties not provided in the update request will not be changed.
    internal partial interface IScheduleUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITrackedResourceUpdateInternal
    {
        /// <summary>The frequency of this scheduled task.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledFrequency? Frequency { get; set; }
        /// <summary>Properties of a schedule resource to be updated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IScheduleUpdateProperties Property { get; set; }
        /// <summary>Indicates whether or not this scheduled task is enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduleEnableStatus? State { get; set; }
        /// <summary>The target time to trigger the action. The format is HH:MM.</summary>
        string Time { get; set; }
        /// <summary>The IANA timezone id at which the schedule should execute.</summary>
        string TimeZone { get; set; }
        /// <summary>Supported type this scheduled task represents.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ScheduledType? Type { get; set; }

    }
}