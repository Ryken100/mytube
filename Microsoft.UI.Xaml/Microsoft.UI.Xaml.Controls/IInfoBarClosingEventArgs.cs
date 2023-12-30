using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(103612886u, 25007, 21557, 140, 75, 197, 17, 6, 88, 59, 91)]
	[ExclusiveTo(typeof(InfoBarClosingEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	internal interface IInfoBarClosingEventArgs
	{
		InfoBarCloseReason Reason
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		bool Cancel
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
