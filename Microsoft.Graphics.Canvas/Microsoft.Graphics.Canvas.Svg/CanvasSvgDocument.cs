using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[Version(167772160u)]
	[Activatable(typeof(ICanvasSvgDocumentFactory), 167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Static(typeof(ICanvasSvgDocumentStatics), 167772160u)]
	public sealed class CanvasSvgDocument : ICanvasSvgDocument, IDisposable
	{
		public extern CanvasSvgNamedElement Root
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern string GetXml();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern IAsyncAction SaveAsync([In] IRandomAccessStream stream);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgNamedElement FindElementById([In] string id);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePaintAttributeWithDefaults")]
		public extern CanvasSvgPaintAttribute CreatePaintAttribute();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreatePaintAttribute")]
		public extern CanvasSvgPaintAttribute CreatePaintAttribute([In] CanvasSvgPaintType paintType, [In] Color color, [In] string id);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePathAttributeWithDefaults")]
		public extern CanvasSvgPathAttribute CreatePathAttribute();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreatePathAttribute")]
		public extern CanvasSvgPathAttribute CreatePathAttribute([In] float[] segmentData, [In] CanvasSvgPathCommand[] commands);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePointsAttributeWithDefaults")]
		public extern CanvasSvgPointsAttribute CreatePointsAttribute();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePointsAttribute")]
		[DefaultOverload]
		public extern CanvasSvgPointsAttribute CreatePointsAttribute([In] Vector2[] points);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateStrokeDashArrayAttributeWithDefaults")]
		public extern CanvasSvgStrokeDashArrayAttribute CreateStrokeDashArrayAttribute();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateStrokeDashArrayAttribute")]
		[DefaultOverload]
		public extern CanvasSvgStrokeDashArrayAttribute CreateStrokeDashArrayAttribute([In] float[] dashValues, [In] CanvasSvgLengthUnits[] unitValues);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgNamedElement LoadElementFromXml([In] string xmlString);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern IAsyncOperation<CanvasSvgNamedElement> LoadElementAsync([In] IRandomAccessStream stream);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern CanvasSvgDocument LoadFromXml([In] ICanvasResourceCreator resourceCreator, [In] string xmlString);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern IAsyncOperation<CanvasSvgDocument> LoadAsync([In] ICanvasResourceCreator resourceCreator, [In] IRandomAccessStream stream);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern bool IsSupported([In] CanvasDevice device);
	}
}
