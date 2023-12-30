using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(2030792928u, 61849, 21803, 177, 38, 108, 180, 92, 45, 232, 249)]
	[ExclusiveTo(typeof(RefreshInteractionRatioChangedEventArgs))]
	[WebHostHidden]
	internal interface IRefreshInteractionRatioChangedEventArgs
	{
		double InteractionRatio
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
