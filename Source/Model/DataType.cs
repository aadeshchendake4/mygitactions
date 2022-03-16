// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.Edge.Connectors.Modbus.Model
{
    /// <summary>
    /// Represents the different types of data a <see cref="Register"/> can have
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// 32 bit integer
        /// </summary>
        Int32=1,

        /// <summary>
        /// Unsigned 32 bit integer
        /// </summary>
        Uint32,

        /// <summary>
        /// IEEE 754 floating point; https://en.m.wikipedia.org/wiki/IEEE_754
        /// </summary>
        Float,

        /// <summary>
        /// 16 bit integer
        /// </summary>
        Int16
    }
}