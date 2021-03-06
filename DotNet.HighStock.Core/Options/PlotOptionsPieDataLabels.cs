using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	public class PlotOptionsPieDataLabels
	{
		/// <summary>
		/// The background color or gradient for the data label. Defaults to <code>undefined</code>.
		/// </summary>
		[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		public BackColorOrGradient BackgroundColor { get; set; }

		/// <summary>
		/// The border color for the data label. Defaults to <code>undefined</code>.
		/// </summary>
		public Color? BorderColor { get; set; }

		/// <summary>
		/// The border radius in pixels for the data label.
		/// Default: 0
		/// </summary>
		public Number? BorderRadius { get; set; }

		/// <summary>
		/// The border width in pixels for the data label.
		/// Default: 0
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// The text color for the data labels. Defaults to <code>null</code>.
		/// </summary>
		public Color? Color { get; set; }

		/// <summary>
		/// The color of the line connecting the data label to the pie slice. The default color is the same as the point's color.
		/// Default: {point.color}
		/// </summary>
		public Color? ConnectorColor { get; set; }

		/// <summary>
		/// The distance from the data label to the connector.
		/// Default: 5
		/// </summary>
		public Number? ConnectorPadding { get; set; }

		/// <summary>
		/// The width of the line connecting the data label to the pie slice.
		/// Default: 1
		/// </summary>
		public Number? ConnectorWidth { get; set; }

		/// <summary>
		/// Whether to hide data labels that are outside the plot area. By default, the data label is moved inside the plot area according to the <a href='#plotOptions.series.dataLabels.overflow'>overflow</a> option.
		/// Default: true
		/// </summary>
		public bool? Crop { get; set; }

		/// <summary>
		/// Whether to defer displaying the data labels until the initial series animation has finished.
		/// Default: true
		/// </summary>
		public bool? Defer { get; set; }

		/// <summary>
		/// The distance of the data label from the pie's edge. Negative numbers put the data label on top of the pie slices. Connectors are only shown for data labels outside the pie.
		/// Default: 30
		/// </summary>
		public Number? Distance { get; set; }

		/// <summary>
		/// Enable or disable the data labels.
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// A <a href='http://www.highstock.com/docs/chart-concepts/labels-and-string-formatting'>format string</a> for the data label. Available variables are the same as for <code>formatter</code>.
		/// Default: {y}
		/// </summary>
		public string Format { get; set; }

		/// <summary>
		/// Callback JavaScript function to format the data label. Note that if a <code>format</code> is defined, the format takes precedence and the formatter is ignored. Available data are:<table><tbody><tr>  <td><code>this.percentage</code></td>  <td>Stacked series and pies only. The point's percentage of the total.</td></tr><tr>  <td><code>this.point</code></td>  <td>The point object. The point name, if defined, is available through <code>this.point.name</code>.</td></tr><tr>  <td><code>this.series</code>:</td>  <td>The series object. The series name is available through <code>this.series.name</code>.</td></tr><tr>  <td><code>this.total</code></td>  <td>Stacked series only. The total value at this point's x value.</td></tr><tr>  <td><code>this.x</code>:</td>  <td>The x value.</td></tr><tr>  <td><code>this.y</code>:</td>  <td>The y value.</td></tr></tbody></table>
		/// </summary>
		[JsonFormatter("{0}")]
		public string Formatter { get; set; }

		/// <summary>
		/// For points with an extent, like columns, whether to align the data label inside the box or to the actual value point. Defaults to <code>false</code> in most cases, <code>true</code> in stacked columns.
		/// </summary>
		public bool? Inside { get; set; }

		/// <summary>
		/// How to handle data labels that flow outside the plot area. The default is <code>justify</code>, which aligns them inside the plot area. For columns and bars, this means it will be moved inside the bar. To display data labels outside the plot area, set <code>crop</code> to <code>false</code> and <code>overflow</code> to <code>'none'</code>.
		/// Default: justify
		/// </summary>
		public string Overflow { get; set; }

		/// <summary>
		/// When either the <code>borderWidth</code> or the <code>backgroundColor</code> is set, thisis the padding within the box.
		/// Default: 2
		/// </summary>
		public Number? Padding { get; set; }

		/// <summary>
		/// Text rotation in degrees. Note that due to a more complex structure, backgrounds and borders will be lost on a rotated data label.
		/// Default: 0
		/// </summary>
		public Number? Rotation { get; set; }

		/// <summary>
		/// The shadow of the box. Works best with <code>borderWidth</code> or <code>backgroundColor</code>. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// Default: false
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharp break.
		/// Default: true
		/// </summary>
		public bool? SoftConnector { get; set; }

		/// <summary>
		/// Styles for the label.
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// Whether to <a href='http://www.highstock.com/docs/chart-concepts/labels-and-string-formatting#html'>use HTML</a> to render the labels.
		/// Default: false
		/// </summary>
		public bool? UseHTML { get; set; }

		/// <summary>
		/// The vertical alignment of a data label. Can be one of <code>top</code>, <code>middle</code> or <code>bottom</code>. The default value depends on the data, for instance in a column chart, the label is above positive values and below negative values.
		/// </summary>
		public VerticalAligns? VerticalAlign { get; set; }

		/// <summary>
		/// The x position offset of the label relative to the point. 
		/// Default: 0
		/// </summary>
		public Number? X { get; set; }

		/// <summary>
		/// The y position offset of the label relative to the point. 
		/// Default: -6
		/// </summary>
		public Number? Y { get; set; }

		/// <summary>
		/// The Z index of the data labels. The default Z index puts it above the series. Use a Z index of 2 to display it behind the series.
		/// Default: 6
		/// </summary>
		public Number? ZIndex { get; set; }

	}

}