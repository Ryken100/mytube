using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Core;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000E7 RID: 231
	[Version(167772160U)]
	[Guid(2614394125U, 54653, 17335, 130, 203, 72, 156, 197, 102, 232, 135)]
	public interface ICanvasAnimatedControl : ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600074B RID: 1867
		// (remove) Token: 0x0600074C RID: 1868
		event TypedEventHandler<CanvasAnimatedControl, CanvasCreateResourcesEventArgs> CreateResources;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600074D RID: 1869
		// (remove) Token: 0x0600074E RID: 1870
		event TypedEventHandler<ICanvasAnimatedControl, CanvasAnimatedUpdateEventArgs> Update;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600074F RID: 1871
		// (remove) Token: 0x06000750 RID: 1872
		event TypedEventHandler<ICanvasAnimatedControl, CanvasAnimatedDrawEventArgs> Draw;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000751 RID: 1873
		// (remove) Token: 0x06000752 RID: 1874
		event TypedEventHandler<ICanvasAnimatedControl, object> GameLoopStarting;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000753 RID: 1875
		// (remove) Token: 0x06000754 RID: 1876
		event TypedEventHandler<ICanvasAnimatedControl, object> GameLoopStopped;

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000755 RID: 1877
		bool ReadyToDraw { get; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000757 RID: 1879
		// (set) Token: 0x06000756 RID: 1878
		bool IsFixedTimeStep
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000759 RID: 1881
		// (set) Token: 0x06000758 RID: 1880
		TimeSpan TargetElapsedTime
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x0600075B RID: 1883
		// (set) Token: 0x0600075A RID: 1882
		bool Paused
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600075D RID: 1885
		// (set) Token: 0x0600075C RID: 1884
		Color ClearColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600075E RID: 1886
		Size Size { get; }

		// Token: 0x0600075F RID: 1887
		void Invalidate();

		// Token: 0x06000760 RID: 1888
		void ResetElapsedTime();

		// Token: 0x06000761 RID: 1889
		CoreIndependentInputSource CreateCoreIndependentInputSource([In] CoreInputDeviceTypes deviceTypes);

		// Token: 0x06000762 RID: 1890
		void RemoveFromVisualTree();

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000763 RID: 1891
		bool HasGameLoopThreadAccess { get; }

		// Token: 0x06000764 RID: 1892
		IAsyncAction RunOnGameLoopThreadAsync([In] DispatchedHandler agileCallback);

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000765 RID: 1893
		// (set) Token: 0x06000766 RID: 1894
		bool UseSharedDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000767 RID: 1895
		// (set) Token: 0x06000768 RID: 1896
		bool ForceSoftwareRenderer
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000769 RID: 1897
		// (set) Token: 0x0600076A RID: 1898
		CanvasDevice CustomDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600076B RID: 1899
		// (set) Token: 0x0600076C RID: 1900
		float DpiScale
		{
			get; [param: In]
			set;
		}
	}
}
