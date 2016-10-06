using System;

namespace Patterns.Observer
{
	
	public class Observer
	{
		private Subject data;
		private string observerName;

		public Subject ObservedObject
		{
			get {return data;}
			set {data = value;}
		}

		private void DataChanged (object sender, EventArgs e)
		{
			Console.WriteLine("Notification to {0}, the car {1}", observerName, data.InterestingData);
		}
		
		public void Attach()
		{
			data.Changed += new ChangedEventHandler(DataChanged);
		}

		public void Detach()
		{
			data.Changed -= new ChangedEventHandler(DataChanged);
		}

		public Observer (string name)
		{
			observerName = name;
		}

	}
}//endnamespace Patterns.Observer

