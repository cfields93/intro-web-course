function validateItems() {
    var name = document.forms["contactUs"]["Name"].value;
    var email = document.forms["contactUs"]["Email"].value;
    var phone = document.forms["contactUs"]["Phone"].value;
    var isFormValid = true;

    if (name == "") {
        var isFormValid = false
        document.forms["contactUs"]["Name"]
            .parentElement.className = "form-group inline has-error";
        document.forms["contactUs"]["Name"].focus();
    }
    if (email == "") {
        var isFormValid = false
        document.forms["contactUs"]["Email"]
            .parentElement.className = "form-group inline has-error";
    }
    if (phone == "") {
        var isFormValid = false
        document.forms["contactUs"]["Phone"]
            .parentElement.className = "form-group inline has-error";
    }
    if (isFormValid == false) {
        alert("Please correct the errors on the page before submitting your request")
    } 
    return false;
}