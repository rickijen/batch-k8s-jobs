﻿// 
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
using System;
using System.Collections.Generic;

using Microsoft.Azure.Batch;

/**
 * Description:
 * This class represents a container task to be executed on the batch engine.
 *
 * Author: GR @Microsoft
 * Dated: 07-20-2020
 *
 * NOTES: Capture updates to the code below.
 */

namespace core.Models
{
    public class ContainerTask
    {
	public string TaskName { get; set; }
        public string ImageName { get; set; }
	public List<ResourceFile> ResourceFiles { get; set; }
	public string CommandOptions { get; set; }
        public string Command { get; set; }
    }
}
