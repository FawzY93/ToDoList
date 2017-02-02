function validateRequiredFields() {
    name = $("#name").val();
    age = $("#age").val();
    id = $("#id").val();

    if (!(name && age && id)) {
        $("#message").text("Please provide all the required fields");
        event.preventDefault();
    }
}

