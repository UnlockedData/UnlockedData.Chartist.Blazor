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

            console.log(data);
            document.querySelectorAll('.ct-bar').forEach(function (item) {
                item.addEventListener('click', function (e) {
                    console.log(e);
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

window.exampleStatic = function (e) {
    DotNet.invokeMethodAsync('Chartist.Blazor','ReturnString',e)
            .then(data => console.log(data));
}

window.exampleInstance = function (e, dotnetInstance) {
    dotnetInstance.invokeMethodAsync('ReturnString', e)
        .then(data => console.log(data));

}

window.bizzyChartist = new BlazorChartist();
