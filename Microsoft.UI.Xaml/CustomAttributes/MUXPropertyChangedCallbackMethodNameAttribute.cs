using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.CustomAttributes
{
	// Token: 0x02000235 RID: 565
	[Version(1U)]
	[AttributeUsage(1875)]
	[WebHostHidden]
	public sealed class MUXPropertyChangedCallbackMethodNameAttribute : Attribute
	{
		// Token: 0x06000C3B RID: 3131
		public extern MUXPropertyChangedCallbackMethodNameAttribute();

		// Token: 0x040000C4 RID: 196
		public string value;
	}
}
