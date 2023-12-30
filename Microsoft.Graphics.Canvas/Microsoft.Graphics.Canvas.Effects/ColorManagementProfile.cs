using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Version(167772160u)]
	[Static(typeof(IColorManagementProfileStatics), 167772160u)]
	[Activatable(typeof(IColorManagementProfileFactory), 167772160u)]
	public sealed class ColorManagementProfile : IColorManagementProfile, IDisposable
	{
		public extern CanvasColorSpace ColorSpace
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern ExtendedColorSpace ExtendedColorSpace
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern byte[] IccProfile
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern ColorManagementSimpleProfile? SimpleProfile
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern ColorManagementProfileType Type
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern ColorManagementProfile CreateCustom([In] byte[] iccProfile);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern ColorManagementProfile CreateSimple([In] ColorManagementSimpleProfile simpleProfile);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern ColorManagementProfile CreateExtended([In] ExtendedColorSpace colorSpace);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern bool IsSupported([In] ColorManagementProfileType type, [In] CanvasDevice device);
	}
}
