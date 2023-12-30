using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000162 RID: 354
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3183375964U, 22343, 20842, 158, 13, 177, 205, 32, 153, 56, 76)]
	[ExclusiveTo(typeof(TreeViewItem))]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ITreeViewItem
	{
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600060C RID: 1548
		// (set) Token: 0x0600060D RID: 1549
		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		double GlyphOpacity
		{
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600060E RID: 1550
		// (set) Token: 0x0600060F RID: 1551
		Brush GlyphBrush
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000610 RID: 1552
		// (set) Token: 0x06000611 RID: 1553
		[MUXPropertyDefaultValue(value = "\\uE70D")]
		[MUXPropertyDefaultValue(value = "\\uE70D")]
		string ExpandedGlyph
		{
			[MUXPropertyDefaultValue(value = "\\uE70D")]
			get;
			[MUXPropertyDefaultValue(value = "\\uE70D")]
			[param: In]
			set;
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000612 RID: 1554
		// (set) Token: 0x06000613 RID: 1555
		[MUXPropertyDefaultValue(value = "\\uE76C")]
		[MUXPropertyDefaultValue(value = "\\uE76C")]
		string CollapsedGlyph
		{
			[MUXPropertyDefaultValue(value = "\\uE76C")]
			get;
			[MUXPropertyDefaultValue(value = "\\uE76C")]
			[param: In]
			set;
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000614 RID: 1556
		// (set) Token: 0x06000615 RID: 1557
		[MUXPropertyDefaultValue(value = "8.0")]
		[MUXPropertyDefaultValue(value = "8.0")]
		double GlyphSize
		{
			[MUXPropertyDefaultValue(value = "8.0")]
			get;
			[MUXPropertyDefaultValue(value = "8.0")]
			[param: In]
			set;
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000616 RID: 1558
		// (set) Token: 0x06000617 RID: 1559
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool IsExpanded
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000618 RID: 1560
		TreeViewItemTemplateSettings TreeViewItemTemplateSettings { get; }
	}
}
