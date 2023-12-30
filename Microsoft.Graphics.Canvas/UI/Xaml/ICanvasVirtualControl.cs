using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F9 RID: 249
	[ExclusiveTo(typeof(CanvasVirtualControl))]
	[Guid(1009471863U, 31841, 16850, 149, 174, 252, 252, 146, 253, 97, 122)]
	[Version(167772160U)]
	internal interface ICanvasVirtualControl : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000800 RID: 2048
		// (remove) Token: 0x06000801 RID: 2049
		event TypedEventHandler<CanvasVirtualControl, CanvasCreateResourcesEventArgs> CreateResources;

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000802 RID: 2050
		bool ReadyToDraw { get; }

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000803 RID: 2051
		// (remove) Token: 0x06000804 RID: 2052
		event TypedEventHandler<CanvasVirtualControl, CanvasRegionsInvalidatedEventArgs> RegionsInvalidated;

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000806 RID: 2054
		// (set) Token: 0x06000805 RID: 2053
		Color ClearColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000807 RID: 2055
		CanvasDrawingSession CreateDrawingSession([In] Rect updateRectangle);

		// Token: 0x06000808 RID: 2056
		void SuspendDrawingSession([In] CanvasDrawingSession drawingSession);

		// Token: 0x06000809 RID: 2057
		void ResumeDrawingSession([In] CanvasDrawingSession drawingSession);

		// Token: 0x0600080A RID: 2058
		[Overload("Invalidate")]
		void Invalidate();

		// Token: 0x0600080B RID: 2059
		[Overload("InvalidateRegion")]
		void Invalidate([In] Rect region);

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600080C RID: 2060
		Size Size { get; }

		// Token: 0x0600080D RID: 2061
		void RemoveFromVisualTree();

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600080E RID: 2062
		// (set) Token: 0x0600080F RID: 2063
		bool UseSharedDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000810 RID: 2064
		// (set) Token: 0x06000811 RID: 2065
		bool ForceSoftwareRenderer
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000812 RID: 2066
		// (set) Token: 0x06000813 RID: 2067
		CanvasDevice CustomDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000814 RID: 2068
		// (set) Token: 0x06000815 RID: 2069
		float DpiScale
		{
			get; [param: In]
			set;
		}
	}
}
