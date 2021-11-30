class BlazorChartist {

    createChart(type, elem, data, options, instance) {
        options.plugins = [];
        if (options.showLegend) {
            options.plugins.push(Chartist.plugins.legend());
        }

        if (options.showTooltips) {
            options.plugins.push(Chartist.plugins.tooltip());
        }

        if (options.ShowPointLabels) {
            options.plugins.push(Chartist.plugins.ctPointLabels());
        }


        var chart;
        bizzyChartist.data = data;
        switch (type) {
            case "Bar":
                chart = Chartist.Bar(elem, data, options);
                break;
            case "Pie":
                chart = Chartist.Pie(elem, data, options);
                break;
            case "Line":
                chart = Chartist.Line(elem, data, options);
                break;
        }

        chart.on('draw', function (data) {
        });

        chart.on('created', function (data) {

            switch (type) {
                case "Bar":
                    //each bar fires off
                    document.querySelectorAll('.' + options.classNames.bar).forEach(function (item) {
                        item.addEventListener('click', function (e) {
                            e = bizzyChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointClicked", e);
                        });
                        item.addEventListener('mouseenter', function (e) {
                            e = bizzyChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointEntered", e);
                        });
                        item.addEventListener('mouseleave', function (e) {
                            e = bizzyChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointExited", e);
                        });
                    });
                    break;
                case "Pie":
                    break;
                case "Line":
                    //each point fires off
                    document.querySelectorAll('.' + options.classNames.point).forEach(function (item) {
                        item.addEventListener('click', function (e) {
                            e = bizzyChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointClicked", e);
                        });
                        item.addEventListener('mouseenter', function (e) {
                            e = bizzyChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointEntered", e);
                        });
                        item.addEventListener('mouseleave', function (e) {
                            e = bizzyChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointExited", e);
                        });
                    });
                    break;
            }
        });

        chart.on('update', function () {
        });

        elem['_chart'] = chart
    };

    updateChart(elem, data, options, instance) {
        bizzyChartist.data = data;
        elem['_chart'].update(data, options);


    };

    createChartistMouseEvents(e) {
        let result = {
            pointMetaInfo: JSON.parse(bizzyChartist.decodeHTMLEntities(e.target.getAttribute('ct-meta'))).data,
            value: Number(e.target.getAttribute('ct-value')),
            seriesName: e.target.parentElement.getAttribute('ct-series-name')
        };

        return result;
    };

    decodeHTMLEntities(str) {
        if (str && typeof str === 'string') {
            var parser = new DOMParser;
            var dom = parser.parseFromString(str, 'text/html');
            var decodedString = dom.body.textContent;
        }

        return decodedString;
    }

}

window.bizzyChartist = new BlazorChartist(); 
