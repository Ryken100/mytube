using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000098 RID: 152
	[ExclusiveTo(typeof(CanvasNumberSubstitution))]
	[Version(167772160U)]
	[Guid(1956030498U, 51073, 20144, 170, 251, 192, 120, 231, 250, 142, 36)]
	internal interface ICanvasNumberSubstitutionFactory
	{
		// Token: 0x060004B6 RID: 1206
		CanvasNumberSubstitution Create([In] CanvasNumberSubstitutionMethod method);

		// Token: 0x060004B7 RID: 1207
		CanvasNumberSubstitution CreateWithLocaleAndIgnoreOverrides([In] CanvasNumberSubstitutionMethod method, [In] string localeName, [In] bool ignoreEnvironmentOverrides);
	}
}
