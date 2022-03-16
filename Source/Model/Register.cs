// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;

namespace RaaLabs.Edge.Connectors.Modbus.Model
{
    /// <summary>
    /// Represents a Modbus register
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Register
    {
        /// <summary>
        /// Gets the <see cref="Unit"/> identifier
        /// </summary>
        public byte Unit { get; set; }

        /// <summary>
        /// Gets or sets the starting address for the register
        /// </summary>
        /// <remarks>
        /// This is the actual zero-indexed short/word (16 bit) offset.
        /// 0: 0 bytes
        /// 1: 2 bytes 
        /// 2: 4 bytes 
        /// ...
        /// </remarks>
        public ushort StartingAddress { get; set; }

        /// <summary>
        /// Gets or sets what <see cref="DataType"/> to expect for the register
        /// </summary>
        public DataType DataType { get; set; }

        /// <summary>
        /// The <see cref="FunctionCode"/> to use for the read
        /// </summary>
        public FunctionCode FunctionCode { get; set; }

        /// <summary>
        /// The <see cref="Size"/> to use for the read
        /// </summary>
        public ushort Size { get; set; }

    }
}