function cacherA(){
    document.getElementById("Clics").style.display="none";// par defaut on cache le menu
   // getLocation();
}
function maFunction() {/*gestion affichage groupe de sous menu aussi faits en boutons*/
    var x = document.getElementById("Clics");
    if (x.style.display === "block") 
    {
        x.style.display = "none";
    } else {
        x.style.display = "block";
    }
}
function AllerURL1(){
    window.open("https://www.cegepgranby.qc.ca","Redirection depuis le MenuHamburger");
}
function AllerURL2(){
    window.open("https://www.google.ca","Redirection depuis le MenuHamburger");
}
function AllerURL3(){
    window.open("https://cegepgranby.omnivox.ca","Redirection depuis le MenuHamburger");
}
function AllerURL4(){
    window.open("https://sqlinfocg.cegepgranby.qc.ca/2196136/SitesWeb/Patrice_Structure_Page_Web/","Redirection depuis le MenuHamburger");
}
//Section Géolocalisation
function getLocation() {
    try {
      navigator.geolocation.getCurrentPosition(showPosition);
    } catch {
        document.getElementById("gps").innerHTML = err;
    }
}
function showPosition(position) {
    document.getElementById("gps").innerHTML = "(" +  position.coords.longitude+" , " + position.coords.latitude +")";
}
