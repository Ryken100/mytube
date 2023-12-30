using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200007A RID: 122
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[ExclusiveTo(typeof(AnimatedIcon))]
	[Guid(941135528U, 61087, 22563, 171, 241, 181, 150, 173, 204, 119, 209)]
	internal interface IAnimatedIconStatics
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000156 RID: 342
		[MUXPropertyChangedCallbackMethodName(value = "OnAnimatedIconStatePropertyChanged")]
		DependencyProperty StateProperty
		{
			[MUXPropertyChangedCallbackMethodName(value = "OnAnimatedIconStatePropertyChanged")]
			get;
		}

		// Token: 0x06000157 RID: 343
		void SetState([In] DependencyObject @object, [In] string value);

		// Token: 0x06000158 RID: 344
		string GetState([In] DependencyObject @object);

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000159 RID: 345
		DependencyProperty SourceProperty { get; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600015A RID: 346
		DependencyProperty FallbackIconSourceProperty { get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600015B RID: 347
		DependencyProperty MirroredWhenRightToLeftProperty { get; }
	}
}
