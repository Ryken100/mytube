using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(RatingControl))]
	[Windows.Foundation.Metadata.Guid(2772147059u, 49145, 21645, 162, 148, 172, 99, 216, 25, 247, 138)]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IRatingControlFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RatingControl CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
