using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(513261868u, 46915, 21456, 136, 196, 132, 53, 39, 43, 10, 61)]
	[ExclusiveTo(typeof(HueToRgbEffect))]
	internal interface IHueToRgbEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IDisposable
	{
		EffectHueColorSpace SourceColorSpace
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
