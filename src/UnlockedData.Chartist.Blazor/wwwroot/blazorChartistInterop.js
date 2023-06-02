class BlazorChartist {

    createChart(type, elem, data, options, instance, id) {

        //configure plugins if they are set
        options = this.optionsCleaner(type, options);
        options = this.configurePlugins(options);
        


        let chart;

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
                        });
                    });

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

            options.cssClassUpdates.forEach(c => {
                elem.querySelectorAll(c.cssSelector).forEach(x => x.classList.add(c.class));
            })
        });

        chart.on('update', function (data, options) {
           
        });

        elem['_chart'] = chart;
    };

    updateChart(type, elem, data, options) {
        
        options = this.configurePlugins(options);
        options = this.optionsCleaner(type, options);
        elem['_chart'].update(data, options);


    };

    createChartistMouseEvents(e) {
        let values = e.target.getAttribute('ct-value').split(',');
        let result = {
            pointMetaInfo: JSON.parse(bChartist.decodeHTMLEntities(e.target.getAttribute('ct-meta'))).data,
            x: function () {
                if (values.length === 2) {
                    return Number(values[0]);
                }
            }(),
            y: function () {
                if (values.length === 2) {
                    return Number(values[1]);
                }
                return Number(values[0]);
            }(),
            seriesName: e.target.parentElement.getAttribute('ct-series-name')
        };

        return result;
    };

    decodeHTMLEntities(str) {
        if (str && typeof str === 'string') {
            let parser = new DOMParser;
            let dom = parser.parseFromString(str, 'text/html');
            let decodedString = dom.body.textContent;
            return decodedString;
        }

        return str;


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

    optionsCleaner(type, options) {

        //configure axis options
        if (type == "Line" || type == "Bar") {

            options.axisX.labelInterpolationFnc = this.labelInterpolationFunctions[options.axisX.labelInterpolationFnc];
            options.axisY.labelInterpolationFnc = this.labelInterpolationFunctions[options.axisY.labelInterpolationFnc];

            options.axisX.type = Chartist[options.axisX.type];
            options.axisY.type = Chartist[options.axisY.type];
        }

        if (type == "Line") {
            options.lineSmooth = this.interpolationHelper(options.interpolationType)(options.interpolationOptions);

        }
        if (options.toolTipOptions.transformTooltipTextFunction != undefined) {
            options.toolTipOptions.transformTooltipTextFnc = this.labelInterpolationFunctions[options.toolTipOptions.transformTooltipTextFunction]
        }
        
            
        return options

    }

    configurePlugins(options) {
        options.plugins = [];

        if (options.showLegend) {
            options.plugins.push(Chartist.plugins.legend(options.legendOptions));
        }

        
        if (options.showTooltips) {
            // var transFunc = function (value) {console.log(value); return 'hi'};
            // var textFunc = function (meta, value) {console.log(value); return value.toString()};
            // options.toolTipOptions.tooltipFnc  = textFunc;
            // options.toolTipOptions.transformTooltipTextFnc  = transFunc;
            options.plugins.push(Chartist.plugins.tooltip(options.toolTipOptions));
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

    labelInterpolationFunctions = {
        truncateToKMB: function (value) {
            return Math.abs(Number(value)) >= 1.0e+9 ? Math.abs(Number(value)) / 1.0e+9 + "B" : 
                Math.abs(Number(value)) >= 1.0e+6 ? Math.abs(Number(value)) / 1.0e+6 + "M" : 
                    Math.abs(Number(value)) >= 1.0e+3 ? Math.abs(Number(value)) / 1.0e+3 + "K" : Math.abs(Number(value));
        },
        truncateToKMBCommaSeparated: function (value) {
            return Math.abs(Number(value)) >= 1.0e+9 ? Math.round(Number(value),0) / 1.0e+9 + "B" :
                Math.abs(Number(value)) >= 1.0e+6 ? Math.round(Number(value),0) / 1.0e+6 + "M" :
                    Math.abs(Number(value)) >= 1.0e+3 ? Math.round(Number(value),0)/ 1.0e+3 + "K" : Number(value);
        },
        commaSeparated: function (value) {
            return  Math.round(Number(value),0).toLocaleString()
        },
        noop: Chartist.noop
    }


    appendElemToSvg(parentElem, elem) {
        parentElem.append(elem);
    }
}

window.bChartist = new BlazorChartist(); 

