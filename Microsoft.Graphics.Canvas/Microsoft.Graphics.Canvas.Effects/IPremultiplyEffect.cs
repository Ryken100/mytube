using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[ExclusiveTo(typeof(PremultiplyEffect))]
	[Windows.Foundation.Metadata.Guid(3533348126u, 48471, 24382, 154, 224, 0, 156, 106, 197, 176, 109)]
	[Version(167772160u)]
	internal interface IPremultiplyEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IDisposable
	{
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
