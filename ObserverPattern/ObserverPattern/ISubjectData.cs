using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern {
	interface ISubjectData {
		int RC { get; set; }
		string Msg { get; set; }
		object Data { get; set; }
	}
}
