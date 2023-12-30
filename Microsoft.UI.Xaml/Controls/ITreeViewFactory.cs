using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000161 RID: 353
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(2623676606U, 63979, 20874, 179, 14, 126, 65, 222, 94, 253, 169)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TreeView))]
	internal interface ITreeViewFactory
	{
		// Token: 0x0600060B RID: 1547
		TreeView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
