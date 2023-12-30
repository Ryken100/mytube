using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000E8 RID: 232
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Version(167772160U)]
	[Activatable(167772160U)]
	public sealed class CanvasAnimatedControl : UserControl, ICanvasAnimatedControl, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x0600076D RID: 1901
		public extern CanvasAnimatedControl();

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600076E RID: 1902
		// (remove) Token: 0x0600076F RID: 1903
		public extern event TypedEventHandler<CanvasAnimatedControl, CanvasCreateResourcesEventArgs> CreateResources;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000770 RID: 1904
		// (remove) Token: 0x06000771 RID: 1905
		public extern event TypedEventHandler<ICanvasAnimatedControl, CanvasAnimatedUpdateEventArgs> Update;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000772 RID: 1906
		// (remove) Token: 0x06000773 RID: 1907
		public extern event TypedEventHandler<ICanvasAnimatedControl, CanvasAnimatedDrawEventArgs> Draw;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000774 RID: 1908
		// (remove) Token: 0x06000775 RID: 1909
		public extern event TypedEventHandler<ICanvasAnimatedControl, object> GameLoopStarting;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000776 RID: 1910
		// (remove) Token: 0x06000777 RID: 1911
		public extern event TypedEventHandler<ICanvasAnimatedControl, object> GameLoopStopped;

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000778 RID: 1912
		public extern bool ReadyToDraw { get; }

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600077A RID: 1914
		// (set) Token: 0x06000779 RID: 1913
		public extern bool IsFixedTimeStep
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600077C RID: 1916
		// (set) Token: 0x0600077B RID: 1915
		public extern TimeSpan TargetElapsedTime
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600077E RID: 1918
		// (set) Token: 0x0600077D RID: 1917
		public extern bool Paused
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000780 RID: 1920
		// (set) Token: 0x0600077F RID: 1919
		public extern Color ClearColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000781 RID: 1921
		public extern Size Size { get; }

		// Token: 0x06000782 RID: 1922
		public extern void Invalidate();

		// Token: 0x06000783 RID: 1923
		public extern void ResetElapsedTime();

		// Token: 0x06000784 RID: 1924
		public extern CoreIndependentInputSource CreateCoreIndependentInputSource([In] CoreInputDeviceTypes deviceTypes);

		// Token: 0x06000785 RID: 1925
		public extern void RemoveFromVisualTree();

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000786 RID: 1926
		public extern bool HasGameLoopThreadAccess { get; }

		// Token: 0x06000787 RID: 1927
		public extern IAsyncAction RunOnGameLoopThreadAsync([In] DispatchedHandler agileCallback);

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000788 RID: 1928
		// (set) Token: 0x06000789 RID: 1929
		public extern bool UseSharedDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600078A RID: 1930
		// (set) Token: 0x0600078B RID: 1931
		public extern bool ForceSoftwareRenderer
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600078C RID: 1932
		// (set) Token: 0x0600078D RID: 1933
		public extern CanvasDevice CustomDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600078E RID: 1934
		// (set) Token: 0x0600078F RID: 1935
		public extern float DpiScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000790 RID: 1936
		public extern float Dpi { get; }

		// Token: 0x06000791 RID: 1937
		public extern float ConvertPixelsToDips([In] int pixels);

		// Token: 0x06000792 RID: 1938
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000793 RID: 1939
		public extern CanvasDevice Device { get; }
	}
}
