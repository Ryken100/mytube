using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[Static(typeof(IRadioMenuFlyoutItemStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(IRadioMenuFlyoutItemFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallback(enable = true)]
	[Static(typeof(IRadioMenuFlyoutItemStatics2), 131072u, "Microsoft.UI.Xaml.XamlContract")]
	public class RadioMenuFlyoutItem : MenuFlyoutItem, IRadioMenuFlyoutItem
	{
		public extern bool IsChecked
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern string GroupName
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public static extern DependencyProperty GroupNameProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IsCheckedProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyChangedCallbackMethodName(value = "OnAreCheckStatesEnabledPropertyChanged")]
		[MUXPropertyDefaultValue(value = "false")]
		public static extern DependencyProperty AreCheckStatesEnabledProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallbackMethodName(value = "OnAreCheckStatesEnabledPropertyChanged")]
			[MUXPropertyDefaultValue(value = "false")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void SetAreCheckStatesEnabled([In] MenuFlyoutSubItem @object, [In] bool value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern bool GetAreCheckStatesEnabled([In] MenuFlyoutSubItem @object);
	}
}
