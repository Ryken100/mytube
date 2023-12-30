using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000166 RID: 358
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TreeViewItem))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(519389656U, 63821, 24450, 159, 67, 26, 84, 236, 234, 212, 77)]
	internal interface ITreeViewItemStatics
	{
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000621 RID: 1569
		DependencyProperty GlyphOpacityProperty { get; }

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000622 RID: 1570
		DependencyProperty GlyphBrushProperty { get; }

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000623 RID: 1571
		DependencyProperty ExpandedGlyphProperty { get; }

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000624 RID: 1572
		DependencyProperty CollapsedGlyphProperty { get; }

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000625 RID: 1573
		DependencyProperty GlyphSizeProperty { get; }

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000626 RID: 1574
		DependencyProperty IsExpandedProperty { get; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000627 RID: 1575
		DependencyProperty TreeViewItemTemplateSettingsProperty { get; }
	}
}
