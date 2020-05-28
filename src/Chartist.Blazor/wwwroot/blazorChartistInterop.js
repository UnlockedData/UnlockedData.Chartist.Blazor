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
                            e = bizzyChartist.createChartistMouseEvents(e);
                            console.log(e)
                            DotNet.invokeMethodAsync('Chartist.Blazor', 'DomDataPointClicked', e)

                        })
                        item.addEventListener('mouseenter', function (e) {
                            console.log(e)
                            e = bizzyChartist.createChartistMouseEvents(e);
                            console.log(e)
                            DotNet.invokeMethodAsync('Chartist.Blazor', 'DomDataPointEntered', e)

                        })
                        item.addEventListener('mouseleave', function (e) {
                            console.log(e)
                            e = bizzyChartist.createChartistMouseEvents(e);
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


        });
        console.log(type + " created by chartistjs");
    };

    // updateChart(elem, data, options) {
    //     elem['_chart'].update(data, options);
    // };

    createChartistMouseEvents(e) {
        let result = {            
            pointMetaInfo: JSON.parse(bizzyChartist.decodeHTMLEntities(e.target.getAttribute('ct-meta'))).data,
            value: Number(e.target.getAttribute('ct-value')),
            seriesName : e.target.parentElement.getAttribute('ct-series-name')
        };

    

        return result;
    };

    
      
    decodeHTMLEntities (str) {
          if(str && typeof str === 'string') {
              var parser = new DOMParser;
              var dom = parser.parseFromString(str,'text/html');
              var decodedString = dom.body.textContent;
          }
      
        return decodedString;
    }
      
        
     
};

window.NotifyDomDataPointClicked = function (e) {
    DotNet.invokeMethodAsync('Chartist.Blazor', 'DomDataPointClicked', e)
}


window.bizzyChartist = new BlazorChartist();
