window.onscroll = function () { myFunction() };

var navbar = document.getElementById("navbar");
var sticky = navbar.offsetTop;
var nav = document.getElementById("nav");
var sti = nav.offsetTop;


function myFunction() {
    var top;
    top = scrolltop()

    if (top > 80) {
        document.getElementById("submenu").style.display = "none";

        document.getElementById("main").style.visibility = "visible";
        //    document.getElementById("main").style.zIndex = 1;
    } else {
        document.getElementById("submenu").style.display = "block";
        // document.getElementById("b").style.display = "none";
        document.getElementById("main").style.visibility = "hidden";
    }

    if (window.pageYOffset >= sticky) {
        navbar.classList.add("sticky");
    } else {
        navbar.classList.remove("sticky");
    }

    if (window.pageYOffset >= sti) {
        nav.classList.add("sti")
    } else {
        nav.classList.remove("sti");
    }
}
function scrolltop() {
    var top = 0;
    if (typeof (window.pageYOffset) == "number") {
        top = window.pageYOffset;
    } else if (document.body && document.body.scrollTop) {
        top = document.body.scrollTop;
    } else if (document.documentElement && document.documentElement.scrollTop) {
        top = document.documentElement.scrollTop;
    }
    return top;
}
function scrollleft() {
    var elmnt = document.getElementById("myDIV");
    var x = elmnt.scrollLeft;
    //document.getElementById("demo").innerHTML = "Horizontally: " + x + "px<br>Vertically: " + y + "px";
}