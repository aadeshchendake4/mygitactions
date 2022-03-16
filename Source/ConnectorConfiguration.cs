// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using RaaLabs.Edge.Modules.Configuration;
using RaaLabs.Edge.Connectors.Modbus.Bridge;
using RaaLabs.Edge.Connectors.Modbus.Model;
using System.Diagnostics.CodeAnalysis;

namespace RaaLabs.Edge.Connectors.Modbus
{

    /// <summary>
    /// Represents the configuration for <see cref="ModbusBridge"/>
    /// </summary>
    [Name("connector.json")]
    [ExcludeFromCodeCoverage]
    [RestartOnChange]
    public class ConnectorConfiguration : IConfiguration
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ConnectorConfiguration"/>
        /// </summary>
        /// <param name="ip">The IP address for the connector</param>
        /// <param name="port">The Port to connect to</param>
        /// <param name="endianness"><see cref="Endianness"/> to expect from the master</param>
        /// <param name="protocol"><see cref="Protocol"/> to use for connecting</param>
        /// <param name="useASCII">Use ASCII transport</param>
        /// <param name="interval">Modbus polling interval in milliseconds. If lower than zero, the connector will only poll Modbus once before exiting.</param>
        /// <param name="readTimeout">Modbus read timeout in milliseconds</param>
        /// <param name="source">The source of the modbus sytem, defaults to 'Modbus'</param>
        public ConnectorConfiguration(string ip, int port, Endianness endianness, Protocol protocol, bool useASCII, int interval, int? readTimeout, string source)
        {
            Ip = ip;
            Port = port;
            Endianness = endianness;
            Protocol = protocol;
            UseASCII = useASCII;
            Interval = interval;
            ReadTimeout = readTimeout ?? 60000;
            Source = source ?? "Modbus";
        }

        /// <summary>
        /// Gets the Ip address that will be used for connecting
        /// </summary>
        public string Ip { get; }

        /// <summary>
        /// Gets the port that will be used for connecting
        /// </summary>
        public int Port { get; }

        /// <summary>
        /// Gets the <see cref="Endianness"/> expected from the master
        /// </summary>
        public Endianness Endianness { get; }

        /// <summary>
        /// Gets the <see cref="Protocol"/> to use
        /// </summary>
        public Protocol Protocol { get; }

        /// <summary>
        /// Gets wether or not to use ASCII transport
        /// </summary>
        /// <value></value>
        public bool UseASCII { get; }

        /// <summary>
        /// Gets the poll interval for the connector
        /// </summary>
        /// <value></value>
        public int Interval { get; }

        /// <summary>
        /// Gets the read timeout for the connector
        /// </summary>
        public int ReadTimeout { get; }

        /// <summary>
        /// Gets the Source name to be used for the outgoing events
        /// </summary>
        public string Source { get; }
    }
}