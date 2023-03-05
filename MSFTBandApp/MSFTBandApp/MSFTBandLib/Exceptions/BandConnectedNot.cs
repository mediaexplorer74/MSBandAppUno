using System;

namespace MSFTBandLib {

/// <summary>Band not connected exception</summary>
public class BandConnectedNot : Exception {

	/// <summary>Constructor.</summary>
	public BandConnectedNot() : base("Band is not connected.") {}

}

}