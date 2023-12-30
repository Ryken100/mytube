using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001CC RID: 460
	[ExclusiveTo(typeof(ColumnMajorUniformToLargestGridLayout))]
	[WebHostHidden]
	[Guid(790736729U, 5509, 21285, 132, 18, 43, 131, 191, 5, 211, 69)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IColumnMajorUniformToLargestGridLayoutFactory
	{
		// Token: 0x0600093A RID: 2362
		ColumnMajorUniformToLargestGridLayout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
