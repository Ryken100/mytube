using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(3517960000u, 47035, 22643, 154, 181, 158, 230, 240, 101, 221, 30)]
	[ExclusiveTo(typeof(PersonPicture))]
	internal interface IPersonPictureStatics
	{
		DependencyProperty BadgeNumberProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty BadgeGlyphProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty BadgeImageSourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty BadgeTextProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty IsGroupProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty ContactProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty DisplayNameProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty InitialsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty PreferSmallImageProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty ProfilePictureProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
