using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

using Microsoft.JSInterop;

namespace Chartist.Blazor.Services
{
    /// <summary>
    /// for elements that blazor hasn't got a hold on (like those subsequently created through Js scripts via interop
    /// can be instantiated as a singleton if I work out how to do the interop passing
    /// </summary>
    public static class DomEventRoutingService
    {
        public static event EventHandler<dynamic> DataPointClicked;
        public static event EventHandler<dynamic> DataPointEntered;
        public static event EventHandler<dynamic> DataPointExited;

        [JSInvokable]
        public static void DomDataPointClicked(dynamic args)
        {
#if DEBUG
            Console.WriteLine("Clicked");
            
#endif
            DataPointClicked?.Invoke(null, args);
           
        }

        [JSInvokable]
        public static void DomDataPointEntered(dynamic args)
        {
#if DEBUG
            Console.WriteLine("entered");
           
#endif
            DataPointEntered?.Invoke(null, args);
            
        }

        [JSInvokable]
        public static void DomDataPointExited(dynamic args)
        {
#if DEBUG
            Console.WriteLine("exited");
            
#endif
            DataPointExited?.Invoke(null, args);
            
        }



    }


}
