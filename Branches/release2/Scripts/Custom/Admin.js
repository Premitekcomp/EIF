
function Activate(id, active) {
    ShowProgress();
    $.ajax({
        url: url + "admin/ActivateAccount",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, active: active },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
//================================= agency ==========================
function EditAgency(id)
{
    ShowProgress();
   // alert($("#BranchIDs").val());
    $.ajax({
        url: url + "admin/EditAgency",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, Name: $("#Name-" + id).val(), BranchIDs: $("#BranchIDs-" + id).val().toString(), Active: IsChecked($("#Active-" + id)) },
        success: function (result) {
            $('#msg').html(result);
            HideProgress();
        }
    });
}
function NewAgency() {
    ShowProgress();
    $.ajax({
        url: url + "admin/NewAgency",
        type: 'post',
        cache: false,
        async: true,
        data: { Name: $("#Name").val(), BranchIDs: $("#BranchIDs").val().toString(), Active: IsChecked($("#Active")) },
        success: function (result) {
            $('#msg').html(result);
            HideProgress();
            RefreshAgency();

        }
    });
}
function RefreshAgency() {
    ShowProgress();
    $.ajax({
        url: url + "admin/RefreshAgency",
        type: 'post',
        cache: false,
        async: true,
        data: { },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });
}
function ActivateAgency(id, active) {
    ShowProgress();
    $.ajax({
        url: url + "admin/ActivateAgency",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, active: active },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function GetAgency(CtrlID, choose) {
    id = $("#BranchID").val();
    ShowProgress();
    $.ajax({
        url: url + "admin/GetAgency",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, choose: choose, TeamID: CtrlID },
        success: function (result) {
            $('#' + CtrlID).html(result);
            HideProgress();
        }
    });
}
function GetAgencyForEdit(CtrlID, choose, T) {
    id = $("#BranchID-" + CtrlID).val();
    ShowProgress();
    $.ajax({
        url: url + "admin/GetAgency",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, choose: choose, TeamID: CtrlID },
        success: function (result) {
            $('#agency-' + CtrlID).html(result);
            HideProgress();
        }
    });
}
//================================= team managment ==========================
function EditTeam(id) {
    // alert($("#BranchID-" + id).val());
    ShowProgress();
    $.ajax({
        url: url + "admin/EditTeam",
        type: 'post',
        cache: false,
        async: true,
        data: {
            id: id, Name: $("#Name-" + id).val(), BranchID: $("#BranchID-" + id).val()
            , AgencyID: $("#AgencyID-" + id).val(), Active: IsChecked($("#Active-" + id))
        },
        success: function (result) {
            $('#msg').html(result);
            HideProgress();
        }
    });
}
function NewTeam() {
    ShowProgress();
    $.ajax({
        url: url + "admin/NewTeam",
        type: 'post',
        cache: false,
        async: true,
        data: {
            Name: $("#Name").val(), BranchID: $("#BranchID").val()
            , AgencyID: $("#AgencyID-").val(),Active: IsChecked($("#Active"))
        },
        success: function (result) {
            $('#msg').html(result);
            HideProgress();
            RefreshTeam();
        }
    });
}
function RefreshTeam() {
    ShowProgress();
    $.ajax({
        url: url + "admin/RefreshTeam",
        type: 'post',
        cache: false,
        async: true,
        data: {},
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });
}
function ActivateTeam(id, active) {
    ShowProgress();
    $.ajax({
        url: url + "admin/ActivateTeam",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, active: active },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function AddMembers() {
  debugger
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

    var arr = new Array();
    for (var i = 0; i < selectedIDs.length; i++) {
        var id = selectedIDs[i];
        var val = $("#RoleID-" + id).val();
       
        if (id != null && id!="on") {
            if (val!=null && val!="") {
                arr.push({ id: id, val: val });
            }
            
        }
    }
    //alert(JSON.stringify(arr));
    var list = JSON.stringify(arr);
    ShowProgress();
    $.ajax({
        url: url + "admin/AddTeamMembers",
        type: 'post',
        cache: false,
        async: true,
        data: { ToDeletePageIDs: $('#DeleteIDs').val(), id: $('#TeamID').val() ,list:list},
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}
function UpdateTeamMembersRole(MemberID) {
    RoleID = $("#RoleID-" + MemberID).val();
    TeamID = $("#TeamID").val();
    ShowProgress();
    $.ajax({
        url: url + "admin/UpdateTeamMembersRole",
        type: 'post',
        cache: false,
        async: true,
        data: { TeamID:TeamID, MemberID:MemberID , RoleID:RoleID },
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });

}

function EditMember(id) {
    debugger;
    ShowProgress();
    $.ajax({
        url: url + "admin/EditMember",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id, Name: $("#Name-" + id).val(), Code: $("#Code-" + id).val() },
        success: function (result) {
            $('#msg').html(result);
            HideProgress();
        }
    });
}
function DeleteMember(id) {
    ShowProgress();
    $.ajax({
        url: url + "admin/DeleteMember",
        type: 'post',
        cache: false,
        async: true,
        data: { id: id},
        success: function (result) {
            debugger;
            $('#msg').html(result);
            $("#row_" + id).remove();
            HideProgress();
        }
    });
}
function NewMember() {
    ShowProgress();
    $.ajax({
        url: url + "admin/NewMember",
        type: 'post',
        cache: false,
        async: true,
        data: { Name: $("#Name").val() , Code : $("#Code").val()},
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        }
    });
}
//common
function IsChecked(id) {
    if ($(id).is(":checked"))
    { return true; }
    else { return false; }
}

// Add new permission function
function newpermission(e) {
    ShowProgress();
    var domaintype = $("#domaintype_0").val();
    var domaindata = $("#domaindata_0").val();
    var portalaccess = $("#portalaccess_0").val() != null ? $("#portalaccess_0").val().join(',') : "" ;
    $.ajax({
        url: url + "admin/newpermission",
        type: "post",
        cache: false,
        data: { domaintype: domaintype, domaindata: domaindata, portalaccess: portalaccess },
        async: true,
        success: function (result) {
            $('#container').html(result);
            HideProgress();
        },
        error: function () {
        },
        complete: function () {
            $("#domaintype_0").val('1');
            $("#domaindata_0").val('1');
            $("#portalaccess_0").val('');
            $(".chosen-select").chosen();
            $(".chosen-container-single").css('width', '100%');
            $(".chosen-container").css('width', '100%');
        }
    });
}
function Editpermisions(e) {
    var index = $(e).attr('index');
    console.log(index);
    var domaintype = $("#domaintype_" +index ).val();
    var domaindata = $("#domaindata_" + index).val();;
    var portalaccess = $("#portalaccess_" + index).val() != null ?$("#portalaccess_" + index).val().join(',') : "" ;
    $.ajax({
        url: url + "admin/Editpermission",
        type: "post",
        cache: false,
        data: {permissionid :index , domaintype: domaintype, domaindata: domaindata, portalaccess: portalaccess},
        async: true,
        success: function (result) {
            debugger;
            console.log(result);
            $("#msg").html(result);
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}
function Deltepermissions(e) {
    var index = $(e).attr('index');
    $.ajax({
        url: url + "admin/Deltepermissionss",
        type: "post",
        cache: false,
        data: { permissionid: index },
        async: true,
        success: function (result) {
            debugger;
            $("#row_" + index).remove();
            $("#msg").html(result);
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}
function NewFunction() {
    debugger;
    var functionid = $("#function_0").val();
    var accessrightid = $("#access_0").val() != null ?  $("#access_0").val().join(',') : "" ;
    var myinfo = false;
    if($("#myinfo_0").prop('checked') == true)
        myinfo = true;
    var permissionid = $("#permissionid").val();
    $.ajax({
        url: url + "admin/NewFunction",
        type: "post",
        cache: false,
        data: { permissionid: permissionid, functionid: functionid, accessrightid: accessrightid, myinfo: myinfo },
        async: true,
        success: function (result) {
            $("#msg").html(result);
            setTimeout(function () {
                location.reload();
            }, 700);
            //location.reload();
            //$('#container').html(result);
            //$(".chosen-select").chosen();
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}
function DelteFunction(e) {
    var id = $(e).attr('index');
    $.ajax({
        url: url + "admin/DelteFunction",
        type: "post",
        cache: false,
        data: { Id : id},
        async: true,
        success: function (result) {
            $("#msg").html(result);
            $("#row_" + id).remove();
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}
function UpdateFunction(e) {
    var id = $(e).attr('index');
    var permissionid = $("#permissionid").val();
    var fuctionid = $("#function_" + id).val();
    var accessids = $("#access_" + id).val() != null ? $("#access_" + id).val().join(',') : "";
    var myinfo = false;
    if ($("#myinfo_" + id).prop('checked') == true)
        myinfo = true;
    $.ajax({
        url: url + "admin/UpdateFunction",
        type: "post",
        cache: false,
        data: { Id: id, fuctionid: fuctionid, accessids: accessids, myinfo: myinfo, permissionid: permissionid },
        async: true,
        success: function (result) {
            $("#msg").html(result);
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}

function NewProduct() {
    var productname = $("#ProdName_0").val();
    $.ajax({
        url: url + "admin/NewProduct",
        type: "post",
        cache: false,
        data: { productname: productname },
        async: true,
        success: function (result) {
            $('#container').html(result);
        },
        error: function (result) {
            $("#msg").html(ex);
        }
    });
}

function EditProduct(e) {
    var productid = $(e).attr('index');
    var productname = $("#ProdName_" + productid).val();
    $.ajax({
        url: url + "admin/EditProduct",
        type: "post",
        cache: false,
        data: { productid: productid, productname: productname },
        async: true,
        success: function (result) {
            $("#msg").html(result);
        },
        error: function (result) {
            $("#msg").html(ex);
        }
    });
}

function DeleteProduct(e) {
    var productid = $(e).attr('index');
    $.ajax({
        url: url + "admin/DeleteProduct",
        type: "post",
        cache: false,
        data: { productid: productid },
        async: true,
        success: function (result) {
            $("#msg").html(result);
            $("#row_" + productid).remove();
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}

function NewDataScope() {
    debugger;
    var BankID = $("#BankID_0").val();
    var ProductID = $("#ProductID_0").val();
    var TypeID = $("#TypeID_0").val();
    var RegionID = $("#RegionID_0").val() != null ? $("#RegionID_0").val().join(',') : "";
    var CityID = $("#CityID_0").val() != null ? $("#CityID_0").val().join(',') : "";
    var UserId = $("#UserId").val();
    $.ajax({
        url: url + "admin/NewDataScope",
        type: "post",
        cache: false,
        data: { BankID: BankID, ProductID: ProductID, TypeID: TypeID, RegionID: RegionID, CityID: CityID, UserId: UserId },
        async: true,
        success: function (result) {
            debugger;
            //$('#container').html(result);
            location.reload();
            setTimeout(function () {
                
            }, 0);
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}

function EditDataScope(id) {
    debugger;
    var BankID = $("#Bank_" + id + " .BANK").val();
    var ProductID = $("#ProductID_" + id + " .PRODUCT").val();
    var TypeID = $("#TypeID_" + id + " .TYPE").val();
    var RegionID = $("#RegionID_" + id + " .REGION").val() != null ? $("#RegionID_" + id + " .REGION").val().join(',') : "";
    var CityID = $("#CityID_" + id + " .CITY").val() != null ? $("#CityID_" + id + " .CITY").val().join(',') : "";
    $.ajax({
        url: url + "admin/EditDataScope",
        type: "post",
        cache: false,
        data: { BankID: BankID, ProductID: ProductID, TypeID: TypeID, RegionID: RegionID, CityID:CityID, ID: id},
        async: true,
        success: function (result) {
            $('#msg').html(result);
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}

function DeleteDataScope(id) {
    $.ajax({
        url: url + "admin/DeleteDataScope",
        type: "post",
        cache: false,
        data: { ID : id },
        async: true,
        success: function (result) {
            $('#msg').html(result);
            $("#row_" + id).remove();
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}

function AccessRightChange(e) {
    var Aceesval = $(e).val();
    if (Aceesval != null) {
        if (Aceesval.includes('5')) {
            $(e).val("5");
            $(e).trigger("chosen:updated");
        }
    }
}

function RegionChange(e) {
    var regionval = $(e).val();
    if (regionval != null) {
        if (regionval.includes('0')) {
            $(e).val("0");
            $(e).trigger("chosen:updated");
        }
    } 
}
function NewCity() {
    var cityname = $("#CityName_0").val();
    $.ajax({
        url: url + "admin/NewCity",
        type: "post",
        cache: false,
        data: { cityname: cityname },
        async: true,
        success: function (result) {
            $('#container').html(result);
        },
        error: function (result) {
            $("#msg").html(ex);
        }
    });
}

function EditCity(e) {
    var cityid = $(e).attr('index');
    var cityname = $("#CityName_" + cityid).val();
    $.ajax({
        url: url + "admin/EditCity",
        type: "post",
        cache: false,
        data: { cityid: cityid, cityname: cityname },
        async: true,
        success: function (result) {
            $("#msg").html(result);
        },
        error: function (result) {
            $("#msg").html(ex);
        }
    });
}

function DeleteCity(e) {
    var cityid = $(e).attr('index');
    $.ajax({
        url: url + "admin/DeleteCity",
        type: "post",
        cache: false,
        data: { cityid: cityid },
        async: true,
        success: function (result) {
            $("#msg").html(result);
            $("#row_" + cityid).remove();
        },
        error: function (ex) {
            $("#msg").html(ex);
        }
    });
}
function CityChange(e) {
    var regionval = $(e).val();
    if (regionval != null) {
        if (regionval.includes('0')) {
            $(e).val("0");
            $(e).trigger("chosen:updated");
        }
    }
}