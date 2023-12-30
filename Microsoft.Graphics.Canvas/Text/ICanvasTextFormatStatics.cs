using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x02000062 RID: 98
	[Guid(2324854037U, 13308, 19602, 166, 170, 148, 168, 242, 156, 20, 11)]
	[ExclusiveTo(typeof(CanvasTextFormat))]
	[Version(167772160U)]
	internal interface ICanvasTextFormatStatics
	{
		// Token: 0x060002C3 RID: 707
		[Overload("GetSystemFontFamilies")]
		string[] GetSystemFontFamilies();

		// Token: 0x060002C4 RID: 708
		[Overload("GetSystemFontFamiliesFromLocaleList")]
		string[] GetSystemFontFamilies([In] IVectorView<string> localeList);
	}
}
