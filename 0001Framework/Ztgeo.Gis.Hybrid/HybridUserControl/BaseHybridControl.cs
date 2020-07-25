﻿using Abp.Dependency;
using Castle.MicroKernel.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ztgeo.Gis.Hybrid.JsBinder;
using Ztgeo.WebViewControl;

namespace Ztgeo.Gis.Hybrid.HybridUserControl
{

    public abstract class BaseHybridControl<TApp2JSAdapterApi,TJS2AppAdapterApi>: ITransientDependency, IDisposable
        where TApp2JSAdapterApi : IApp2JSAdapterApi, new() 
        where TJS2AppAdapterApi : IJS2AppAdapterApi, new()
    {
        protected WebView webView;

        protected IBindableJSContextProvider bindableJSContextProvider;

        protected TApp2JSAdapterApi app2JSAdapterApi;

        protected TJS2AppAdapterApi js2AppAdapterApi;

        protected CommonAPI jsCommonApi;
        public BaseHybridControl(IocManager iocManager) {
            webView = new WebView();
            webView.SetupWebView<TApp2JSAdapterApi>(out bindableJSContextProvider, 
                (newJsCtx) => {
                    TApp2JSAdapterApi adapterApi =  iocManager.Resolve<TApp2JSAdapterApi>();
                    adapterApi.JsCtx = bindableJSContextProvider;
                    return adapterApi;
                },
                out app2JSAdapterApi,
                out jsCommonApi
            );
            js2AppAdapterApi = iocManager.Resolve<TJS2AppAdapterApi>();
            js2AppAdapterApi.JsCtx = bindableJSContextProvider;
        }

        public void Dispose()
        {
            this.webView.Dispose();
        }
    }
}