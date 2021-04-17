$("#uploadPhoto").click(function () {
    //console.log("upload click");

    var data = new FormData();
    //get(0) --> ke rabotime so prviot ke go zemis go ogranicuvame samo eden !!!
    var files = $("#photoUpload").get(0).files;


    //proveruvame dali ima zakaceno fajlovi, ako ima go prikacuvame na data
    if (files.length > 0) {
        data.append("UploadedImage", files[0]);
        console.log(data);
    }

    $.ajax({
        type: "POST",
        url: "/Movie/UploadPhoto",
        data: data,
        contentType: false,
        processData: false,
        //samiot ajax bara content, NE nie ke ti dademe drug kontent so ti ne go ocekuvas da go obrabotis
        success: function (data) {
            console.log(data.dbPath);
            $("#PhotoURL").val(data.dbPath);
        },
        error: function () {
            alert("Error uploading photo!");
        }
    });

});