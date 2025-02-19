﻿/*
 * Copyright 2021-Present The Serverless Workflow Specification Authors
 * <p>
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * <p>
 * http://www.apache.org/licenses/LICENSE-2.0
 * <p>
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using ServerlessWorkflow.Sdk.Models;

namespace ServerlessWorkflow.Sdk.Services.FluentBuilders
{
    /// <summary>
    /// Defines the fundamentals of a service used to build a collection of <see cref="ActionDefinition"/>s
    /// </summary>
    /// <typeparam name="TContainer"></typeparam>
    public interface IActionCollectionBuilder<TContainer>
        : IActionContainerBuilder<TContainer>
        where TContainer : class, IActionCollectionBuilder<TContainer>
    {

        /// <summary>
        /// Configures the container to run defined actions sequentially
        /// </summary>
        /// <returns>The configured container</returns>
        TContainer Sequentially();

        /// <summary>
        /// Configures the container to run defined actions concurrently
        /// </summary>
        /// <returns>The configured container</returns>
        TContainer Concurrently();

    }

}
