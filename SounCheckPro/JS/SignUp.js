var Register = function () {
    var type = $("#ddltype option:selected").text();
    if (type == 'Client') {
        window.location.href = "/Visitor/Subscription";
    }

}