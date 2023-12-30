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
	[ExclusiveTo(typeof(CanvasSvgDocument))]
	[Windows.Foundation.Metadata.Guid(2699249961u, 13649, 17662, 166, 112, 217, 179, 253, 128, 5, 22)]
	[Version(167772160u)]
	internal interface ICanvasSvgDocument : IDisposable
	{
		CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetXml();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IAsyncAction SaveAsync([In] IRandomAccessStream stream);

		CanvasSvgNamedElement Root
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgNamedElement FindElementById([In] string id);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePaintAttributeWithDefaults")]
		CanvasSvgPaintAttribute CreatePaintAttribute();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePaintAttribute")]
		[DefaultOverload]
		CanvasSvgPaintAttribute CreatePaintAttribute([In] CanvasSvgPaintType paintType, [In] Color color, [In] string id);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePathAttributeWithDefaults")]
		CanvasSvgPathAttribute CreatePathAttribute();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePathAttribute")]
		[DefaultOverload]
		CanvasSvgPathAttribute CreatePathAttribute([In] float[] segmentData, [In] CanvasSvgPathCommand[] commands);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePointsAttributeWithDefaults")]
		CanvasSvgPointsAttribute CreatePointsAttribute();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreatePointsAttribute")]
		[DefaultOverload]
		CanvasSvgPointsAttribute CreatePointsAttribute([In] Vector2[] points);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("CreateStrokeDashArrayAttributeWithDefaults")]
		CanvasSvgStrokeDashArrayAttribute CreateStrokeDashArrayAttribute();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("CreateStrokeDashArrayAttribute")]
		CanvasSvgStrokeDashArrayAttribute CreateStrokeDashArrayAttribute([In] float[] dashValues, [In] CanvasSvgLengthUnits[] unitValues);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgNamedElement LoadElementFromXml([In] string xmlString);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IAsyncOperation<CanvasSvgNamedElement> LoadElementAsync([In] IRandomAccessStream stream);
	}
}
