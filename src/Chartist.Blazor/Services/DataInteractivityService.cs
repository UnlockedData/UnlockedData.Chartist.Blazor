using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

//Class to keep track of data interactivity events and the state of the components

namespace Chartist.Blazor.Services
{
    public static class DataInteractivityService
    {

        [JSInvokable]
        public static Task<string> ReturnString(string e)
        {
            var result = "You have reached the offices of Dotnet, we're not fucking here!";
            var resuly = "hey, you clicked me and my info says I'm a "  + e;
            return Task.FromResult(resuly);

        }
    }
}
