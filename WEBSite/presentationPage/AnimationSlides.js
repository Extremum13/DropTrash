var slideIndex = 1;
var counter = 1;
showSlidesT(1, 2);

function plusSlides(n) {

    showSlides(slideIndex += n);
    counter = slideIndex;
}

function currentSlide(n) {

    showSlides(slideIndex = n);
    counter = n;
}

function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("slides");
    var dots = document.getElementsByClassName("dot");
    if (n > slides.length) {
        slideIndex = 1
    }
    if (n < 1) {

        slideIndex = slides.length
    }

    for (i = 0; i < slides.length; i++) {

        slides[i].style.position = "absolute";
        slides[i].style.opacity = "0";
    }

    for (i = 0; i < dots.length; i++) {

        dots[i] = dots[i].style.backgroundColor = "#ffffff";
    }

    slides[slideIndex - 1].style.opacity = "100";

    dots[slideIndex - 1].style.backgroundColor = "#000000";
}

function showSlidesT() {

    var slides = document.getElementsByClassName("slides");

    if (counter > slides.length) {
        counter = 0;
    }
    currentSlide(counter);
    counter++;
    setTimeout(showSlidesT, 6000);
}
