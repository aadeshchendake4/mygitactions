// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using RaaLabs.Edge.Modules.Configuration;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using RaaLabs.Edge.Connectors.Modbus.Model;
using System.Diagnostics.CodeAnalysis;

namespace RaaLabs.Edge.Connectors.Modbus
{
    /// <summary>
    /// Represents the configuration for registers
    /// </summary>
    [Name("registers.json")]
    [ExcludeFromCodeCoverage]
    [RestartOnChange]
    public class RegistersConfiguration :
        ReadOnlyCollection<Register>,
        IConfiguration
    {
        /// <summary>
        /// Initializes a new instance of <see cref="RegistersConfiguration"/>
        /// </summary>
        /// <param name="registers">The mapping between all </param> and <see cref="Register">registers</see>
        public RegistersConfiguration(IList<Register> registers) : base(registers)
        {
        }
    }
}