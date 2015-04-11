﻿using System.Net.Sockets;
using MicroServer.Net.Sockets;

using MicroServer.Net.Http.Messages;

namespace MicroServer.Net.Http
{
    /// <summary>
    /// <see cref="ITcpChannel"/> have sent or received a message.
    /// </summary>
    /// <param name="channel">Channel that did the work</param>
    /// <param name="message">Message. depends on which encoder/decoder was used.</param>
    /// <remarks>We uses delegates instead of regular events to make sure that there are only one subscriber and that it's configured once.</remarks>
    public delegate void MessageReceivedHandler(SocketChannel channel, HttpMessage message);
}