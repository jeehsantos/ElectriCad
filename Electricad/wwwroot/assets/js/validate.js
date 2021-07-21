   /* $(function () {

        $("#name_error_message").hide();
        $("#email_error_message").hide();
        $("#subject_error_message").hide();
        $("#message_error_message").hide();
        var error_name = false;
        var error_email = false;
        var error_subject = false;
        var error_message = false;
        $("#name").focusout(function () {
            check_name();
        });
        $("#email").focusout(function () {
            check_email();
        });
        $("#subject").focusout(function () {
            check_subject();
        });
        $("#message").focusout(function () {
            check_message();
        });

        function check_name() {
            var pattern = /^[a-zA-Z]*$/;
            var name = $("#name").val();
            if (pattern.test(name) && name !== '') {
                $("#name_error_message").hide();
                $("#name").css("border-bottom", "2px solid #34F458");
            } else {
                $("#name_error_message").html("Please type your full name");
                $("#name_error_message").show();
                $("#name").css("border-bottom", "2px solid #F90A0A");
                error_name = true;
            }
        }
        function check_email() {
        
            var email = $("#email").val();
            if (pattern.test(email) && email !== '') {
                $("#email_error_message").hide();
                $("#email").css("border-bottom", "2px solid #34F458");
            } else {
                $("#email_error_message").html("Please type your email");
                $("#email_error_message").show();
                $("#email").css("border-bottom", "2px solid #F90A0A");
                error_email = true;
            }
        }
        function check_subject() {
            
            var subject = $("#subject").val();
            if (pattern.test(subject) && subject !== 'Subject') {
                $("#subject_error_message").hide();
                $("#subject").css("border-bottom", "2px solid #34F458");
            } else {
                $("#subject_error_message").html("Please select an option");
                $("#subject_error_message").show();
                $("#subject").css("border-bottom", "2px solid #F90A0A");
                error_subject = true;
            }
        }
        function check_message() {
            var pattern = /^[a-zA-Z]*$/;
            var message = $("#message").val();
            if (pattern.test(message) && message !== '') {
                $("#message_error_message").hide();
                $("#message").css("border-bottom", "2px solid #34F458");
            } else {
                $("#message_error_message").html("Please type a message to us !");
                $("#message_error_message").show();
                $("#message").css("border-bottom", "2px solid #F90A0A");
                error_name = true;
            }
        }

        $("#form").submit(function (e) {
            error_name = false;
            error_email = false;
            error_message = false;
            error_subject = "Subject";
            
            check_name();
            check_message();
            check_subject();
            check_email();
            if (error_name === false && error_email === false &&  error_message === false) {
               
                    toastr.success("Your message has been sent!");
                    return true;
                 
              
            } else {
               alert("Error sending your message, review the form !");
               // toastr.info("Error sending your message, review the form !");
                return false;
            }
        });



    });
 
 */