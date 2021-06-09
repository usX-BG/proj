function imgClick(clicked_id) {
    document.querySelector("#head-img").src = "../img/slika" + clicked_id + ".jpg";
    document.querySelector("#head-img-title").innerText = "Slika " + clicked_id;
}