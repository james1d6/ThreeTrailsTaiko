'use strict';

//GLOBAL
if (!NodeList.prototype.getIndex) {
	NodeList.prototype.getIndex = function (method) {
		for (var i = 0; i < this.length; i++) {
			if (method(this[i])) return i;
		}
		return -1;
	}
}

if (!NodeList.prototype.forEach) {
	NodeList.prototype.forEach = function (method) {
		for (var i = 0; i < this.length; i++) {
			method(this[i]);
		}
	}
}

function doathing(_) { var ___ = 0; var __ = [[116, 104, 114, 101, 101, 116, 114, 97, 105, 108, 115, 116, 97, 105, 107, 111], 64, [103, 109, 97, 105, 108, 46, 99, 111, 109]]; var whodat = window["Str" + "ing"]; if (_ == "holla") ___ = __; var heyoo = [60, 97, 32, 104, 114, 101, 102, 61, 34, [109, 97, [105, 108, [116, 111], 58]], [__], 34, 62, ___, 60, 47, 97, 62]; heyoo.forEach(doit); function doit(a) { if (a === 0) { document.write(_); return; } if (!a) return; if (!(!(!a.length))) { document.write(whodat.fromCharCode(a)); return; } a.forEach(doit); } }

//SLIDE SHOW
function slideShow() {
	var container = document.querySelector("ul.slideshow");
	var slides = container.querySelectorAll("li");
	var currentSlide = 0;

	start();

	function start() {
		slides[currentSlide].className = "active";
		setTimeout(changeSlide, 3000);
	}

	function changeSlide() {
		slides[currentSlide].className = "";
		if (++currentSlide >= slides.length) currentSlide = 0;
		slides[currentSlide].className = "active";
		console.log("show slide index " + currentSlide);

		setTimeout(changeSlide, 3000);
	}
}

//PHOTO GALLERY
function PhotoGallery(id) {
	var container;
	var items;
	var photoModal;
	var photo;
	var photoModalOpen = false;
	var modalMask;
	var modalDismiss;
	var modalInner;
	var currentPhoto;
	var nextPhoto;
	var previousPhoto;

	var currentPhotoNumber;
	var totalPhotosCount;

	window.addEventListener("load", windowLoad);

	function windowLoad() {
		container = document.getElementById(id);
		items = container.querySelectorAll("li img");
		photoModal = document.getElementById("photoModal");
		photo = photoModal.querySelector("img");
		modalMask = photoModal.querySelector(".mask");
		modalDismiss = photoModal.querySelector(".dismiss");
		modalInner = photoModal.querySelector(".photo-modal-inner");
		nextPhoto = photoModal.querySelector(".photo-modal .menu .next");
		previousPhoto = photoModal.querySelector(".photo-modal .menu .previous");

		items.forEach(o => o.addEventListener("click", click));

		modalInner.addEventListener("click", modalInnerClick);
		modalDismiss.addEventListener("click", modalDimissClick);

		nextPhoto.addEventListener("click", viewNextPhoto);
		previousPhoto.addEventListener("click", viewPreviousPhoto);

		currentPhotoNumber = photoModal.querySelector(".current-photo-number");
		totalPhotosCount = photoModal.querySelector(".total-photos-count");
		totalPhotosCount.innerHTML = items.length;
	}

	function click(e) {
		photoModalOpen = true;
		photo.src = "";
		photoModal.style.display = "block";
		setCurrentPhoto(items.getIndex((o) => o == e.target));
	}

	function setCurrentPhoto(i) {
		currentPhoto = i;
		if (currentPhoto >= items.length) {
			currentPhoto = 0;
		}
		else if (currentPhoto < 0) {
			currentPhoto = 0;
		}
		photo.src = items[currentPhoto].getAttribute("data-photo");
		currentPhotoNumber.innerHTML = currentPhoto + 1;
	}

	function modalDimissClick() {
		closeModal();
	}

	function modalInnerClick(e) {
		if (e.target.className == "photo-modal-inner") {
			closeModal();
		}
	}

	function closeModal() {
		photoModalOpen = false;
		photoModal.style.display = "none";
	}

	function viewNextPhoto() {
		setCurrentPhoto(currentPhoto + 1);
	}

	function viewPreviousPhoto() {
		setCurrentPhoto(currentPhoto - 1);
	}
}
