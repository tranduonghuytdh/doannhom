 //$(function(){
 //	// console.log('Vị trí của chapter1 là : ' + $('').offset().top);

 //	$('.sp').on('click', function(event) {
 //		event.preventDefault();
 //		$('body,html').animate({scrollTop: $('#khoi').offset().top});
 //	});
 //})


document.addEventListener("DOMContentLoaded",function(){

	var  nut = document.querySelectorAll('.chuyenslide ul li');
	var slide = document.querySelectorAll('.cacslide ul li');
	var thoigian = setInterval(function(){ autoSlide()},3000);
	for (var i = 0; i < nut.length; i++) {
		nut[i].addEventListener('click',function(){
			clearInterval(thoigian);
			for (var i = 0; i < nut.length; i++) {
				nut[i].classList.remove('kichhoat');
			}
			this.classList.add('kichhoat');
			var vitri = 0;
			var nutkichhoat = this;
			for (vitri = 0;nutkichhoat = nutkichhoat.previousElementSibling; vitri++) {}
			// Sau khi biết được vị trí thì mún hiển thị slide nào thì dựa vào vị trí
			for (var i = 0; i < slide.length; i++) {
				slide[i].classList.remove('active');
				slide[vitri].classList.add('active');
			}
		})
	}
	// Tự động chuyển slide
	function autoSlide(){
			var slideHienthi = document.querySelector('.cacslide ul li.active');
			var vitrislide = 0;
			for (vitrislide = 0;slideHienthi = slideHienthi.previousElementSibling;vitrislide++) {}
			// Check tới điểm cuối chưa nếu rồi thì hiển thị sldie đầu tiên
			if (vitrislide < (slide.length-1)) {
			for (var i = 0; i < slide.length; i++) {
				slide[i].classList.remove('active');
				nut[i].classList.remove('kichhoat');
			}
			slide[vitrislide].nextElementSibling.classList.add('active');
			nut[vitrislide].nextElementSibling.classList.add('kichhoat');
			}
			else{
				for (var i = 0; i < slide.length; i++) {
				slide[i].classList.remove('active');
				nut[i].classList.remove('kichhoat');
			}
			slide[0].classList.add('active');
			nut[0].classList.add('kichhoat');
			}
	}

},false);	


