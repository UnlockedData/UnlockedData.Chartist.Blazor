class BlazorChartist {
    createChart(type, elem, data, options) {
        var chart
        switch (type) {
            case "Bar":
                chart = Chartist.Bar(elem, data, options)
                break;
            case "Pie":
                chart = Chartist.Pie(elem, data, options)
                break;
            case "Line":
                chart = Chartist.Line(elem, data, options)
                break;
        }
        chart.on('draw', function (data) {
            if (data.type === 'line' || data.type === 'area') {
                data.element.animate({
                    d: {
                        begin: 2000 * data.index,
                        dur: 2000,
                        from: data.path.clone().scale(1, 0).translate(0, data.chartRect.height()).stringify(),
                        to: data.path.clone().stringify(),
                        easing: Chartist.Svg.Easing.easeOutQuint
                    }
                });
            }
        });
        console.log(type + " created by chartistjs");
    }

    updateChart(elem, data, options) {
        elem['_chart'].update(data, options);
    }
}

window.bizzyChartist = new BlazorChartist();
