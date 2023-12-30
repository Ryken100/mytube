using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D6 RID: 470
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(CornerRadiusToThicknessConverter))]
	[Guid(3010111662U, 5742, 23717, 147, 210, 149, 233, 144, 124, 18, 34)]
	internal interface ICornerRadiusToThicknessConverter
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000960 RID: 2400
		// (set) Token: 0x06000961 RID: 2401
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
		CornerRadiusToThicknessConverterKind ConversionKind
		{
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
			[param: In]
			set;
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000962 RID: 2402
		// (set) Token: 0x06000963 RID: 2403
		[MUXPropertyDefaultValue(value = "1.0f")]
		[MUXPropertyDefaultValue(value = "1.0f")]
		double Multiplier
		{
			[MUXPropertyDefaultValue(value = "1.0f")]
			get;
			[MUXPropertyDefaultValue(value = "1.0f")]
			[param: In]
			set;
		}
	}
}
