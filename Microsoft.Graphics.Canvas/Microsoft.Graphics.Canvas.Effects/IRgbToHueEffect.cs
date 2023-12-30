using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(RgbToHueEffect))]
	[Windows.Foundation.Metadata.Guid(2091822534u, 40627, 22677, 184, 118, 244, 133, 201, 87, 72, 71)]
	internal interface IRgbToHueEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IDisposable
	{
		EffectHueColorSpace OutputColorSpace
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		IGraphicsEffectSource Source
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
