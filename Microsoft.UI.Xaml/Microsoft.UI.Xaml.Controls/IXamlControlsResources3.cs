using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 131072u)]
	[Windows.Foundation.Metadata.Guid(1000425103u, 8875, 21003, 141, 23, 156, 187, 62, 238, 149, 12)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[ExclusiveTo(typeof(XamlControlsResources))]
	[WebHostHidden]
	internal interface IXamlControlsResources3
	{
		[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
		[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
		ControlsResourcesVersion ControlsResourcesVersion
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
			[param: In]
			set;
		}
	}
}
