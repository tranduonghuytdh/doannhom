$(document).ready(function () {
	$('#frmLogin').validate({
		rules: {

			"username": {
				required: true,
				minlength: 3,
				maxlength: 6,
			},

			"password": {
				required: true,
				minlength: 6,
			},

			"repassword": {
				required: true,
				equalTo: "#mk1",
			},

			"fullname": {
				required: true,
			},

			"birthday": {
				required: true,
				date: "dd/MM/yyyy",
			},

			"gioitinh": {
				required: true,
			},

			"city": {
				required: true,
			},

			"email": {
				required: true,
				email: true,
			},

			"moreinfo": {
				required: true,
			},

			"phone": {
				digits: true,
			},

			"facebook": {
				url: true,
			},

		},
		messages: {

			"username": {
				required: "Vui lòng nhập Tên đăng nhập",
				minlength: "Nhập ít nhất 3 ký tự",
				maxlength: "Tối đa 6 kí tự",
			},

			"password": {
				required: "Vui lòng nhập mật khẩu",
				minlength: "Mật khẩu ít nhất 6 ký tự",
			},

			"repassword": {
				equalTo: "Mật khẩu không khớp",
			},

			"fullname": {
				required: "Vui lòng nhập họ và tên",
			},

			"birthday": {
				required: "Vui lòng nhập ngày sinh",
				date: "dd/MM/yyyy",
			},

			"gioitinh": {
				required: "Vui lòng chọn giới tính",
			},

			"city": {
				required: "Vui lòng chọn địa chỉ",
			},

			"email": {
				required: "Vui lòng nhập emal",
				email: "Định dạng @",
			},

			"moreinfo": {
				required: "Vui lòng nhập thông tin thêm",
			},

			"phone": {
				digits: "Phải là số",
			},

			"facebook": {
				url: "Dạng https://",
			},

		},
	});
});	
