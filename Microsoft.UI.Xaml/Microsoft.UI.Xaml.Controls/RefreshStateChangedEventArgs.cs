using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public sealed class RefreshStateChangedEventArgs : IRefreshStateChangedEventArgs
	{
		public extern RefreshVisualizerState NewState
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern RefreshVisualizerState OldState
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
