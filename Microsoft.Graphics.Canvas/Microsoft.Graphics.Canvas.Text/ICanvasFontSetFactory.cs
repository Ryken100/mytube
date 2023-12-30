using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasFontSet))]
	[Windows.Foundation.Metadata.Guid(1016896474u, 28921, 20473, 170, 178, 59, 66, 146, 50, 134, 238)]
	[Version(167772160u)]
	internal interface ICanvasFontSetFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasFontSet Create([In] Uri uri);
	}
}
