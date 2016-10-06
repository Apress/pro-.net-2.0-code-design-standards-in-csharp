using System;

namespace Patterns.Observer
{
	/// <summary>
	/// Summary description for Interesting.
	/// </summary>
	/// 
	
	//delegate class included in same code (cs) file as Subject class, for convenience
	public delegate void ChangedEventHandler(object sender, EventArgs e);

	public class Subject
	{
		private string data;
		public event ChangedEventHandler Changed;

		public string InterestingData
		{
			get{return data;}
			
			set
			{
				data = value;
				this.OnChanged(EventArgs.Empty);
			}
		}
		
		protected virtual void OnChanged (EventArgs e)
		{
			if (Changed !=null)
				this.Changed(this,e);
		}

		public Subject(){;}
	}
}

