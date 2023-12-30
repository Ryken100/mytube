using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(ColumnMajorUniformToLargestGridLayout))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(698461218u, 60977, 20511, 148, 248, 160, 13, 51, 143, 16, 10)]
	internal interface IColumnMajorUniformToLargestGridLayoutStatics
	{
		DependencyProperty MaxColumnsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty ColumnSpacingProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty RowSpacingProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
