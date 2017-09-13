using System.Collections.Generic;

namespace Eni.Util
{
    public class Observable
    {
        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void Subscribe(IObserver observateur)
        {
            Observers.Add(observateur);
        }
        public void Unsubscribe(IObserver observateur)
        {
            Observers.Remove(observateur);
        }

        public void NotifyAll()
        {
            foreach (IObserver seg in Observers)
            {
                seg.Update();
            }
        }




    }
}