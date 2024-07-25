$(function () {
    console.log("document ready");
    $(document).on("click", ".edit-product-button", function () {
        console.log("you just clicked button number " + $(this).val());

        //store the product Id number
        var productID = $(this).val();

        $.ajax({
            type: 'json',
            data: {
                "id": productID
            },
            url: '/product/ShowOneProductJSON',
            success: function (data) {
                console.log(data)


                //fill in the input fields

                $("#modal-input-id").val(data.id);
                $("#modal-input-name").val(data.name);
                $("#modal-input-price").val(data.price);
                $("#modal-input-description").val(data.description);
            }

        })
    });

    $("#save-button").click(function () {

        //get values from input fields and create a json object
        var Product = {
            "Id": $("#modal-input-id").val(),
            "Name": $("#modal-input-name").val(),
            "Price": $("#modal-input-price").val(),
            "Description": $("#modal-input-description").val()
        };

        console.log("saved...");
        console.log(Product);

        //save the updated product
        $.ajax({
            type: 'json',
            data: Product,
            url: '/product/ProcessEditReturnPartial',
            success: function (data) {
                console.log(data);
                $("#card-number-" + Product.Id).html(data).hide().fadeIn(2000);
            }
        })
    })
});