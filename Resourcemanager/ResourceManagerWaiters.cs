/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.ResourcemanagerService.Models;
using Oci.ResourcemanagerService.Requests;
using Oci.ResourcemanagerService.Responses;

namespace Oci.ResourcemanagerService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of ResourceManager.
    /// </summary>
    public class ResourceManagerWaiters
    {
        private readonly ResourceManagerClient client;

        public  ResourceManagerWaiters(ResourceManagerClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConfigurationSourceProviderRequest, GetConfigurationSourceProviderResponse> ForConfigurationSourceProvider(GetConfigurationSourceProviderRequest request, params ConfigurationSourceProvider.LifecycleStateEnum[] targetStates)
        {
            return this.ForConfigurationSourceProvider(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConfigurationSourceProviderRequest, GetConfigurationSourceProviderResponse> ForConfigurationSourceProvider(GetConfigurationSourceProviderRequest request, WaiterConfiguration config, params ConfigurationSourceProvider.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetConfigurationSourceProviderRequest, GetConfigurationSourceProviderResponse>(
                request,
                request => client.GetConfigurationSourceProvider(request),
                response => targetStates.Contains(response.ConfigurationSourceProvider.LifecycleState.Value)
            );
            return new Waiter<GetConfigurationSourceProviderRequest, GetConfigurationSourceProviderResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetJobRequest, GetJobResponse> ForJob(GetJobRequest request, params Job.LifecycleStateEnum[] targetStates)
        {
            return this.ForJob(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetJobRequest, GetJobResponse> ForJob(GetJobRequest request, WaiterConfiguration config, params Job.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetJobRequest, GetJobResponse>(
                request,
                request => client.GetJob(request),
                response => targetStates.Contains(response.Job.LifecycleState.Value)
            );
            return new Waiter<GetJobRequest, GetJobResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetStackRequest, GetStackResponse> ForStack(GetStackRequest request, params Stack.LifecycleStateEnum[] targetStates)
        {
            return this.ForStack(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetStackRequest, GetStackResponse> ForStack(GetStackRequest request, WaiterConfiguration config, params Stack.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetStackRequest, GetStackResponse>(
                request,
                request => client.GetStack(request),
                response => targetStates.Contains(response.Stack.LifecycleState.Value),
                targetStates.Contains(Stack.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetStackRequest, GetStackResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTemplateRequest, GetTemplateResponse> ForTemplate(GetTemplateRequest request, params Template.LifecycleStateEnum[] targetStates)
        {
            return this.ForTemplate(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTemplateRequest, GetTemplateResponse> ForTemplate(GetTemplateRequest request, WaiterConfiguration config, params Template.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTemplateRequest, GetTemplateResponse>(
                request,
                request => client.GetTemplate(request),
                response => targetStates.Contains(response.Template.LifecycleState.Value)
            );
            return new Waiter<GetTemplateRequest, GetTemplateResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params WorkRequest.StatusEnum[] targetStates)
        {
            return this.ForWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params WorkRequest.StatusEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
    }
}
