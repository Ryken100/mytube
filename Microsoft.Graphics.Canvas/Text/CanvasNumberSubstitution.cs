using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000099 RID: 153
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Activatable(typeof(ICanvasNumberSubstitutionFactory), 167772160U)]
	public sealed class CanvasNumberSubstitution : ICanvasNumberSubstitution, IClosable
	{
		// Token: 0x060004B8 RID: 1208
		public extern CanvasNumberSubstitution([In] CanvasNumberSubstitutionMethod method);

		// Token: 0x060004B9 RID: 1209
		public extern CanvasNumberSubstitution([In] CanvasNumberSubstitutionMethod method, [In] string localeName, [In] bool ignoreEnvironmentOverrides);

		// Token: 0x060004BA RID: 1210
		public extern void Close();
	}
}
