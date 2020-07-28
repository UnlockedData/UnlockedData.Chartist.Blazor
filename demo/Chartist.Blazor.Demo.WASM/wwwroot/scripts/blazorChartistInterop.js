function bindEvents(className) {
    var elems = document.querySelectorAll('.' + className);
    elems.forEach(function (elem, i) {
        elem.addEventListener('click', (e) => { console.log(e); })
    });
};

class BlazorChartist {


    async createChart(type, elem, data, options) {
        var chart;
        switch (type) {
            case "Bar":
                chart = await Chartist.Bar(elem, data, options);
                bindEvents('ct-bar');
                break;
            case "Pie":
                chart = await Chartist.Pie(elem, data, options);
                break;
            case "Line":
                chart = await Chartist.Line(elem, data, options);
                break;
        }



        chart.on('draw', function (data) {

            console.log(data);


        });

        chart.on('created', function (data) {

            console.log(data);

        });
        console.log(type + " created by chartistjs");
    };

    updateChart(elem, data, options) {
        elem['_chart'].update(data, options);
    };
};



window.bizzyChartist = new BlazorChartist();
