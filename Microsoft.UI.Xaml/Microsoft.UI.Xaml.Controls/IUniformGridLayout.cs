using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2259960317u, 13806, 20836, 158, 199, 185, 37, 66, 100, 139, 75)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(UniformGridLayout))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IUniformGridLayout
	{
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		Orientation Orientation
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
		double MinItemWidth
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
		double MinItemHeight
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
		double MinRowSpacing
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
		double MinColumnSpacing
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
		UniformGridLayoutItemsJustification ItemsJustification
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
		UniformGridLayoutItemsStretch ItemsStretch
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		int MaximumRowsOrColumns
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}
	}
}
