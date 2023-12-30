using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(XamlControlsResources))]
	[MUXPropertyChangedCallback(enable = true)]
	[Windows.Foundation.Metadata.Guid(1345675536u, 2961, 21230, 152, 78, 86, 42, byte.MaxValue, 152, 25, 98)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 131072u)]
	internal interface IXamlControlsResourcesStatics3
	{
		DependencyProperty ControlsResourcesVersionProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
