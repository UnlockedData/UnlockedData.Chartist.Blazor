using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Chartist.Blazor.Services
{
    /// <summary>
    /// for elements that blazor hasn't got a hold on (like those subsequently created through Js scripts via interop
    /// can be instantiated as a singleton if I work out how to do the interop passing
    /// </summary>
    public static class DomEventRoutingService
    {
        public static event EventHandler<ChartistMouseEventArgs> DataPointClicked;
        public static event EventHandler<ChartistMouseEventArgs> DataPointEntered;
        public static event EventHandler<ChartistMouseEventArgs> DataPointExited;

        [JSInvokable]
        public static void DomDataPointClicked(ChartistMouseEventArgs args)
        {
#if DEBUG
            Console.WriteLine("Clicked");
            
#endif
            DataPointClicked?.Invoke(null, args);
           
        }

        [JSInvokable]
        public static void DomDataPointEntered(ChartistMouseEventArgs args)
        {
#if DEBUG
            Console.WriteLine("entered");
           
#endif
            DataPointEntered?.Invoke(null, args);
            
        }

        [JSInvokable]
        public static void DomDataPointExited(ChartistMouseEventArgs args)
        {
#if DEBUG
            Console.WriteLine("exited");
            
#endif
            DataPointExited?.Invoke(null, args);
            
        }



    }


}
