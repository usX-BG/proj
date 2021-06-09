let zvuk = new Audio();

function Himna(state_id) {
    zvuk.src = "../sounds/" + state_id + ".mp3";
    zvuk.play();
}

function Drzava(state_id){
    document.cookie = "drzava=" + state_id;
    window.open("../drzava.aspx","_blank");
}

function UpisiDrzavu()
{
    let drzava = getCookie("drzava");
    if(drzava != "")
    {
        let getNaziv = document.querySelector("#naziv");
        let getGLgrad = document.querySelector("#gl-grad");
        let getPovrsina = document.querySelector("#povrsina");
        switch(drzava)
        {
            case "madjarskaID":
                getNaziv.innerText = "Мађарска";
                getGLgrad.innerText = "Будимпешта";
                getPovrsina.innerText = "93000km2";
                break;
            case "rumunijaID":
                getNaziv.innerText = "Румунија";
                getGLgrad.innerText = "Букурешт";
                getPovrsina.innerText = "238000km2";
                break;
            case "hrvatskaID":
                getNaziv.innerText = "Хрватска";
                getGLgrad.innerText = "Загреб";
                getPovrsina.innerText = "56500km2";
                break;
            case "bihID":
                getNaziv.innerText = "Босна и Херцеговина";
                getGLgrad.innerText = "Сарајево";
                getPovrsina.innerText = "51000km2";
                break;
            case "cgID":
                getNaziv.innerText = "Црна Гора";
                getGLgrad.innerText = "Подгорица";
                getPovrsina.innerText = "14000km2";
                break;
            case "bugarskaID":
                getNaziv.innerText = "Бугарска";
                getGLgrad.innerText = "Софија";
                getPovrsina.innerText = "111000km2";
                break;
            case "albanijaID":
                getNaziv.innerText = "Албанија";
                getGLgrad.innerText = "Тирана";
                getPovrsina.innerText = "29000km2";
                break;
            case "makedonijaID":
                getNaziv.innerText = "Македонија";
                getGLgrad.innerText = "Скопље";
                getPovrsina.innerText = "26000km2";
                break;
            default:
                window.close();
        }
        document.cookie = "drzava = ";
    }
    else
    {
        window.close();
    }
}

function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for(var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}