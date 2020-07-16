﻿using System; 

namespace Ztgeo.WebViewControl
{
	public interface IReactView : IDisposable
	{ 
		IViewModule[] Plugins { get; set; }
		 
		ResourceUrl DefaultStyleSheet { get; set; }
		 
		bool EnableDebugMode { get; set; }
		 
		bool IsReady { get; }
		 
		event Action Ready;
		 
		event Action<CefException.UnhandledExceptionEventArgs> UnhandledAsyncException;
		 
		T WithPlugin<T>();
	}
}
