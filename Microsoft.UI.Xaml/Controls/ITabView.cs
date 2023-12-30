using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200013D RID: 317
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1789364139U, 23088, 24226, 190, 91, 174, 216, 104, 56, 23, 86)]
	[WebHostHidden]
	[ExclusiveTo(typeof(TabView))]
	internal interface ITabView
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600050E RID: 1294
		// (set) Token: 0x0600050F RID: 1295
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::TabViewWidthMode::Equal")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::TabViewWidthMode::Equal")]
		TabViewWidthMode TabWidthMode
		{
			[MUXPropertyDefaultValue(value = "winrt::TabViewWidthMode::Equal")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TabViewWidthMode::Equal")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000510 RID: 1296
		// (set) Token: 0x06000511 RID: 1297
		[MUXPropertyDefaultValue(value = "winrt::TabViewCloseButtonOverlayMode::Auto")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::TabViewCloseButtonOverlayMode::Auto")]
		[MUXPropertyChangedCallback(enable = true)]
		TabViewCloseButtonOverlayMode CloseButtonOverlayMode
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::TabViewCloseButtonOverlayMode::Auto")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::TabViewCloseButtonOverlayMode::Auto")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000512 RID: 1298
		// (set) Token: 0x06000513 RID: 1299
		object TabStripHeader
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000514 RID: 1300
		// (set) Token: 0x06000515 RID: 1301
		DataTemplate TabStripHeaderTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000516 RID: 1302
		// (set) Token: 0x06000517 RID: 1303
		object TabStripFooter
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000518 RID: 1304
		// (set) Token: 0x06000519 RID: 1305
		DataTemplate TabStripFooterTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600051A RID: 1306
		// (set) Token: 0x0600051B RID: 1307
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool IsAddTabButtonVisible
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600051C RID: 1308
		// (set) Token: 0x0600051D RID: 1309
		ICommand AddTabButtonCommand
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600051E RID: 1310
		// (set) Token: 0x0600051F RID: 1311
		object AddTabButtonCommandParameter
		{
			get; [param: In]
			set;
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000520 RID: 1312
		// (remove) Token: 0x06000521 RID: 1313
		event TypedEventHandler<TabView, TabViewTabCloseRequestedEventArgs> TabCloseRequested;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000522 RID: 1314
		// (remove) Token: 0x06000523 RID: 1315
		event TypedEventHandler<TabView, TabViewTabDroppedOutsideEventArgs> TabDroppedOutside;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000524 RID: 1316
		// (remove) Token: 0x06000525 RID: 1317
		event TypedEventHandler<TabView, object> AddTabButtonClick;

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000526 RID: 1318
		// (remove) Token: 0x06000527 RID: 1319
		event TypedEventHandler<TabView, IVectorChangedEventArgs> TabItemsChanged;

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000528 RID: 1320
		// (set) Token: 0x06000529 RID: 1321
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		object TabItemsSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600052A RID: 1322
		IVector<object> TabItems { get; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600052B RID: 1323
		// (set) Token: 0x0600052C RID: 1324
		DataTemplate TabItemTemplate
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600052D RID: 1325
		// (set) Token: 0x0600052E RID: 1326
		DataTemplateSelector TabItemTemplateSelector
		{
			get; [param: In]
			set;
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600052F RID: 1327
		// (set) Token: 0x06000530 RID: 1328
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyDefaultValue(value = "false")]
		bool CanDragTabs
		{
			[MUXPropertyDefaultValue(value = "false")]
			get;
			[MUXPropertyDefaultValue(value = "false")]
			[param: In]
			set;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000531 RID: 1329
		// (set) Token: 0x06000532 RID: 1330
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool CanReorderTabs
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000533 RID: 1331
		// (set) Token: 0x06000534 RID: 1332
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		bool AllowDropTabs
		{
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000535 RID: 1333
		// (set) Token: 0x06000536 RID: 1334
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		int SelectedIndex
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000537 RID: 1335
		// (set) Token: 0x06000538 RID: 1336
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		object SelectedItem
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x06000539 RID: 1337
		DependencyObject ContainerFromItem([In] object item);

		// Token: 0x0600053A RID: 1338
		DependencyObject ContainerFromIndex([In] int index);

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600053B RID: 1339
		// (remove) Token: 0x0600053C RID: 1340
		event SelectionChangedEventHandler SelectionChanged;

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x0600053D RID: 1341
		// (remove) Token: 0x0600053E RID: 1342
		event TypedEventHandler<TabView, TabViewTabDragStartingEventArgs> TabDragStarting;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600053F RID: 1343
		// (remove) Token: 0x06000540 RID: 1344
		event TypedEventHandler<TabView, TabViewTabDragCompletedEventArgs> TabDragCompleted;

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000541 RID: 1345
		// (remove) Token: 0x06000542 RID: 1346
		event DragEventHandler TabStripDragOver;

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000543 RID: 1347
		// (remove) Token: 0x06000544 RID: 1348
		event DragEventHandler TabStripDrop;
	}
}
