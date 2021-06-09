//document.addEventListener("DOMContentLoaded", function (event) {
    var imgIndex = 0;
    slider();
    function slider() {
        var imgNum = document.getElementsByClassName("slideImg");
        var ind = document.getElementsByClassName("indik");
        sliderInit();
        imgIndex++;
        if (imgIndex > imgNum.length) { imgIndex = 1 }
        imgNum[imgIndex - 1].style.display = "block";
        ind[imgIndex - 1].style.opacity = 1;
        setTimeout(slider, 3000);
    }
    function sliderInit() {
        var imgNum = document.getElementsByClassName("slideImg");
        var ind = document.getElementsByClassName("indik");
        var i;
        for (i = 0; i < imgNum.length; i++) {
            imgNum[i].style.display = "none";
        }
        for (i = 0; i < ind.length; i++) {
            ind[i].style.opacity =  0.5;
        }
    }
//});