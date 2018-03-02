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

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateVirtualMachineScaleSetRollingUpgradeCancelDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pResourceGroupName = new RuntimeDefinedParameter();
            pResourceGroupName.Name = "ResourceGroupName";
            pResourceGroupName.ParameterType = typeof(string);
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pVMScaleSetName = new RuntimeDefinedParameter();
            pVMScaleSetName.Name = "VMScaleSetName";
            pVMScaleSetName.ParameterType = typeof(string);
            pVMScaleSetName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pVMScaleSetName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VMScaleSetName", pVMScaleSetName);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 3,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteVirtualMachineScaleSetRollingUpgradeCancelMethod(object[] invokeMethodInputParameters)
        {
            string resourceGroupName = (string)ParseParameter(invokeMethodInputParameters[0]);
            string vmScaleSetName = (string)ParseParameter(invokeMethodInputParameters[1]);

            var result = VirtualMachineScaleSetRollingUpgradesClient.Cancel(resourceGroupName, vmScaleSetName);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateVirtualMachineScaleSetRollingUpgradeCancelParameters()
        {
            string resourceGroupName = string.Empty;
            string vmScaleSetName = string.Empty;

            return ConvertFromObjectsToArguments(
                 new string[] { "ResourceGroupName", "VMScaleSetName" },
                 new object[] { resourceGroupName, vmScaleSetName });
        }
    }

    [Cmdlet(VerbsLifecycle.Stop, "AzureRmVmssRollingUpgrade", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSOperationStatusResponse))]
    public partial class StopAzureRmVmssRollingUpgrade : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.VMScaleSetName, VerbsLifecycle.Stop)
                    && (this.Force.IsPresent ||
                        this.ShouldContinue(Properties.Resources.ResourceStoppingConfirmation,
                                            "Stop-AzureRmVmssRollingUpgrade operation")))
                {
                    string resourceGroupName = this.ResourceGroupName;
                    string vmScaleSetName = this.VMScaleSetName;

                    var result = VirtualMachineScaleSetRollingUpgradesClient.Cancel(resourceGroupName, vmScaleSetName);
                    var psObject = new PSOperationStatusResponse();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<Azure.Management.Compute.Models.OperationStatusResponse, PSOperationStatusResponse>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false)]
        [AllowNull]
        [ResourceManager.Common.ArgumentCompleters.ResourceGroupCompleter()]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false)]
        [Alias("Name")]
        [AllowNull]
        public string VMScaleSetName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Mandatory = false)]
        [Parameter(
            ParameterSetName = "FriendMethod",
            Mandatory = false)]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }
    }
}
