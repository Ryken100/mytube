using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000067 RID: 103
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	public sealed class CanvasTypography : ICanvasTypography, IClosable
	{
		// Token: 0x060002FA RID: 762
		public extern CanvasTypography();

		// Token: 0x060002FB RID: 763
		[Overload("AddFeature")]
		public extern void AddFeature([In] CanvasTypographyFeature feature);

		// Token: 0x060002FC RID: 764
		[Overload("AddFeatureWithNameAndParameter")]
		public extern void AddFeature([In] CanvasTypographyFeatureName name, [In] uint parameter);

		// Token: 0x060002FD RID: 765
		public extern CanvasTypographyFeature[] GetFeatures();

		// Token: 0x060002FE RID: 766
		public extern void Close();
	}
}
