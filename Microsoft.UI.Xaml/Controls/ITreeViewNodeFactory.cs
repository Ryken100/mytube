using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200016E RID: 366
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(TreeViewNode))]
	[Guid(3238372837U, 52904, 24317, 139, 232, 61, 137, 181, 76, 189, 95)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITreeViewNodeFactory
	{
		// Token: 0x0600063E RID: 1598
		TreeViewNode CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
