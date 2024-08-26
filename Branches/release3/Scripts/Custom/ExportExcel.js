function fnExcelReport(reportname) {
    if (reportname == '')
    {
        reportname = $.trim($('#ReportTitle').text());
    }
    var tab_text = "";
    $('#result table').each(function () {

        tab_text = tab_text + "<table border='2px'><tr bgcolor='#87AFC6'>";
        var textRange; var j = 0;
        tab = document.getElementById(this.id); // id of table

        if (tab != null) {
            for (j = 0 ; j < tab.rows.length ; j++) {
                tab_text = tab_text + tab.rows[j].innerHTML + "</tr>";
                //tab_text=tab_text+"</tr>";
            }
        }
        tab_text = tab_text + "<tr></tr></table>";
    });
    tab_text = tab_text.replace(/<A[^>]*>|<\/A>/g, "");//remove if u want links in your table
    tab_text = tab_text.replace(/<img[^>]*>/gi, ""); // remove if u want images in your table
    tab_text = tab_text.replace(/<input[^>]*>|<\/input>/gi, ""); // reomves input params
    var myBlob = new Blob([tab_text], { type: 'application/vnd.ms-excel' });
    var url = window.URL.createObjectURL(myBlob);
    var a = document.createElement("a");
    document.body.appendChild(a);
    a.href = url;
    var d = new Date($.now());
    var DateTimeNow=d.getDate() + "-" + (d.getMonth() + 1) + "-" + d.getFullYear() + " " + d.getHours() + ":" + d.getMinutes() + ":" + d.getSeconds();
    a.download = reportname + "-" + DateTimeNow + ".xls";
    a.click();
}