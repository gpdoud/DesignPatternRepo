using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern {
	class SubjectData : ISubjectData {
		public int RC { get; set; }
		public string Msg { get; set; }
		public object Data { get; set; }
	}
}
