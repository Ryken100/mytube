using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.CustomAttributes
{
	// Token: 0x02000238 RID: 568
	[Version(1U)]
	[WebHostHidden]
	[AttributeUsage(320)]
	public sealed class MUXPropertyTypeAttribute : Attribute
	{
		// Token: 0x06000C3E RID: 3134
		public extern MUXPropertyTypeAttribute();

		// Token: 0x040000C6 RID: 198
		public string value;
	}
}
