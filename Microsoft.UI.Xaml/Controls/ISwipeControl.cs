using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000130 RID: 304
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[Guid(863502590U, 62749, 24427, 157, 53, 231, 245, 222, 16, 169, 124)]
	[ExclusiveTo(typeof(SwipeControl))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface ISwipeControl
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060004DF RID: 1247
		// (set) Token: 0x060004E0 RID: 1248
		SwipeItems LeftItems
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060004E1 RID: 1249
		// (set) Token: 0x060004E2 RID: 1250
		SwipeItems RightItems
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060004E3 RID: 1251
		// (set) Token: 0x060004E4 RID: 1252
		SwipeItems TopItems
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060004E5 RID: 1253
		// (set) Token: 0x060004E6 RID: 1254
		SwipeItems BottomItems
		{
			get; [param: In]
			set;
		}

		// Token: 0x060004E7 RID: 1255
		void Close();
	}
}
