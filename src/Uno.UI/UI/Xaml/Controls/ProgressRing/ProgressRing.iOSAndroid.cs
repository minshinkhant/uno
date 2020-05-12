﻿#if __IOS__ || __ANDROID__
using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Media;
#if __IOS__
using UIKit;
#else
using Uno.UI;
#endif

namespace Windows.UI.Xaml.Controls
{
	partial class ProgressRing
	{
		private NativeProgressRing _native;

		protected override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			_native = this.FindFirstChild<NativeProgressRing>();

			if (this.IsDependencyPropertySet(ForegroundProperty))
			{
				ApplyForeground();
			}
		}

		protected override void OnForegroundColorChanged(Brush oldValue, Brush newValue)
		{
			base.OnForegroundColorChanged(oldValue, newValue);

			ApplyForeground();
		}
	}
}

#endif
