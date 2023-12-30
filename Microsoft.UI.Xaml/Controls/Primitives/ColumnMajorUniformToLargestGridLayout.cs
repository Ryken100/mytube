using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001BA RID: 442
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Composable(typeof(IColumnMajorUniformToLargestGridLayoutFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IColumnMajorUniformToLargestGridLayoutStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public class ColumnMajorUniformToLargestGridLayout : NonVirtualizingLayout, IColumnMajorUniformToLargestGridLayout
	{
		// Token: 0x060008D4 RID: 2260
		public extern ColumnMajorUniformToLargestGridLayout();

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060008D5 RID: 2261
		// (set) Token: 0x060008D6 RID: 2262
		[MUXPropertyValidationCallback(value = "ValidateGreaterThanZero")]
		[MUXPropertyValidationCallback(value = "ValidateGreaterThanZero")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern int MaxColumns
		{
			[MUXPropertyValidationCallback(value = "ValidateGreaterThanZero")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyValidationCallback(value = "ValidateGreaterThanZero")]
			[param: In]
			set;
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060008D7 RID: 2263
		// (set) Token: 0x060008D8 RID: 2264
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern double ColumnSpacing
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060008D9 RID: 2265
		// (set) Token: 0x060008DA RID: 2266
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern double RowSpacing
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060008DB RID: 2267
		public static extern DependencyProperty MaxColumnsProperty { get; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060008DC RID: 2268
		public static extern DependencyProperty ColumnSpacingProperty { get; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060008DD RID: 2269
		public static extern DependencyProperty RowSpacingProperty { get; }
	}
}
