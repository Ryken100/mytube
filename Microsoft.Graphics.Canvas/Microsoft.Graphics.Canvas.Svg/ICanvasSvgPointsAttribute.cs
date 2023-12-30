using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasSvgPointsAttribute))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1697089192u, 62379, 16515, 153, 29, 151, 72, 170, 134, 189, 111)]
	internal interface ICanvasSvgPointsAttribute : IDisposable, ICanvasSvgAttribute
	{
		Vector2[] Points
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Vector2[] GetPoints([In] int startIndex, [In] int elementCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemovePointsAtEnd([In] int pointCount);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetPoints([In] int startIndex, [In] Vector2[] points);
	}
}
