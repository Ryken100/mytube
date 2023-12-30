using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200017F RID: 383
	[Version(167772160U)]
	[Guid(1709381489U, 19375, 23692, 147, 244, 59, 135, 78, 41, 246, 141)]
	[ExclusiveTo(typeof(TintEffect))]
	internal interface ITintEffectStatics
	{
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06001000 RID: 4096
		bool IsSupported { get; }
	}
}
