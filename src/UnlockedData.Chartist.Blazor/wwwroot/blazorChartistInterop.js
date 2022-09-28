class BlazorChartist {

    createChart(type, elem, data, options, instance, id) {
        
        //configure plugins if they are set
        
        options = this.configurePlugins(options);        
        options = this.optionsCleaner(type, options);
        

        let chart;
        bChartist.data = data;
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
                    elem.querySelectorAll('.' + options.classNames.bar).forEach(function (item) {
                        item.addEventListener('click', function (e) {
                            e = bChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointClicked", e);
                        });
                        item.addEventListener('mouseenter', function (e) {
                            e = bChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointEntered", e);
                        });
                        item.addEventListener('mouseleave', function (e) {
                            e = bChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointExited", e);
                        });                    });
                    
                    break;
                case "Pie":
                    break;
                case "Line":
                    //each point fires off
                    elem.querySelectorAll('.' + options.classNames.point).forEach(function (item) {
                        item.addEventListener('click', function (e) {
                            e = bChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointClicked", e);
                        });
                        item.addEventListener('mouseenter', function (e) {
                            e = bChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointEntered", e);
                        });
                        item.addEventListener('mouseleave', function (e) {
                            e = bChartist.createChartistMouseEvents(e);
                            instance.invokeMethodAsync("JSDomDataPointExited", e);
                        });
                    });
                    break;
            }
            
            options.cssClassUpdates.forEach(c=>{
                elem.querySelectorAll(c.cssSelector).forEach(x=>x.classList.add(c.class));
            })
        });

        chart.on('update', function () {
        });

        elem['_chart'] = chart;
    };

    updateChart(elem, data, options) {
        bChartist.data = data;
        options = this.optionsCleaner(options);
        elem['_chart'].update(data, options);


    };

    createChartistMouseEvents(e) {
        let result = {
            pointMetaInfo: JSON.parse(bChartist.decodeHTMLEntities(e.target.getAttribute('ct-meta'))).data,
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
    
    interpolationHelper(method) {
        let result;        
        switch (method) {
            case "monotone":
                result = Chartist.Interpolation.monotoneCubic;
                break;
            case "step":
                result = Chartist.Interpolation.step;
                break;
            case "none":
                result = Chartist.Interpolation.none;
                break;
            case "simple":
                result = Chartist.Interpolation.simple;
                break;
            case "cardinal":
                result = Chartist.Interpolation.cardinal;
                break;
                
        }
        
        return result;
    }
    
    optionsCleaner (type,options) {
        


        //configure axis options
        if (type == "Line" || type == "Bar") {

            options.axisX.labelInterpolationFnc = Chartist[options.axisX.labelInterpolationFnc];
            options.axisY.labelInterpolationFnc = Chartist[options.axisY.labelInterpolationFnc];

            options.axisX.type = Chartist[options.axisX.type];
            options.axisY.type = Chartist[options.axisY.type];

        }

        if (type == "Line") {
            options.lineSmooth = this.interpolationHelper(options.interpolationType)(options.interpolationOptions);

        }
        
        return options

    }
    
    configurePlugins (options) {
        options.plugins = [];

        if (options.showLegend) {
            options.plugins.push(Chartist.plugins.legend());
        }

        if (options.showTooltips) {
            options.plugins.push(Chartist.plugins.tooltip());
        }

        if (options.showPointLabels) {
            options.plugins.push(Chartist.plugins.ctPointLabels());
        }

        if (options.useZoom) {
            options.plugins.push(Chartist.plugins.zoom({
                onZoom: function (chart, reset) {
                    storeReset(reset);
                }
            }));
        }
        return options
    }

   
    
    appendElemToSvg(parentElem,elem) {
        parentElem.append(elem);
    }
}

window.bChartist = new BlazorChartist(); 

