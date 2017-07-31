// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using AutoMapper;
using System;
using FROM = Microsoft.Azure.Management.Compute.Models;
using TO = Microsoft.Azure.Commands.Compute.Automation.Models;

namespace Microsoft.Azure.Commands.Compute.Automation.Models
{
    public class ComputeAutomationAutoMapperProfile : AutoMapper.Profile
    {
        private static readonly Lazy<bool> initialize;

        static ComputeAutomationAutoMapperProfile()
        {
            initialize = new Lazy<bool>(() =>
            {
                Mapper.AddProfile<ComputeAutomationAutoMapperProfile>();
                return true;
            });
        }

        public override string ProfileName
        {
            get { return "ComputeAutomationAutoMapperProfile"; }
        }

        public static bool Initialize()
        {
            return initialize.Value;
        }

        protected override void Configure()
        {
            Mapper.CreateMap<FROM.AvailabilitySet, TO.PSAvailabilitySetList>();
            Mapper.CreateMap<TO.PSAvailabilitySetList, TO.PSAvailabilitySet>();
            Mapper.CreateMap<TO.PSAvailabilitySet, TO.PSAvailabilitySetList>();
            Mapper.CreateMap<FROM.ContainerService, TO.PSContainerServiceList>();
            Mapper.CreateMap<TO.PSContainerServiceList, TO.PSContainerService>();
            Mapper.CreateMap<TO.PSContainerService, TO.PSContainerServiceList>();
            Mapper.CreateMap<FROM.Disk, TO.PSDiskList>();
            Mapper.CreateMap<TO.PSDiskList, TO.PSDisk>();
            Mapper.CreateMap<TO.PSDisk, TO.PSDiskList>();
            Mapper.CreateMap<FROM.Image, TO.PSImageList>();
            Mapper.CreateMap<TO.PSImageList, TO.PSImage>();
            Mapper.CreateMap<TO.PSImage, TO.PSImageList>();
            Mapper.CreateMap<FROM.Snapshot, TO.PSSnapshotList>();
            Mapper.CreateMap<TO.PSSnapshotList, TO.PSSnapshot>();
            Mapper.CreateMap<TO.PSSnapshot, TO.PSSnapshotList>();
            Mapper.CreateMap<FROM.VirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSetList, TO.PSVirtualMachineScaleSet>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>();
            Mapper.CreateMap<FROM.VirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSetList, TO.PSVirtualMachineScaleSet>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSet, TO.PSVirtualMachineScaleSetList>();
            Mapper.CreateMap<FROM.VirtualMachineScaleSetVM, TO.PSVirtualMachineScaleSetVMList>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSetVMList, TO.PSVirtualMachineScaleSetVM>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSetVM, TO.PSVirtualMachineScaleSetVMList>();
            Mapper.CreateMap<FROM.VirtualMachine, TO.PSVirtualMachineList>();
            Mapper.CreateMap<TO.PSVirtualMachineList, TO.PSVirtualMachine>();
            Mapper.CreateMap<TO.PSVirtualMachine, TO.PSVirtualMachineList>();
            Mapper.CreateMap<FROM.VirtualMachine, TO.PSVirtualMachineList>();
            Mapper.CreateMap<TO.PSVirtualMachineList, TO.PSVirtualMachine>();
            Mapper.CreateMap<TO.PSVirtualMachine, TO.PSVirtualMachineList>();
            Mapper.CreateMap<FROM.Disk, FROM.DiskUpdate>();
            Mapper.CreateMap<FROM.DiskUpdate, FROM.Disk>();
            Mapper.CreateMap<FROM.DiskUpdate, TO.PSDiskUpdate>();
            Mapper.CreateMap<TO.PSDiskUpdate, FROM.DiskUpdate>();
            Mapper.CreateMap<FROM.Snapshot, FROM.SnapshotUpdate>();
            Mapper.CreateMap<FROM.SnapshotUpdate, FROM.Snapshot>();
            Mapper.CreateMap<FROM.SnapshotUpdate, TO.PSSnapshotUpdate>();
            Mapper.CreateMap<TO.PSSnapshotUpdate, FROM.SnapshotUpdate>();
            Mapper.CreateMap<FROM.AvailabilitySet, TO.PSAvailabilitySet>();
            Mapper.CreateMap<TO.PSAvailabilitySet, FROM.AvailabilitySet>();
            Mapper.CreateMap<FROM.OperationStatusResponse, TO.PSOperationStatusResponse>();
            Mapper.CreateMap<TO.PSOperationStatusResponse, FROM.OperationStatusResponse>();
            Mapper.CreateMap<FROM.VirtualMachineSize, TO.PSVirtualMachineSize>();
            Mapper.CreateMap<TO.PSVirtualMachineSize, FROM.VirtualMachineSize>();
            Mapper.CreateMap<FROM.ContainerService, TO.PSContainerService>();
            Mapper.CreateMap<TO.PSContainerService, FROM.ContainerService>();
            Mapper.CreateMap<FROM.Disk, TO.PSDisk>();
            Mapper.CreateMap<TO.PSDisk, FROM.Disk>();
            Mapper.CreateMap<FROM.AccessUri, TO.PSAccessUri>();
            Mapper.CreateMap<TO.PSAccessUri, FROM.AccessUri>();
            Mapper.CreateMap<FROM.Image, TO.PSImage>();
            Mapper.CreateMap<TO.PSImage, FROM.Image>();
            Mapper.CreateMap<FROM.ResourceSku, TO.PSResourceSku>();
            Mapper.CreateMap<TO.PSResourceSku, FROM.ResourceSku>();
            Mapper.CreateMap<FROM.Snapshot, TO.PSSnapshot>();
            Mapper.CreateMap<TO.PSSnapshot, FROM.Snapshot>();
            Mapper.CreateMap<FROM.RunCommandDocument, TO.PSRunCommandDocument>();
            Mapper.CreateMap<TO.PSRunCommandDocument, FROM.RunCommandDocument>();
            Mapper.CreateMap<FROM.RunCommandDocumentBase, TO.PSRunCommandDocumentBase>();
            Mapper.CreateMap<TO.PSRunCommandDocumentBase, FROM.RunCommandDocumentBase>();
            Mapper.CreateMap<FROM.VirtualMachineScaleSet, TO.PSVirtualMachineScaleSet>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSet, FROM.VirtualMachineScaleSet>();
            Mapper.CreateMap<FROM.VirtualMachineScaleSetInstanceView, TO.PSVirtualMachineScaleSetInstanceView>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSetInstanceView, FROM.VirtualMachineScaleSetInstanceView>();
            Mapper.CreateMap<FROM.VirtualMachineScaleSetSku, TO.PSVirtualMachineScaleSetSku>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSetSku, FROM.VirtualMachineScaleSetSku>();
            Mapper.CreateMap<FROM.VirtualMachineScaleSetVM, TO.PSVirtualMachineScaleSetVM>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSetVM, FROM.VirtualMachineScaleSetVM>();
            Mapper.CreateMap<FROM.VirtualMachineScaleSetVMInstanceView, TO.PSVirtualMachineScaleSetVMInstanceView>();
            Mapper.CreateMap<TO.PSVirtualMachineScaleSetVMInstanceView, FROM.VirtualMachineScaleSetVMInstanceView>();
            Mapper.CreateMap<FROM.VirtualMachineCaptureResult, TO.PSVirtualMachineCaptureResult>();
            Mapper.CreateMap<TO.PSVirtualMachineCaptureResult, FROM.VirtualMachineCaptureResult>();
            Mapper.CreateMap<FROM.VirtualMachine, TO.PSVirtualMachine>();
            Mapper.CreateMap<TO.PSVirtualMachine, FROM.VirtualMachine>();
            Mapper.CreateMap<FROM.RunCommandResult, TO.PSRunCommandResult>();
            Mapper.CreateMap<TO.PSRunCommandResult, FROM.RunCommandResult>();

        }
    }
}
