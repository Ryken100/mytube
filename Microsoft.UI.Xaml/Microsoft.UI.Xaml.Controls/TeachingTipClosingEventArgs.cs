using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public sealed class TeachingTipClosingEventArgs : ITeachingTipClosingEventArgs
	{
		public extern bool Cancel
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern TeachingTipCloseReason Reason
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern Deferral GetDeferral();
	}
}
