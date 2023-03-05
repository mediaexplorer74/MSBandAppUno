using System;

namespace MSFTBandLib
{

	/// <summary>Band connected exception</summary>
	public class BandConnected : Exception 
	{

		/// <summary>Constructor.</summary>
		public BandConnected() : base("Band is already connected.") {}

	}

}