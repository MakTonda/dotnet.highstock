using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// Properties for each single point
	/// </summary>
	public class PlotOptionsErrorbarPoint
	{
		/// <summary>
		/// Events for each single point
		/// </summary>
		public PlotOptionsErrorbarPointEvents Events { get; set; }

	}

}