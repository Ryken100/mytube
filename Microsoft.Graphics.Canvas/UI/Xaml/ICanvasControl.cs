using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F0 RID: 240
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasControl))]
	[Guid(4026982509U, 31195, 18511, 184, 152, 71, 156, 240, 105, 192, 245)]
	internal interface ICanvasControl : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060007A0 RID: 1952
		// (remove) Token: 0x060007A1 RID: 1953
		event TypedEventHandler<CanvasControl, CanvasCreateResourcesEventArgs> CreateResources;

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060007A2 RID: 1954
		bool ReadyToDraw { get; }

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060007A3 RID: 1955
		// (remove) Token: 0x060007A4 RID: 1956
		event TypedEventHandler<CanvasControl, CanvasDrawEventArgs> Draw;

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060007A6 RID: 1958
		// (set) Token: 0x060007A5 RID: 1957
		Color ClearColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x060007A7 RID: 1959
		void Invalidate();

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060007A8 RID: 1960
		Size Size { get; }

		// Token: 0x060007A9 RID: 1961
		void RemoveFromVisualTree();

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060007AA RID: 1962
		// (set) Token: 0x060007AB RID: 1963
		bool UseSharedDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060007AC RID: 1964
		// (set) Token: 0x060007AD RID: 1965
		bool ForceSoftwareRenderer
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060007AE RID: 1966
		// (set) Token: 0x060007AF RID: 1967
		CanvasDevice CustomDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060007B0 RID: 1968
		// (set) Token: 0x060007B1 RID: 1969
		float DpiScale
		{
			get; [param: In]
			set;
		}
	}
}
