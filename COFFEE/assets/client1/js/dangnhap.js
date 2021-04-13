$(document).ready(function () {
	$('#frmLogin').validate({
		rules: {

			"username": {
				required: true,
			},

			"password": {
				required: true,
				minlength: 6,
			},
		},
		messages: {

			"username": {
				required: "Vui lòng nhập Tên đăng nhập",
			},

			"password": {
				required: "Vui lòng nhập mật khẩu",
				minlength: "Mật khẩu ít nhất 6 ký tự",
			},
		},
	});
});	
