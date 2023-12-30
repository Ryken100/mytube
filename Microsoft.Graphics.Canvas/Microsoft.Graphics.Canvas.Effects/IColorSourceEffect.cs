using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(637092551u, 32750, 20874, 186, 123, 34, 160, 6, 10, 247, 246)]
	[ExclusiveTo(typeof(ColorSourceEffect))]
	[Version(167772160u)]
	internal interface IColorSourceEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IDisposable
	{
		Color Color
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		Vector4 ColorHdr
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
