
var page = 1;
var inCallback = false;

function loadMore(url) {
    if (page > -1 && !inCallback) {
        page++;
        inCallback = true;
        $('#loading-animation').show();
        $('#load-more').hide();
        $.ajax({
            type: 'GET',
            url: url,
            data: "page=" + page,
            success: function (data, textstatus) {
                if (data !== "") {
                    $("#RecentBooks").append(data);
                    inCallback = false;
                    $('#loading-animation').hide();
                    $('#load-more').show();
                }
                else {
                    page = -1;
                    $('#loading-animation').hide();
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                $('#load-more').hide();
                $('#loading-animation').hide();
            }
        });
    }
}
