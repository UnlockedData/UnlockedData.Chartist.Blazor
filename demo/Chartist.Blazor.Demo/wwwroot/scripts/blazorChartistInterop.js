"use strict";

var _createClass = (function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; })();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var BlazorChartist = (function () {
    function BlazorChartist() {
        _classCallCheck(this, BlazorChartist);
    }

    _createClass(BlazorChartist, [{
        key: "createChart",
        value: function createChart(type, elem, data, options) {
            var chart;
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
            console.log(type + " created by chartist");
        }
    }, {
        key: "updateChart",
        value: function updateChart(elem, data, options) {
            elem['_chart'].update(data, options);
        }
    }]);

    return BlazorChartist;
})();

window.bizzyChartist = new BlazorChartist();

