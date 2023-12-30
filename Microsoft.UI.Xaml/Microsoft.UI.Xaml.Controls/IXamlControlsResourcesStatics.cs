using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallback(enable = true)]
	[Windows.Foundation.Metadata.Guid(2411326363u, 34058, 21029, 150, 207, 167, 32, 54, 4, 51, 66)]
	[ExclusiveTo(typeof(XamlControlsResources))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IXamlControlsResourcesStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void EnsureRevealLights([In] UIElement element);
	}
}
