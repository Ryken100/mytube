using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000223 RID: 547
	[Composable(typeof(ITreeViewItemFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[Threading(3)]
	[Static(typeof(ITreeViewItemStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Static(typeof(ITreeViewItemStatics2), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	public class TreeViewItem : ListViewItem, ITreeViewItem, ITreeViewItem2
	{
		// Token: 0x06000BB2 RID: 2994
		public extern TreeViewItem();

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06000BB3 RID: 2995
		// (set) Token: 0x06000BB4 RID: 2996
		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		public extern double GlyphOpacity
		{
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06000BB5 RID: 2997
		// (set) Token: 0x06000BB6 RID: 2998
		public extern Brush GlyphBrush
		{
			get; [param: In]
			set;
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06000BB7 RID: 2999
		// (set) Token: 0x06000BB8 RID: 3000
		[MUXPropertyDefaultValue(value = "\\uE70D")]
		[MUXPropertyDefaultValue(value = "\\uE70D")]
		public extern string ExpandedGlyph
		{
			[MUXPropertyDefaultValue(value = "\\uE70D")]
			get;
			[MUXPropertyDefaultValue(value = "\\uE70D")]
			[param: In]
			set;
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06000BB9 RID: 3001
		// (set) Token: 0x06000BBA RID: 3002
		[MUXPropertyDefaultValue(value = "\\uE76C")]
		[MUXPropertyDefaultValue(value = "\\uE76C")]
		public extern string CollapsedGlyph
		{
			[MUXPropertyDefaultValue(value = "\\uE76C")]
			get;
			[MUXPropertyDefaultValue(value = "\\uE76C")]
			[param: In]
			set;
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06000BBB RID: 3003
		// (set) Token: 0x06000BBC RID: 3004
		[MUXPropertyDefaultValue(value = "8.0")]
		[MUXPropertyDefaultValue(value = "8.0")]
		public extern double GlyphSize
		{
			[MUXPropertyDefaultValue(value = "8.0")]
			get;
			[MUXPropertyDefaultValue(value = "8.0")]
			[param: In]
			set;
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06000BBD RID: 3005
		// (set) Token: 0x06000BBE RID: 3006
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool IsExpanded
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06000BBF RID: 3007
		public extern TreeViewItemTemplateSettings TreeViewItemTemplateSettings { get; }

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06000BC0 RID: 3008
		// (set) Token: 0x06000BC1 RID: 3009
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool HasUnrealizedChildren
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06000BC2 RID: 3010
		// (set) Token: 0x06000BC3 RID: 3011
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern object ItemsSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06000BC4 RID: 3012
		public static extern DependencyProperty HasUnrealizedChildrenProperty { get; }

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06000BC5 RID: 3013
		public static extern DependencyProperty ItemsSourceProperty { get; }

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06000BC6 RID: 3014
		public static extern DependencyProperty GlyphOpacityProperty { get; }

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06000BC7 RID: 3015
		public static extern DependencyProperty GlyphBrushProperty { get; }

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06000BC8 RID: 3016
		public static extern DependencyProperty ExpandedGlyphProperty { get; }

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06000BC9 RID: 3017
		public static extern DependencyProperty CollapsedGlyphProperty { get; }

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06000BCA RID: 3018
		public static extern DependencyProperty GlyphSizeProperty { get; }

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06000BCB RID: 3019
		public static extern DependencyProperty IsExpandedProperty { get; }

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06000BCC RID: 3020
		public static extern DependencyProperty TreeViewItemTemplateSettingsProperty { get; }
	}
}
