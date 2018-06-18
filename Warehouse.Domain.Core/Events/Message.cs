﻿using MediatR;
using System;

namespace Warehouse.Domain.Core.Events
{
    public abstract class Message : INotification
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message() => MessageType = GetType().Name;
    }
}
