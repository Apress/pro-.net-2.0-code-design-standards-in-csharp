using System;

namespace Patterns.FactoryMethod
{
	/// <summary>
	/// Summary description for ProductA.
	/// </summary>
	public class PictureContent: Content
	{

        public override void SomeContent()
        {
            Console.WriteLine("Picture content.");
        }
					
		public PictureContent(){;}

	}
}
