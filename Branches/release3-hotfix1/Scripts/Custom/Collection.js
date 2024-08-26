function readURL(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
           
            final = e.target.result;
           
            index = final.indexOf("data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64,");
            if (index > -1) {
                final = final.replace("data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64,", "");
                //save to control
                $("#excelFile").val(final);
                //check sheets
                $.ajax({
                    url: url + "collection/GetSheets",
                    type: 'post',
                    cache: false,
                    async: true,
                    data: {file: $("#excelFile").val()},
                    success: function (result) {
                        $('#sheets').html(result);
                    }
                    
                });

            }
            else {
                alert("Choose Excel File");
            }

        }

        reader.readAsDataURL(input.files[0]);

    }
}

$("#file").change(function () {
    readURL(this);
});
$("#DCRfile").change(function () {
    debugger;
    ShowProgress();
    DCRURLread(this);
});
function DCRURLread(input) {
    debugger;
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {

            final = e.target.result;

            index = final.indexOf("data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64,");
            if (index > -1) {
                final = final.replace("data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64,", "");
                //save to control
                $("#excelFile").val(final);
                //check sheets
                $.ajax({
                    url: url + "collection/GetDCRSheets",
                    type: 'post',
                    cache: false,
                    async: true,
                    data: { file: $("#excelFile").val() },
                    success: function (result) {
                        $('#sheets').html(result);
                        HideProgress();
                    }

                });

            }
            else {
                alert("Choose Excel File");
            }

        }

        reader.readAsDataURL(input.files[0]);

    }
}
function PayreadURL(input) {
   
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {

            final = e.target.result;

            index = final.indexOf("data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64,");
            if (index > -1) {
                final = final.replace("data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64,", "");
                //save to control
                $("#excelFile").val(final);
                //check sheets
                $.ajax({
                    url: url + "collection/GetPaymentSheets",
                    type: 'post',
                    cache: false,
                    async: true,
                    data: { file: $("#excelFile").val() },
                    success: function (result) {
                        $('#sheets').html(result);
                    }

                });

            }
            else {
                alert("Choose Excel File");
            }

        }

        reader.readAsDataURL(input.files[0]);

    }
}

$("#Pay-file").change(function () {
    PayreadURL(this);
});

function UpdateDomainID() {
    $("#DomainID2").val($("#DomainID1").val());
   
}

function Step2() {
    ShowProgress();
    $.ajax({
        url: url + "collection/GetImportDomain",
        type: 'post',
        cache: false,
        async: true,
        data: {},
        success: function (result) {
            if ($("#DomainID1").val()>0) {
                $('#import').html(result);
                UpdateDomainID();
                $('#example-basic').steps('next');
                HideProgress();
            }
            
        }
    });
}

function SelectFile() {
    if ($("#SchemaID").val()=="") {
        $("#selectF").addClass("hide");
    }
    else {
        $("#selectF").removeClass("hide");
    }
    
}

function CheckToImport() {
    ShowProgress();
    $.ajax({
        url: url + "collection/CheckToImport",
        type: 'post',
        cache: false,
        async: true,
        data: { SchemaID: $("#SchemaID").val(), file: $("#filePath").val(), SheetName: $("#SheetName").val() },
        success: function (result) {
            $('#Statistic').html(result);
            HideProgress();
        }
    });
}
function OpenDomain(id) {
    ShowProgress();
    $.ajax({
        url: url + "collection/OpenDomain",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });
}
function CloseDomain(id) {
    ShowProgress();
    $.ajax({
        url: url + "collection/CloseDomain",
        type: 'post',
        cache: false,
        async: true,
        data: { id:id },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });
}

function GetAccountDCR(id) {
    ShowProgress();
    $.ajax({
        url: url + "collection/GetAccountDCR",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id },
        success: function (result) {
            $('#DCRHistory').html(result);
            $('#DomainID2').val($('#DomainID').val());
            HideProgress();
        }
    });
}

function GetArabicComment() {
    ShowProgress();
    var selectedText = $("#CommentID").find("option:selected").text();
    var EngComment = $("#EngComment").val();
    if (selectedText != "Choose") {
        EngComment = EngComment + " " + selectedText;
        $("#EngComment").val(EngComment);

        $.ajax({
            url: url + "collection/GetArabicComment",
            type: 'post',
            cache: false,
            async: true,
            data: { id: $("#CommentID").val() },
            success: function (result) {
                var ArabComment = $("#ArabComment").val();
                ArabComment = ArabComment + " " + result;
                $("#ArabComment").val(ArabComment);
                HideProgress();
            }
        });
    }
   

 

}

function DeleteDCR() {
    ShowProgress();
    id = $("#del").val();
    DomainID = $("#DomainID").val();

    $.ajax({
        url: url + "collection/DeleteDCR",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, DomainID: DomainID },
        success: function (result) {
            $('#result').html(result);
            HideProgress();
        }
    });

}
function DeleteDomain() {
    ShowProgress();
    id = $("#del").val();

    $.ajax({
        url: url + "collection/DeleteDomain",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function ConfirmRemove(id) {
    $("#del").val(id);
    $("#del-box").removeClass("hide");

    window.scrollTo(500, 0);
}
function Cancel() {
    $("#del").val('');
    $("#del-box").addClass("hide");
}

function AddPartial() {
    ShowProgress();
    Count = $("#Count").val();
    NewCount = parseInt(Count) + 1;
    $.ajax({
        url: url + "collection/addPartial",
        dataType: "html",
        data: { id: $("#DomainID").val(), VersionNumber: $("#VersionNumber").val(), Count: Count },
        success: function (result) {
            $('#dynamicPartial').append(result);
            $("#Count").val(NewCount);
            HideProgress();

        }
    });
}
function GetMembers(type) {
    //alert(type);
    Count = $("#Count").val();

    var ColArr = new Array();
    var ColValArr = new Array();

    for (var i = 1; i < parseInt(Count) ; i++) {
        var id = $("#ColID-" + i).val();
        var val = $("#FilterVal-" + i).val();
        if (id != null) {
            ColArr.push(id);
            ColValArr.push(val);
        }
    }
    //alert(JSON.stringify(arr));
    var ColList = JSON.stringify(ColArr);
    var ColValList = JSON.stringify(ColValArr);

    ShowProgress();
    $.ajax({
        url: url + "collection/GetMembers",
        type: 'post',
        cache: false,
        async: true,

        data: {
            id: $("#DomainID").val(), VersionNumber: $("#VersionNumber").val()
            , ColList: ColList, ColValList: ColValList, type: type
        },
        //dataType: 'json',
        traditional: true,
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });
}

function BankAssignMembers() {

    var selectedIDs = new Array();
    var UnselectedIDs = new Array();
    $('input[type="checkbox"]:checked').each(function () {
        if ($(this).prop('checked')) {
            selectedIDs.push($(this).val());
        }
    });

    $('input[type="checkbox"]:not(:checked)').each(function () {
        if (!$(this).prop('checked')) {
            UnselectedIDs.push($(this).val());
        }
    });

    $('#InsertIDs').val(selectedIDs);
    $('#DeleteIDs').val(UnselectedIDs);

    ShowProgress();

    $.ajax({
        url: url + "collection/BankAssignMembers",
        type: 'post',
        cache: false,
        async: true,
        data: { MemberId: $('#MembersID').val(), ins: $('#InsertIDs').val(), Domain: $('#DomainID').val() },
        success: function (result) {
            $('#msg').html(result);
            $('#InsertIDs').val('');
            HideProgress();
        }
    });

}
function InternalAssignMembers() {

    var selectedIDs = new Array();
    var UnselectedIDs = new Array();
    $('input[type="checkbox"]:checked').each(function () {
        if ($(this).prop('checked')) {
            selectedIDs.push($(this).val());
        }
    });

    $('input[type="checkbox"]:not(:checked)').each(function () {
        if (!$(this).prop('checked')) {
            UnselectedIDs.push($(this).val());
        }
    });

    $('#InsertIDs').val(selectedIDs);
    $('#DeleteIDs').val(UnselectedIDs);

    ShowProgress();

    $.ajax({
        url: url + "collection/InternalAssignMembers",
        type: 'post',
        cache: false,
        async: true,
        data: { MemberId: $('#MembersID').val(),ins: $('#InsertIDs').val(), Domain: $('#DomainID').val() },
        success: function (result) {
            $('#msg').html(result);
            $('#InsertIDs').val('');
            HideProgress();
        }
    });

}
function UnassignInternalAssignMembers() {

    var selectedIDs = new Array();
    var UnselectedIDs = new Array();
    $('input[type="checkbox"]:checked').each(function () {
        if ($(this).prop('checked')) {
            selectedIDs.push($(this).val());
        }
    });

    $('input[type="checkbox"]:not(:checked)').each(function () {
        if (!$(this).prop('checked')) {
            UnselectedIDs.push($(this).val());
        }
    });

    $('#InsertIDs').val(selectedIDs);
    $('#DeleteIDs').val(UnselectedIDs);

    ShowProgress();

    $.ajax({
        url: url + "collection/UnassignInternalAssignMembers",
        type: 'post',
        cache: false,
        async: true,
        data: { MemberId: $('#MembersID').val(), del: $('#DeleteIDs').val(), Domain: $('#DomainID').val() },
        success: function (result) {
            $('#msg').html(result);
            $('#DeleteIDs').val('');
            HideProgress();
        }
    });

}
function UnassignBankAssignMembers() {

    var selectedIDs = new Array();
    var UnselectedIDs = new Array();
    $('input[type="checkbox"]:checked').each(function () {
        if ($(this).prop('checked')) {
            selectedIDs.push($(this).val());
        }
    });

    $('input[type="checkbox"]:not(:checked)').each(function () {
        if (!$(this).prop('checked')) {
            UnselectedIDs.push($(this).val());
        }
    });

    $('#InsertIDs').val(selectedIDs);
    $('#DeleteIDs').val(UnselectedIDs);

    ShowProgress();

    $.ajax({
        url: url + "collection/UnassignBankAssignMembers",
        type: 'post',
        cache: false,
        async: true,
        data: { MemberId: $('#MembersID').val(), del: $('#DeleteIDs').val(), Domain: $('#DomainID').val() },
        success: function (result) {
            $('#msg').html(result);
            $('#DeleteIDs').val('');
            HideProgress();
        }
    });

}

function GetSheetsColumn() {
    ShowProgress();
    $.ajax({
        url: url + "collection/GetSheetsColumn",
        type: 'post',
        cache: false,
        async: true,
        data: { file: $("#filePath").val(), SheetName: $("#SheetName").val(), DomainID: $("#DomainID2").val() },
        success: function (result) {
            $('#SheetCol').html(result);
            HideProgress();
        }
    });
}





function Download() {
    var URL = url + "collection/ExportDCRWithAccounts?DomainID=" + $("#DomainID").val();

    window.location = URL;
}
function DownloadBankAssigned() {
    var URL = url + "collection/DownloadBankAssigned?DomainID=" + $("#DomainID").val();

    window.location = URL;
}
function DownloadInternalAssigned() {
    var URL = url + "collection/DownloadInternalAssigned?DomainID=" + $("#DomainID").val();

    window.location = URL;
}
function DownloadXls(id) {
    var URL = url + "collection/ExportDomain?DomainID=" + id;

    window.location = URL;
}



// =============================== schema ====================================
function EditColumn(id) {
    ShowProgress();
    $.ajax({
        url: url + "collection/EditColumn",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, Name: $("#Name-" + id).val(), Types: $("#Types-" + id).val(), Fixed: IsChecked($("#Fixed-" + id)) },
        success: function (result) {
            $('#msg').html(result);
            HideProgress();
        }
    });
}
function NewColumn() {
    ShowProgress();
    $.ajax({
        url: url + "collection/NewColumn",
        type: 'post',
        cache: false,
        async: true,
        data: { Name: $("#Name").val(), Types: $("#Types").val(), Fixed: IsChecked($("#Fixed")) },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });
}
function ColFixed(id, fix) {
    ShowProgress();
    $.ajax({
        url: url + "collection/ColFixed",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, fix: fix },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function NewSchema() {
    ShowProgress();
    $.ajax({
        url: url + "collection/NewSchema",
        type: 'post',
        cache: false,
        async: true,
        data: {
            Name: $("#Name").val(), BranchID: $("#BranchID").val()
        },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });
}
function EditSchema(id) {
    ShowProgress();
    $.ajax({
        url: url + "collection/EditSchema",
        type: 'post',
        cache: false,
        async: true,
        data: {
            id: id, Name: $("#Name-" + id).val(), BranchID: $("#BranchID-" + id).val(), index: $('#index-' + id).val()
        },
        success: function (result) {
            $('#msg').html(result);
            HideProgress();
        }
    });
}
function AddColumns() {
    ShowProgress();
    $.ajax({
        url: url + "collection/AddSchemaColumns",
        type: 'post',
        cache: false,
        async: true,
        data: { ColID: $('#ColID').val(), id: $('#SchemaID').val(), index: $('#index').val() },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function UpdateSchemaColumnIndex(id) {
    index = $("#index-" + id).val();
    SchemaID = $("#SchemaID").val();
    ShowProgress();
    $.ajax({
        url: url + "collection/UpdateSchemaColIndex",
        type: 'post',
        cache: false,
        async: true,
        data: { SchemaID: SchemaID, ColID: id, index: index },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function RemoveColumns() {
    id = $("#del").val();
    SchemaID = $("#SchemaID").val();
    ShowProgress();
    $.ajax({
        url: url + "collection/RemoveColumns",
        type: 'post',
        cache: false,
        async: true,
        data: { SchemaID: SchemaID, ColID: id },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function ConfirmRemove(id) {
    $("#del").val(id);
    $("#del-box").removeClass("hide");

    window.scrollTo(500, 0);
}
function Cancel() {
    $("#del").val('');
    $("#del-box").addClass("hide");
}
function GetCollectorReport(DomainID) {
    $.ajax({
        url: "/collection/GetDomainReportPerCollector",
        type: 'Get',
        cache: false,
        async: true,
        data: { DomainID: DomainID },
        success: function (result) {
            $('#CollectorReport').html(result);
        }
    });
}
function GetTeamLeaderReport(DomainID) {
    $.ajax({
        url: "/collection/GetDomainReportbyTeamLeader",
        type: 'Get',
        cache: false,
        async: true,
        data: { DomainID: DomainID },
        success: function (result) {
            $('#TeamLeaderReport').html(result);
        }
    });
}
function NewDCRSchema() {
    ShowProgress();
    $.ajax({
        url: url + "collection/NewDCRSchema",
        type: 'post',
        cache: false,
        async: true,
        data: {
            Name: $("#Name").val(), BranchID: $("#BranchID").val()
        },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });
}
function EditDCRSchema(id) {
    ShowProgress();
    $.ajax({
        url: url + "collection/EditDCRSchema",
        type: 'post',
        cache: false,
        async: true,
        data: {
            id: id, Name: $("#Name-" + id).val(), BranchID: $("#BranchID-" + id).val(), index: $('#index-' + id).val()
        },
        success: function (result) {
            $('#msg').html(result);
            HideProgress();
        }
    });
}
function RemoveDCRColumns() {
    id = $("#del").val();
    SchemaID = $("#SchemaID").val();
    ShowProgress();
    $.ajax({
        url: url + "collection/RemoveDCRColumns",
        type: 'post',
        cache: false,
        async: true,
        data: { SchemaID: SchemaID, ColID: id },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function UpdateDCRSchemaColumnIndex(id) {
    index = $("#index-" + id).val();
    SchemaID = $("#SchemaID").val();
    ShowProgress();
    $.ajax({
        url: url + "collection/UpdateDCRSchemaColIndex",
        type: 'post',
        cache: false,
        async: true,
        data: { SchemaID: SchemaID, ColID: id, index: index },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function AddDCRColumns() {
    ShowProgress();
    $.ajax({
        url: url + "collection/AddDCRSchemaColumns",
        type: 'post',
        cache: false,
        async: true,
        data: { ColID: $('#ColID').val(), id: $('#SchemaID').val(), index: $('#index').val() },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function ProductChange(e) {
    var proval = $(e).val();
    if (proval != null) {
        if (proval.includes('-1')) {
            $(e).val("-1");
            $(e).trigger("chosen:updated");
        }
    }
}
function DomainChange(e) {
    debugger;
    var dominval = $(e).val();
    if (dominval != null) {
        if (dominval.includes('-1')) {
            $(e).val("-1");
            $(e).trigger("chosen:updated");
        }
    }
}
function BankChange() {
    $.ajax({
        url: "/collection/BankChange",
        type: 'post',
        cache: false,
        async: true,
        data: { id: $("#AgencyID").val(), Domaintitle: $("#Name").val(), branchid: $("#BrunchID").val(), monthid: $("#Month").val() },
        success: function (result) {
            $('#container').html(result);
        },
        complete: function () {
            $('.chosen-select').chosen();
        }
    });
}


function getFilterdResult(url)
{
    debugger
    if (($("#filterType").val() != 'Month' && $("#YearsList").val() != null) || (($("#filterType").val() == 'Month') && $("#YearsLists").val() != 'null' && $("#MonthsLists").val() != null)) {


        var data = {}
        data.type = $("#filterType1").val();
        if ($("#YearsList").val() != null) { data.years = $("#YearsList").val(); }

        if ($("#filterType").val() == 'Month') {
            data.months = $("#MonthsLists").val();
            data.years = $("#YearsLists").val();
        }

        $.ajax({
            beforeSend: function () { ShowProgress() },
            type: "get",
            url: url,
            data: { years: data.years, months: data.months, type: data.type },
            traditional: true,
            success: function (response) {
                debugger
                HideProgress();
                $("#result").html(response);
                $("#export-btn").show();
            }
        })
    }
}






