function doSearch() {
    var code = document.getElementById("SecurityCode").value;
    var srcText = document.getElementById("SearchText").value;

    $.ajax({
        url: "/SecurityLookUp/Search",
        type: "GET",
        data: {SecurityCode: code, SearchText: srcText }
    })
        .done(function (partialViewResult) {
            $("#SearchResults").html(partialViewResult);
        });

}