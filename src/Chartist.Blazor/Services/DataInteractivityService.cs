using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

//Class to keep track of data interactivity events and the state of the components

namespace Chartist.Blazor.Services
{
    public static class DataInteractivityServiceStatic
    {

        [JSInvokable]
        public static Task ReturnString(string e)
        {
           
            ClickEventHandler?.Invoke(null, e);
            return Task.CompletedTask;

        }

        public static EventHandler<string> ClickEventHandler;
    }

    public class DataInteractivityService
    {
        [JSInvokable]
        public string ReturnString(string e)
        {
            
            return "hey, you clicked me and my instance says I'm a " + e;
            

        }
    }
}
