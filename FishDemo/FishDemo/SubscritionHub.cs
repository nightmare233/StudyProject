using System;
using System.Collections.Generic;
using System.Text;

namespace FishDemo
{
    public abstract class  SubscritionHub
    {
        public readonly List<ISubscriber> _subscribers;

        protected SubscritionHub()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
                _subscribers.Remove(subscriber);
        }

        public void Notify(FishType fishType)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(fishType);
            }
        }
    }
}
