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
namespace ServerlessWorkflow.Sdk.Models
{

    /// <summary>
    /// Represents the object used to configure how actions filter the state data for both input and output
    /// </summary>
    public class ActionDataFilterDefinition
    {

        /// <summary>
        /// Gets/sets an expression that filters state data that can be used by the action
        /// </summary>
        public virtual string FromStateData { get; set; }

        /// <summary>
        /// Gets/sets an expression that filters the actions data results
        /// </summary>
        public virtual string Results { get; set; }

        /// <summary>
        /// Gets/sets an expression that selects a state data element to which the action results should be added/merged into. If not specified denotes the top-level state data element
        /// </summary>
        public virtual string ToStateData { get; set; }

    }

}