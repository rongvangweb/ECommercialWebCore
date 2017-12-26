﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ECommercial.Infrastructure.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        void Commit();
    }
}
