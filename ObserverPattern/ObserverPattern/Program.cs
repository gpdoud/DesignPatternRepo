using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern {
	class Program {
		static void Main(string[] args) {
			var o1 = new Observer();
			var o2 = new Observer();
			var s1 = new Subject();

			s1.RegisterObserver(o1);
			s1.RegisterObserver(o2);
			s1.NotifyObserver(new SubjectData { RC = 0, Msg = "OK" });
		}
	}
}
