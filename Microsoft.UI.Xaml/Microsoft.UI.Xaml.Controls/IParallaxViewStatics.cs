using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2977564802u, 59694, 23200, 146, 213, 61, 230, 159, 14, 106, 168)]
	[ExclusiveTo(typeof(ParallaxView))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IParallaxViewStatics
	{
		DependencyProperty ChildProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty HorizontalSourceEndOffsetProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty HorizontalSourceOffsetKindProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty HorizontalSourceStartOffsetProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty MaxHorizontalShiftRatioProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty HorizontalShiftProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty IsHorizontalShiftClampedProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty IsVerticalShiftClampedProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty SourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty VerticalSourceEndOffsetProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty VerticalSourceOffsetKindProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty VerticalSourceStartOffsetProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty MaxVerticalShiftRatioProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty VerticalShiftProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
