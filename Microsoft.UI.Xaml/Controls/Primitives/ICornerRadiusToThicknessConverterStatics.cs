using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D7 RID: 471
	[ExclusiveTo(typeof(CornerRadiusToThicknessConverter))]
	[WebHostHidden]
	[Guid(3600373321U, 35538, 23608, 188, 69, 184, 239, 134, 255, 95, 105)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ICornerRadiusToThicknessConverterStatics
	{
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000964 RID: 2404
		DependencyProperty ConversionKindProperty { get; }

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000965 RID: 2405
		DependencyProperty MultiplierProperty { get; }
	}
}
