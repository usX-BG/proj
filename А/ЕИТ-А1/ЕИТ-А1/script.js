var zvuk = new Audio();

document.querySelector(".prva").addEventListener("mouseover", function () {
    zvuk.src = 'audio/svinja.mp3';
    zvuk.play();
});
document.querySelector(".druga").addEventListener("mouseover", function () {
    zvuk.src = 'audio/macka.mp3';
    zvuk.play();
});
document.querySelector(".treca").addEventListener("mouseover", function () {
    zvuk.src = 'audio/ker.mp3';
    zvuk.play();
});
document.querySelector(".cetvrta").addEventListener("mouseover", function () {
    zvuk.src = 'audio/konj.mp3';
    zvuk.play();
});
document.querySelector(".peta").addEventListener("mouseover", function () {
    zvuk.src = 'audio/patka.mp3';
    zvuk.play();
});
document.querySelector(".prva").addEventListener("click", function () {
    window.open("pages/svinja.aspx");
});
document.querySelector(".druga").addEventListener("click", function () {
    window.open("pages/macka.aspx");
});
document.querySelector(".treca").addEventListener("click", function () {
    window.open("pages/ker.aspx");
});
document.querySelector(".cetvrta").addEventListener("click", function () {
    window.open("pages/konj.aspx");
});
document.querySelector(".peta").addEventListener("click", function () {
    window.open("pages/patka.aspx");
});