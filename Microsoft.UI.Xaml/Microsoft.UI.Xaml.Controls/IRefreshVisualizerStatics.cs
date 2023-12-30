using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(2124296875u, 15417, 22700, 157, 13, 70, 72, 190, 34, 11, 220)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(RefreshVisualizer))]
	internal interface IRefreshVisualizerStatics
	{
		[MUXPropertyType(value = "winrt::IInspectable")]
		DependencyProperty InfoProviderProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyType(value = "winrt::IInspectable")]
			get;
		}

		DependencyProperty OrientationProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty ContentProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty StateProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
