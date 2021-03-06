﻿using System.Collections.Generic;
using Rebus.Messages;

namespace Rebus.Idempotency
{
    /// <summary>
    /// An outgoing message is a <see cref="Messages.TransportMessage"/> destined for one or more destinations. 
    /// </summary>
    public class OutgoingMessage
    {
        /// <summary>
        /// Constructs the outgoing message destined for the given addresses
        /// </summary>
        public OutgoingMessage(IEnumerable<string> destinationAddresses, TransportMessage transportMessage)
        {
            DestinationAddresses = destinationAddresses;
            TransportMessage = transportMessage;
        }

        /// <summary>
        /// Gets the addresses for which this <see cref="Messages.TransportMessage"/> is supposed to be sent
        /// </summary>
        public IEnumerable<string> DestinationAddresses { get; private set; }

        /// <summary>
        /// Gets the transport message
        /// </summary>
        public TransportMessage TransportMessage { get; private set; }
    }
}
