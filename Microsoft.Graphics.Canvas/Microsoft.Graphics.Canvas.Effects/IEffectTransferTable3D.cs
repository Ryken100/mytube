using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[ExclusiveTo(typeof(EffectTransferTable3D))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(2062576518u, 11333, 18888, 143, 68, 225, 90, 109, 79, 164, 78)]
	internal interface IEffectTransferTable3D : IDisposable
	{
		CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
