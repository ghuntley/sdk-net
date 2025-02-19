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
using System.Collections.Generic;

namespace ServerlessWorkflow.Sdk.Models
{
    /// <summary>
    /// Represents a workflow execution branch
    /// </summary>
    public class BranchDefinition
    {

        /// <summary>
        /// gets/sets the branch's name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets/sets the unique id of a workflow to be executed in this branch
        /// </summary>
        public virtual string WorkflowId { get; set; }

        /// <summary>
        /// Gets/sets a value that specifies how actions are to be performed (in sequence of parallel)
        /// </summary>
        public virtual ActionExecutionMode ActionMode { get; set; }

        /// <summary>
        /// Gets/sets an <see cref="List{T}"/> containing the actions to be executed in this branch
        /// </summary>
        public virtual List<ActionDefinition> Actions { get; set; } = new List<ActionDefinition>();

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Name;
        }

    }

}