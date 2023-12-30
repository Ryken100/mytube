using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Storage.Streams;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000B6 RID: 182
	[Threading(3)]
	[Version(167772160U)]
	[Activatable(typeof(ICanvasSvgDocumentFactory), 167772160U)]
	[MarshalingBehavior(2)]
	[Static(typeof(ICanvasSvgDocumentStatics), 167772160U)]
	public sealed class CanvasSvgDocument : ICanvasSvgDocument, IClosable
	{
		// Token: 0x0600051C RID: 1308
		public extern CanvasSvgDocument([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600051D RID: 1309
		public extern CanvasDevice Device { get; }

		// Token: 0x0600051E RID: 1310
		public extern string GetXml();

		// Token: 0x0600051F RID: 1311
		public extern IAsyncAction SaveAsync([In] IRandomAccessStream stream);

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000521 RID: 1313
		// (set) Token: 0x06000520 RID: 1312
		public extern CanvasSvgNamedElement Root
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000522 RID: 1314
		public extern CanvasSvgNamedElement FindElementById([In] string id);

		// Token: 0x06000523 RID: 1315
		[Overload("CreatePaintAttributeWithDefaults")]
		public extern CanvasSvgPaintAttribute CreatePaintAttribute();

		// Token: 0x06000524 RID: 1316
		[DefaultOverload]
		[Overload("CreatePaintAttribute")]
		public extern CanvasSvgPaintAttribute CreatePaintAttribute([In] CanvasSvgPaintType paintType, [In] Color color, [In] string id);

		// Token: 0x06000525 RID: 1317
		[Overload("CreatePathAttributeWithDefaults")]
		public extern CanvasSvgPathAttribute CreatePathAttribute();

		// Token: 0x06000526 RID: 1318
		[DefaultOverload]
		[Overload("CreatePathAttribute")]
		public extern CanvasSvgPathAttribute CreatePathAttribute([In] float[] segmentData, [In] CanvasSvgPathCommand[] commands);

		// Token: 0x06000527 RID: 1319
		[Overload("CreatePointsAttributeWithDefaults")]
		public extern CanvasSvgPointsAttribute CreatePointsAttribute();

		// Token: 0x06000528 RID: 1320
		[Overload("CreatePointsAttribute")]
		[DefaultOverload]
		public extern CanvasSvgPointsAttribute CreatePointsAttribute([In] Vector2[] points);

		// Token: 0x06000529 RID: 1321
		[Overload("CreateStrokeDashArrayAttributeWithDefaults")]
		public extern CanvasSvgStrokeDashArrayAttribute CreateStrokeDashArrayAttribute();

		// Token: 0x0600052A RID: 1322
		[Overload("CreateStrokeDashArrayAttribute")]
		[DefaultOverload]
		public extern CanvasSvgStrokeDashArrayAttribute CreateStrokeDashArrayAttribute([In] float[] dashValues, [In] CanvasSvgLengthUnits[] unitValues);

		// Token: 0x0600052B RID: 1323
		public extern CanvasSvgNamedElement LoadElementFromXml([In] string xmlString);

		// Token: 0x0600052C RID: 1324
		public extern IAsyncOperation<CanvasSvgNamedElement> LoadElementAsync([In] IRandomAccessStream stream);

		// Token: 0x0600052D RID: 1325
		public extern void Close();

		// Token: 0x0600052E RID: 1326
		public static extern CanvasSvgDocument LoadFromXml([In] ICanvasResourceCreator resourceCreator, [In] string xmlString);

		// Token: 0x0600052F RID: 1327
		public static extern IAsyncOperation<CanvasSvgDocument> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		// Token: 0x06000530 RID: 1328
		public static extern bool IsSupported([In] CanvasDevice device);
	}
}
