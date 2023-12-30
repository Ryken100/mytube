using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ExclusiveTo(typeof(ColumnMajorUniformToLargestGridLayout))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(790736729u, 5509, 21285, 132, 18, 43, 131, 191, 5, 211, 69)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IColumnMajorUniformToLargestGridLayoutFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ColumnMajorUniformToLargestGridLayout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
