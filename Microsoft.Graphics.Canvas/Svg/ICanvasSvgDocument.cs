using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Storage.Streams;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000C6 RID: 198
	[ExclusiveTo(typeof(CanvasSvgDocument))]
	[Guid(2699249961U, 13649, 17662, 166, 112, 217, 179, 253, 128, 5, 22)]
	[Version(167772160U)]
	internal interface ICanvasSvgDocument : IClosable
	{
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060005E5 RID: 1509
		CanvasDevice Device { get; }

		// Token: 0x060005E6 RID: 1510
		string GetXml();

		// Token: 0x060005E7 RID: 1511
		IAsyncAction SaveAsync([In] IRandomAccessStream stream);

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060005E9 RID: 1513
		// (set) Token: 0x060005E8 RID: 1512
		CanvasSvgNamedElement Root
		{
			get; [param: In]
			set;
		}

		// Token: 0x060005EA RID: 1514
		CanvasSvgNamedElement FindElementById([In] string id);

		// Token: 0x060005EB RID: 1515
		[Overload("CreatePaintAttributeWithDefaults")]
		CanvasSvgPaintAttribute CreatePaintAttribute();

		// Token: 0x060005EC RID: 1516
		[Overload("CreatePaintAttribute")]
		[DefaultOverload]
		CanvasSvgPaintAttribute CreatePaintAttribute([In] CanvasSvgPaintType paintType, [In] Color color, [In] string id);

		// Token: 0x060005ED RID: 1517
		[Overload("CreatePathAttributeWithDefaults")]
		CanvasSvgPathAttribute CreatePathAttribute();

		// Token: 0x060005EE RID: 1518
		[Overload("CreatePathAttribute")]
		[DefaultOverload]
		CanvasSvgPathAttribute CreatePathAttribute([In] float[] segmentData, [In] CanvasSvgPathCommand[] commands);

		// Token: 0x060005EF RID: 1519
		[Overload("CreatePointsAttributeWithDefaults")]
		CanvasSvgPointsAttribute CreatePointsAttribute();

		// Token: 0x060005F0 RID: 1520
		[Overload("CreatePointsAttribute")]
		[DefaultOverload]
		CanvasSvgPointsAttribute CreatePointsAttribute([In] Vector2[] points);

		// Token: 0x060005F1 RID: 1521
		[Overload("CreateStrokeDashArrayAttributeWithDefaults")]
		CanvasSvgStrokeDashArrayAttribute CreateStrokeDashArrayAttribute();

		// Token: 0x060005F2 RID: 1522
		[DefaultOverload]
		[Overload("CreateStrokeDashArrayAttribute")]
		CanvasSvgStrokeDashArrayAttribute CreateStrokeDashArrayAttribute([In] float[] dashValues, [In] CanvasSvgLengthUnits[] unitValues);

		// Token: 0x060005F3 RID: 1523
		CanvasSvgNamedElement LoadElementFromXml([In] string xmlString);

		// Token: 0x060005F4 RID: 1524
		IAsyncOperation<CanvasSvgNamedElement> LoadElementAsync([In] IRandomAccessStream stream);
	}
}
