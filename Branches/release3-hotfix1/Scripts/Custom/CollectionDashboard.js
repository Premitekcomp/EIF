function ContactCount() {
    var dataPoints = [];
    $.getJSON(url + "collection/ContactCount", { AgencyID: $("#AgencyID").val(), BranchID: $("#BranchID").val() }, function (data) {
        for (var i = 0; i <= data.length - 1; i++) {
            dataPoints.push({ ConnectionType: data[i].ConnectionTypeTitle, Count: parseInt(data[i].ContactCount) });
            //alert(data[i].ConnectionTypeTitle + " : " + parseInt(data[i].ContactCount));
        }
        $("#Contacts-pie-chart").dxPieChart({
            dataSource: dataPoints,
            legend: {
                visible: false
            },
            palette: ["#6bb802", "#7c37c3", "#0861ce", "#fbd005", "#4fcdfc", "#00b19d", "#ff6264"],
            series: [{
              //  type: "doughnut",
                valueField: "Count",
                argumentField: "ConnectionType",
                label: {
                    visible: true,
                    customizeText: function (arg) {
                        return arg.valueText + " - " + arg.argumentText;
                    },
                    //position: "inside",
                    //format: "millions",
                    connector: {
                        visible: true
                    }
                }
            }]
        });
    });

}

function FinanceSum() {
    var FinancedataPoints = [];
    $.getJSON(url + "collection/FinanceSum", { AgencyID: $("#AgencyID2").val(), BranchID: $("#BranchID2").val() }, function (data) {
        for (var i = 0; i <= data.length - 1; i++) {
            FinancedataPoints.push({ FinanceType: data[i].SumType, Sum: parseInt(data[i].SumVal) });
           // alert(data[i].SumType + " : " + parseInt(data[i].SumVal));
        }
        $("#Finance-pie-chart").dxPieChart({
            dataSource: FinancedataPoints,
            legend: {
                visible: false
            },
            palette: ["#ff6264", "#7c37c3", "#0861ce", "#fbd005", "#4fcdfc", "#00b19d", "#6bb802"],
            series: [{
                type: "doughnut",
                valueField: "Sum",
                argumentField: "FinanceType",
                label: {
                    visible: true,
                    customizeText: function (arg) {
                        return arg.valueText + " - " + arg.argumentText;
                    },
                    //position: "inside",
                    //format: "millions",
                    connector: {
                        visible: true
                    }
                }
            }]
        });
    });

}