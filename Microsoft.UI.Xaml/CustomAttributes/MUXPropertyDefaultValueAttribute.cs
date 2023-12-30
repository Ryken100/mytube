using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.CustomAttributes
{
	// Token: 0x02000236 RID: 566
	[Version(1U)]
	[WebHostHidden]
	[AttributeUsage(320)]
	public sealed class MUXPropertyDefaultValueAttribute : Attribute
	{
		// Token: 0x06000C3C RID: 3132
		public extern MUXPropertyDefaultValueAttribute();

		// Token: 0x040000C5 RID: 197
		public string value;
	}
}
