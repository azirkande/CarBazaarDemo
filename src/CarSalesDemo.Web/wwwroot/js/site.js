
$(function () {

    $('#enquiryForm').submit(function (e) {

        var name = $("#customerEnquiryName").val();
        var email = $("#customerEnquiryEmail").val();
        var carId = $("#CarId").val();

        var enquiryObj = {
            Email: email,
            Name: name,
            CarId : carId
        };

        if ($(this).valid()) {
            $.ajax({
                url: '/Enquiry/SaveEnquiry',
                type: 'POST',
                data: JSON.stringify(enquiryObj),
                dataType: 'html',
                contentType: 'application/json; charset=utf-8',
                success: function (result) {
                    $("#enquirySection").html(result);
                }
              
            });
    }
        return false;
});

});

