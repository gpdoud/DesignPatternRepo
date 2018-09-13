using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern {
	class Subject : ISubject {

		List<IObserver> observers = new List<IObserver>();

		public void NotifyObserver(ISubjectData data) {
			foreach(var observer in observers) {
				observer.Update(data);
			}
		}

		public void RegisterObserver(IObserver observer) {
			if (observers.IndexOf(observer) > -1) return; // already registered
			observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer) {
			if (observers.IndexOf(observer) == -1) return; // not registered
			observers.RemoveAt(observers.IndexOf(observer));
		}
	}
}
