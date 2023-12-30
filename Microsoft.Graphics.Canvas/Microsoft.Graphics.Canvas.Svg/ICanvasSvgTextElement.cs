using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasSvgTextElement))]
	[Windows.Foundation.Metadata.Guid(1697089192u, 62379, 16515, 153, 29, 151, 72, 170, 134, 189, 109)]
	[Version(167772160u)]
	internal interface ICanvasSvgTextElement : IDisposable
	{
		string Text
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
