using System;

namespace MSFTBandLib {

/// <summary>Band connection connected exception</summary>
public class BandConnectionConnected : Exception {

	/// <summary>Constructor.</summary>
	public BandConnectionConnected() : 
	base("Band connection is already connected.") {}

}

}