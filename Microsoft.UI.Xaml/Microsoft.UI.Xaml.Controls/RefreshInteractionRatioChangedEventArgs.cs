using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class RefreshInteractionRatioChangedEventArgs : IRefreshInteractionRatioChangedEventArgs
	{
		public extern double InteractionRatio
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
