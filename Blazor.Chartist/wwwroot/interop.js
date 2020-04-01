class BlazorChartist {
    createChart(type, elem, data, options) {
        switch (type) {
            case "Bar":
                Chartist.Bar(elem, data, options)
                break;
            case "Pie":
                Chartist.Pie(elem, data, options)
                break;
            case "Line":
                Chartist.Line(elem, data, options)
                break;
        }
        console.log(type + " created by chartist");
    }

    updateChart(elem, data, options) {
        elem['_chart'].update(data, options);
    }
}

window.bizzyChartist = new BlazorChartist();
