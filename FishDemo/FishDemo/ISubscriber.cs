using System;
using System.Collections.Generic;
using System.Text;

namespace FishDemo
{
    public interface ISubscriber
    {
        void Update(FishType type);
    }
}
