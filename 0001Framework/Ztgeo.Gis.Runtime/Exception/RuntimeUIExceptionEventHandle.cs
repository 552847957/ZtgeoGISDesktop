﻿using Abp.Dependency;
using Abp.Events.Bus;
using Abp.Events.Bus.Handlers;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ztgeo.Gis.Runtime 
{
    /// <summary>
    /// 处理UI线程异常
    /// </summary>
    public class RuntimeUIExceptionEventHandle : IEventHandler<UIExceptionEventData>, ITransientDependency
    {  
        public ILogger Logger { get; set; }

        private readonly IExceptionDeal exceptionDeal;

        public RuntimeUIExceptionEventHandle(IExceptionDeal _exceptionDeal) { 
            Logger = NullLogger.Instance;
            exceptionDeal = _exceptionDeal;
        } 

        public void HandleEvent(UIExceptionEventData eventData) {
            if (eventData != null && eventData.ThreadExceptionEventArgs != null && eventData.ThreadExceptionEventArgs.Exception!=null) {
                var exception = eventData.ThreadExceptionEventArgs.Exception;
                string errorCode = (Convert.ToDouble(DateTime.UtcNow.Ticks - 621355968000000000) / (10 * 1000 * 1000)).ToString();
                if (exception is ExceptionDealBase)
                { 
                    Logger.Error("ErrorCode:" + errorCode + "。" + exception.Message, exception);
                    ((ExceptionDealBase)exception).DealException(eventData.ExceptionType, errorCode);
                }
                else {
                    Logger.Error("ErrorCode:" + errorCode + "。" + exception.Message, exception);
                    exceptionDeal.DealException(eventData.ExceptionType, exception.Message);
                }
            }
        }
    }
}
