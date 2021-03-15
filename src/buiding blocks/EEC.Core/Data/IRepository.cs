﻿using EEC.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EEC.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {

    }
}
