using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000066 RID: 102
	[Guid(4049322770U, 17535, 17645, 139, 236, 126, 64, 244, 164, 223, 200)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasTypography))]
	internal interface ICanvasTypography : IClosable
	{
		// Token: 0x060002F7 RID: 759
		[Overload("AddFeature")]
		void AddFeature([In] CanvasTypographyFeature feature);

		// Token: 0x060002F8 RID: 760
		[Overload("AddFeatureWithNameAndParameter")]
		void AddFeature([In] CanvasTypographyFeatureName name, [In] uint parameter);

		// Token: 0x060002F9 RID: 761
		CanvasTypographyFeature[] GetFeatures();
	}
}
