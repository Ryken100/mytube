using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Static(typeof(IItemsRepeaterStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContentProperty(Name = "ItemTemplate")]
	[Threading(ThreadingModel.Both)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Composable(typeof(IItemsRepeaterFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public class ItemsRepeater : FrameworkElement, IItemsRepeater
	{
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		public extern double VerticalCacheLength
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "2.0")]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
		[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern Layout Layout
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::StackLayout()")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern object ItemsSource
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
		public extern object ItemTemplate
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
		[MUXPropertyDefaultValue(value = "2.0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "2.0")]
		public extern double HorizontalCacheLength
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "2.0")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "2.0")]
			[param: In]
			set;
		}

		public extern Brush Background
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern ItemsSourceView ItemsSourceView
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty BackgroundProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty HorizontalCacheLengthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ItemTemplateProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ItemsSourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty LayoutProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty VerticalCacheLengthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[method: In]
		public extern event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementClearingEventArgs> ElementClearing;

		[method: In]
		public extern event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementIndexChangedEventArgs> ElementIndexChanged;

		[method: In]
		public extern event TypedEventHandler<ItemsRepeater, ItemsRepeaterElementPreparedEventArgs> ElementPrepared;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern int GetElementIndex([In] UIElement element);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern UIElement TryGetElement([In] int index);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern UIElement GetOrCreateElement([In] int index);
	}
}
