using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(2641308658u, 26152, 22570, 137, 43, 104, 194, 119, 12, 23, 60)]
	[ExclusiveTo(typeof(RefreshVisualizer))]
	[WebHostHidden]
	internal interface IRefreshVisualizerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RefreshVisualizer CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
