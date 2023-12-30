using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(CommandBarFlyout))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(4176853180u, 36199, 24489, 143, 176, 194, 195, 49, 30, 27, 124)]
	[WebHostHidden]
	internal interface ICommandBarFlyout
	{
		IObservableVector<ICommandBarElement> PrimaryCommands
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		IObservableVector<ICommandBarElement> SecondaryCommands
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
