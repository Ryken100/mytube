using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.CustomAttributes
{
	// Token: 0x02000234 RID: 564
	[WebHostHidden]
	[AttributeUsage(1875)]
	[Version(1U)]
	public sealed class MUXPropertyChangedCallbackAttribute : Attribute
	{
		// Token: 0x06000C3A RID: 3130
		public extern MUXPropertyChangedCallbackAttribute();

		// Token: 0x040000C3 RID: 195
		public bool enable;
	}
}
