(function () {    

    var ul = $("#customers").empty();
    $.getJSON("/admin/customersjson").done(function (d) {
        for (var i = 0; i < d.length; i++) {
            var li = $("<li />").html(d[i].id + " " + d[i].companyName);
            ul.append(li);

        }
    });

  


})()