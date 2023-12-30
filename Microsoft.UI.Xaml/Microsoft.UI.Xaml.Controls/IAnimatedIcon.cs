using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(4144357338u, 33174, 22224, 141, 207, 43, 102, 194, 174, 215, 145)]
	[ExclusiveTo(typeof(AnimatedIcon))]
	internal interface IAnimatedIcon
	{
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		IAnimatedVisualSource2 Source
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		IconSource FallbackIconSource
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool MirroredWhenRightToLeft
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
