using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1930005428u, 56561, 21507, 175, 68, 51, 68, 210, 152, 45, 64)]
	[ExclusiveTo(typeof(UnPremultiplyEffect))]
	[Version(167772160u)]
	internal interface IUnPremultiplyEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IDisposable
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
