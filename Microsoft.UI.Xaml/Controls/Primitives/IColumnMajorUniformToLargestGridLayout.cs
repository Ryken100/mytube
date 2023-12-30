using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001CB RID: 459
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3994068650U, 61419, 20908, 183, 145, 113, 145, 58, 232, 194, 53)]
	[WebHostHidden]
	[ExclusiveTo(typeof(ColumnMajorUniformToLargestGridLayout))]
	internal interface IColumnMajorUniformToLargestGridLayout
	{
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000934 RID: 2356
		// (set) Token: 0x06000935 RID: 2357
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyValidationCallback(value = "ValidateGreaterThanZero")]
		[MUXPropertyValidationCallback(value = "ValidateGreaterThanZero")]
		[MUXPropertyChangedCallback(enable = true)]
		int MaxColumns
		{
			[MUXPropertyValidationCallback(value = "ValidateGreaterThanZero")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyValidationCallback(value = "ValidateGreaterThanZero")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000936 RID: 2358
		// (set) Token: 0x06000937 RID: 2359
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		double ColumnSpacing
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000938 RID: 2360
		// (set) Token: 0x06000939 RID: 2361
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		double RowSpacing
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
