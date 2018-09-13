using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern {

	class Observer : IObserver {

		public void Update(ISubjectData SubjectData) {
			Console.WriteLine($"rc:{SubjectData.RC}, msg={SubjectData.Msg}, obj={SubjectData.Data}");
		}
	}
}
