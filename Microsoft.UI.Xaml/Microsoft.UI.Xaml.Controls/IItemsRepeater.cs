using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(ItemsRepeater))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(198743282u, 60924, 24031, 161, 102, 45, 177, 75, 191, 223, 53)]
	internal interface IItemsRepeater
	{
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		object ItemsSource
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		ItemsSourceView ItemsSourceView
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		object ItemTemplate
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
		[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
		[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
		[MUXPropertyChangedCallback(enable = true)]
		Layout Layout
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		[MUXPropertyDefaultValue(value = "2.0")]
		double HorizontalCacheLength
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "2.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		double VerticalCacheLength
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		Brush Background
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int GetElementIndex([In] UIElement element);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		UIElement TryGetElement([In] int index);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		UIElement GetOrCreateElement([In] int index);

		event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementPreparedEventArgs> ElementPrepared;

		event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementClearingEventArgs> ElementClearing;

		event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementIndexChangedEventArgs> ElementIndexChanged;
	}
}
