using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 131072u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(122615017u, 9907, 22679, 172, 111, 16, 207, 9, 71, 170, 218)]
	[ExclusiveTo(typeof(RadioMenuFlyoutItem))]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IRadioMenuFlyoutItemStatics2
	{
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallbackMethodName(value = "OnAreCheckStatesEnabledPropertyChanged")]
		DependencyProperty AreCheckStatesEnabledProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallbackMethodName(value = "OnAreCheckStatesEnabledPropertyChanged")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetAreCheckStatesEnabled([In] MenuFlyoutSubItem @object, [In] bool value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetAreCheckStatesEnabled([In] MenuFlyoutSubItem @object);
	}
}
