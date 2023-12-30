using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(IUniformGridLayoutStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(IUniformGridLayoutFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	public class UniformGridLayout : VirtualizingLayout, IUniformGridLayout
	{
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		public extern Orientation Orientation
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double MinRowSpacing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double MinItemWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double MinItemHeight
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		public extern double MinColumnSpacing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		public extern int MaximumRowsOrColumns
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
		public extern UniformGridLayoutItemsStretch ItemsStretch
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
		public extern UniformGridLayoutItemsJustification ItemsJustification
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
			[param: In]
			set;
		}

		public static extern DependencyProperty ItemsJustificationProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ItemsStretchProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MaximumRowsOrColumnsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MinColumnSpacingProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MinItemHeightProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MinItemWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty MinRowSpacingProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty OrientationProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
