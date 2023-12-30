using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(InfoBarPanel))]
	[Windows.Foundation.Metadata.Guid(861789181u, 38778, 22690, 175, 23, 75, 119, 97, 68, 242, 69)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IInfoBarPanelStatics
	{
		DependencyProperty HorizontalOrientationPaddingProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty VerticalOrientationPaddingProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetHorizontalOrientationMargin([In] DependencyObject @object, [In] Thickness value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Thickness GetHorizontalOrientationMargin([In] DependencyObject @object);

		DependencyProperty HorizontalOrientationMarginProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetVerticalOrientationMargin([In] DependencyObject @object, [In] Thickness value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Thickness GetVerticalOrientationMargin([In] DependencyObject @object);

		DependencyProperty VerticalOrientationMarginProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
