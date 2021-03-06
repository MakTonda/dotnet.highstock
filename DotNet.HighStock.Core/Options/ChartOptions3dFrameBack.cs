using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// Defines the back panel of the frame around 3D charts.
	/// </summary>
	public class ChartOptions3dFrameBack
	{
		/// <summary>
		/// The color of the panel.
		/// Default: transparent
		/// </summary>
		public Color? Color { get; set; }

		/// <summary>
		/// Thickness of the panel.
		/// Default: 1
		/// </summary>
		public Number? Size { get; set; }

	}

}