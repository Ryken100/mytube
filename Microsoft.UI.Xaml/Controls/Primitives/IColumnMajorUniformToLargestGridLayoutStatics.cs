using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001CD RID: 461
	[WebHostHidden]
	[ExclusiveTo(typeof(ColumnMajorUniformToLargestGridLayout))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(698461218U, 60977, 20511, 148, 248, 160, 13, 51, 143, 16, 10)]
	internal interface IColumnMajorUniformToLargestGridLayoutStatics
	{
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600093B RID: 2363
		DependencyProperty MaxColumnsProperty { get; }

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600093C RID: 2364
		DependencyProperty ColumnSpacingProperty { get; }

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600093D RID: 2365
		DependencyProperty RowSpacingProperty { get; }
	}
}
