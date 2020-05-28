class BlazorChartist {


    async createChart(type, elem, data, options) {
        var chart;
        switch (type) {
            case "Bar":
                chart = await Chartist.Bar(elem, data, options);
                break;
            case "Pie":
                chart = await Chartist.Pie(elem, data, options);
                break;
            case "Line":
                chart = await Chartist.Line(elem, data, options);
                break;
        }



        chart.on('draw', function (data) {

            //console.log(data);



        });

        chart.on('created', function (data) {
            //bind all the dotnet events triggers to datapoints
            switch (type) {
                case "Bar":
                    document.querySelectorAll('.' + options.classNames.bar).forEach(function (item) {
                        item.addEventListener('click', function (e) {
                            console.log(e)
                            DotNet.invokeMethodAsync('Chartist.Blazor', 'DomDataPointClicked', e)

                        })
                        item.addEventListener('mouseenter', function (e) {
                            console.log(e)
                            DotNet.invokeMethodAsync('Chartist.Blazor', 'DomDataPointEntered', e)

                        })
                        item.addEventListener('mouseleave', function (e) {
                            console.log(e)
                            DotNet.invokeMethodAsync('Chartist.Blazor', 'DomDataPointExited', e)

                        })
                    });
                    break;
                case "Pie":
                    
                    break;
                case "Line":
                    
                    break;
            }
            document.querySelectorAll(options).forEach(function (item) {
                item.addEventListener('click', function (e) {
                    //console.log(e);
                    exampleStatic(e.target.getAttribute("ct-meta"));
                    //exampleInstance(e.target.getAttribute("ct-meta"));
                });
            });

        });
        console.log(type + " created by chartistjs");
    };

    updateChart(elem, data, options) {
        elem['_chart'].update(data, options);
    };
};

window.NotifyDomDataPointClicked = function (e) {
    DotNet.invokeMethodAsync('Chartist.Blazor', 'DomDataPointClicked', e)
}


window.bizzyChartist = new BlazorChartist();
