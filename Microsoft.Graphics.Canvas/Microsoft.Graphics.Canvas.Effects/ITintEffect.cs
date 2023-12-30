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
	[Windows.Foundation.Metadata.Guid(1922703850u, 50718, 21256, 158, 174, 214, 56, 170, 31, 91, 140)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(TintEffect))]
	internal interface ITintEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IDisposable
	{
		Color Color
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		bool ClampOutput
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
