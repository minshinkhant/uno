#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WindowManagement
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppWindowPresentationConfiguration 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.WindowManagement.AppWindowPresentationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppWindowPresentationKind AppWindowPresentationConfiguration.Kind is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.WindowManagement.AppWindowPresentationConfiguration.Kind.get
	}
}
