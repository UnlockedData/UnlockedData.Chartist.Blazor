class BlazorChartist {

   

    createChart(type, elem, data, options, instance) {
        var chart;
        bizzyChartist.data = data;
        switch (type) {
            case "Bar":
                chart = Chartist.Bar(elem, { series: [] }, options);
                break;
            case "Pie":
                chart = Chartist.Pie(elem, { series: [] }, options);
                break;
            case "Line":
                chart = Chartist.Line(elem, { series: [] }, options);
                break;
        }

        chart.on('draw', function (data) { });

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

        chart.on('update', function (data) {
        });       

        elem['_chart'] = chart        
    };

    updateChart(elem, data, options, instance) {       
       elem['_chart'].update(data, options);
       console.log("Chart created");
       console.log(elem['_chart']);
                   
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



};

window.bizzyChartist = new BlazorChartist();
