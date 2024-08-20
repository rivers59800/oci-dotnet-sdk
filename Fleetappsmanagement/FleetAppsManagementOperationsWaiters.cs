/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.FleetappsmanagementService.Models;
using Oci.FleetappsmanagementService.Requests;
using Oci.FleetappsmanagementService.Responses;

namespace Oci.FleetappsmanagementService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of FleetAppsManagementOperations.
    /// </summary>
    public class FleetAppsManagementOperationsWaiters
    {
        private readonly FleetAppsManagementOperationsClient client;

        public  FleetAppsManagementOperationsWaiters(FleetAppsManagementOperationsClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSchedulerDefinitionRequest, GetSchedulerDefinitionResponse> ForSchedulerDefinition(GetSchedulerDefinitionRequest request, params SchedulerDefinition.LifecycleStateEnum[] targetStates)
        {
            return this.ForSchedulerDefinition(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSchedulerDefinitionRequest, GetSchedulerDefinitionResponse> ForSchedulerDefinition(GetSchedulerDefinitionRequest request, WaiterConfiguration config, params SchedulerDefinition.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetSchedulerDefinitionRequest, GetSchedulerDefinitionResponse>(
                request,
                request => client.GetSchedulerDefinition(request),
                response => targetStates.Contains(response.SchedulerDefinition.LifecycleState.Value),
                targetStates.Contains(SchedulerDefinition.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetSchedulerDefinitionRequest, GetSchedulerDefinitionResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSchedulerJobRequest, GetSchedulerJobResponse> ForSchedulerJob(GetSchedulerJobRequest request, params SchedulerJob.LifecycleStateEnum[] targetStates)
        {
            return this.ForSchedulerJob(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSchedulerJobRequest, GetSchedulerJobResponse> ForSchedulerJob(GetSchedulerJobRequest request, WaiterConfiguration config, params SchedulerJob.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetSchedulerJobRequest, GetSchedulerJobResponse>(
                request,
                request => client.GetSchedulerJob(request),
                response => targetStates.Contains(response.SchedulerJob.LifecycleState.Value),
                targetStates.Contains(SchedulerJob.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetSchedulerJobRequest, GetSchedulerJobResponse>(config, agent);
        }
    }
}
