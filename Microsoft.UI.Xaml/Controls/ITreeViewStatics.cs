using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000170 RID: 368
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3347089268U, 31652, 21759, 157, 58, 76, 184, 146, 114, 154, 215)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(TreeView))]
	internal interface ITreeViewStatics
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000643 RID: 1603
		DependencyProperty SelectedItemProperty { get; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000644 RID: 1604
		DependencyProperty SelectionModeProperty { get; }
	}
}
