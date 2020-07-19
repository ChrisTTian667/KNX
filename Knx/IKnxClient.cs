﻿using System;
using System.Threading.Tasks;

namespace Knx
{
    public delegate void KnxMessageReceivedHandler(IKnxClient sender, IKnxMessage message);

    /// <summary>
    /// Client interface
    /// </summary>
    public interface IKnxClient : IDisposable
    {
        event KnxMessageReceivedHandler KnxMessageReceived;
        
        /// <summary>
        /// The DeviceAddress of the KNX Gateway
        /// </summary>
        KnxDeviceAddress DeviceAddress { get; }

        TimeSpan ReadTimeout { get; }
        
        bool IsConnected { get; }
        
        Task Open();

        Task SendMessage(IKnxMessage knxMessage);
    }
}