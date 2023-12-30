using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D4 RID: 468
	[Guid(1863990994U, 63845, 21598, 189, 68, 68, 29, 177, 121, 79, 95)]
	[WebHostHidden]
	[ExclusiveTo(typeof(CornerRadiusFilterConverter))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ICornerRadiusFilterConverter
	{
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x0600095A RID: 2394
		// (set) Token: 0x0600095B RID: 2395
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
		CornerRadiusFilterKind Filter
		{
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
			[param: In]
			set;
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x0600095C RID: 2396
		// (set) Token: 0x0600095D RID: 2397
		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		double Scale
		{
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}
	}
}
