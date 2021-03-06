using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	public class PlotOptionsLine
	{
		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
		/// Default: false
		/// </summary>
		public bool? AllowPointSelect { get; set; }

		/// <summary>
		/// <p>Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see <a href='#chart.animation'>chart.animation</a> and the animation parameter under the API methods.The following properties are supported:</p><dl>  <dt>duration</dt>  <dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or<code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notablythe jQuery UI suite. See <a href='http://api.jquery.com/animate/'>the jQuery docs</a>. When using MooTools as the general framework, use the property name <code>transition</code> instead of <code>easing</code>.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.</p>
		/// Default: true
		/// </summary>
		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public Animation Animation { get; set; }

		/// <summary>
		/// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified. In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the  <code>options.colors</code> array.
		/// </summary>
		public Color? Color { get; set; }

		/// <summary>
		/// Polar charts only. Whether to connect the ends of a line series plot across the extremes.
		/// Default: true
		/// </summary>
		public bool? ConnectEnds { get; set; }

		/// <summary>
		/// Whether to connect a graph line across null points.
		/// Default: false
		/// </summary>
		public bool? ConnectNulls { get; set; }

		/// <summary>
		/// When the series contains less points than the crop threshold, all points are drawn,  event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.  .
		/// Default: 300
		/// </summary>
		public Number? CropThreshold { get; set; }

		/// <summary>
		/// You can set the cursor to 'pointer' if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public Cursors? Cursor { get; set; }

		/// <summary>
		/// A name for the dash style to use for the graph. Applies only to series type having a graph, like <code>line</code>, <code>spline</code>, <code>area</code> and <code>scatter</code> in  case it has a <code>lineWidth</code>. The value for the <code>dashStyle</code> include:    <ul>    <li>Solid</li>    <li>ShortDash</li>    <li>ShortDot</li>    <li>ShortDashDot</li>    <li>ShortDashDotDot</li>    <li>Dot</li>    <li>Dash</li>    <li>LongDash</li>    <li>DashDot</li>    <li>LongDashDot</li>    <li>LongDashDotDot</li>    </ul>
		/// Default: Solid
		/// </summary>
		public DashStyles? DashStyle { get; set; }

		public PlotOptionsLineDataLabels DataLabels { get; set; }

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// Default: true
		/// </summary>
		public bool? EnableMouseTracking { get; set; }

		public PlotOptionsLineEvents Events { get; set; }

		/// <summary>
		/// Pixel with of the graph line.
		/// Default: 2
		/// </summary>
		public Number? LineWidth { get; set; }

		/// <summary>
		/// The <a href='#series.id'>id</a> of another series to link to. Additionally, the value can be ':previous' to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }

		public PlotOptionsLineMarker Marker { get; set; }

		/// <summary>
		/// The color for the parts of the graph or points that are below the <a href='#plotOptions.series.threshold'>threshold</a>.
		/// Default: null
		/// </summary>
		public Color? NegativeColor { get; set; }

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PlotOptionsLinePoint Point { get; set; }

		/// <summary>
		/// <p>If no x values are given for the points in a series, pointInterval defines the interval of the x values. For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.</p>
		/// Default: 1
		/// </summary>
		public Number? PointInterval { get; set; }

		/// <summary>
		/// <p>Possible values: null, 'on', 'between'.</p><p>In a column chart, when pointPlacement is 'on', the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is 'between', the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.</p><p>Since Highstock 3.0.2, the point placement can also be numeric, where 0 is on the axis value, -0.5 is between this value and the previous, and 0.5 is between this value and the next. Unlike the textual options, numeric point placement options won't affect axis padding.</p><p>Defaults to <code>null</code> in cartesian charts, <code>'between'</code> in polar charts.
		/// </summary>
		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PointPlacement PointPlacement { get; set; }

		/// <summary>
		/// If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945.
		/// Default: 0
		/// </summary>
		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PointStart PointStart { get; set; }

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
		/// Default: false
		/// </summary>
		public bool? Selected { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// Default: false
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the <code>selected</code> option.
		/// Default: false
		/// </summary>
		public bool? ShowCheckbox { get; set; }

		/// <summary>
		/// Whether to display this particular series or series type in the legend. The default value is <code>true</code> for standalone series, <code>false</code> for linked series.
		/// Default: true
		/// </summary>
		public bool? ShowInLegend { get; set; }

		/// <summary>
		/// Whether to stack the values of each series on top of each other. Possible values are null to disable, 'normal' to stack by value or 'percent'.
		/// </summary>
		public Stackings? Stacking { get; set; }

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsLineStates States { get; set; }

		/// <summary>
		/// Whether to apply steps to the line. Possible values are <code>left</code>, <code>center</code> and <code>right</code>. Prior to 2.3.5, only <code>left</code> was supported.
		/// Default: false
		/// </summary>
		public string Step { get; set; }

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
		/// Default: true
		/// </summary>
		public bool? StickyTracking { get; set; }

		/// <summary>
		/// The threshold, also called zero level or base level. For line type series this is only used in conjunction with <a href='#plotOptions.series.negativeColor'>negativeColor</a>.
		/// Default: 0
		/// </summary>
		public Number? Threshold { get; set; }

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href='#tooltip'>tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsLineTooltip Tooltip { get; set; }

		/// <summary>
		/// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to <code>0</code> disable.
		/// Default: 1000
		/// </summary>
		public Number? TurboThreshold { get; set; }

		/// <summary>
		/// Set the initial visibility of the series.
		/// Default: true
		/// </summary>
		public bool? Visible { get; set; }

	}

}