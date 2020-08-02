point_id = "point_id1";

function myFunction(min, max) {
    var x =  Math.floor(Math.random() * (max - min)) + min;



checkDot(x);

    if(x != 1){
        var total = parseInt(document.getElementById(point_id).textContent);
        total += x;
        document.getElementById(point_id).innerHTML = total;
        
    }else{
        document.getElementById(point_id).innerHTML = 0;
            if(point_id == "point_id1"){
                point_id = "point_id2";
                swapDot("dot_id1","dot_id2");
                swapBackground("box1","box2")
            }
            else{
                point_id = "point_id1";
                swapDot("dot_id2","dot_id1");
                swapBackground("box2","box1")
            }
        
        }
}
function checkDot(x){
removeDot("cham");
    switch (x) {

    case 1:
        document.getElementById("dot4").style.visibility = "visible";
        
        break;
    case 2:
        document.getElementById("dot1").style.visibility = "visible";
        document.getElementById("dot7").style.visibility = "visible";
        break;
    case 3:
        document.getElementById("dot1").style.visibility = "visible";
        document.getElementById("dot4").style.visibility = "visible";
        document.getElementById("dot7").style.visibility = "visible";
        break;
    case 4:
        document.getElementById("dot1").style.visibility = "visible";
        document.getElementById("dot3").style.visibility = "visible";
        document.getElementById("dot5").style.visibility = "visible";
        document.getElementById("dot7").style.visibility = "visible";
        break;
    case 5:
        document.getElementById("dot1").style.visibility = "visible";
        document.getElementById("dot3").style.visibility = "visible";
        document.getElementById("dot4").style.visibility = "visible";
        document.getElementById("dot5").style.visibility = "visible";
        document.getElementById("dot7").style.visibility = "visible";
        break;
    default:
        document.getElementById("dot1").style.visibility = "visible";
        document.getElementById("dot3").style.visibility = "visible";
        document.getElementById("dot2").style.visibility = "visible";
        document.getElementById("dot5").style.visibility = "visible";
        document.getElementById("dot6").style.visibility = "visible";

        document.getElementById("dot7").style.visibility = "visible";
        break
    }
}
function removeDot(dot){
    var dots = document.getElementsByClassName(dot);
    for (var i = 0; i < dots.length; i++) {
        dots[i].style.visibility = "hidden";
    }
}
function hold(){
   
    var sum = parseInt(document.getElementById(point_id).textContent);
    document.getElementById(point_id).innerHTML = 0;
    if(point_id == "point_id1"){
        point_id = "point_id2"
        updatePoint("point_id1",sum);
        swapDot("dot_id1","dot_id2");
        swapBackground("box1","box2")
    }else{
        point_id = "point_id1"
        updatePoint("point_id2",sum);
        swapDot("dot_id2","dot_id1");
        swapBackground("box2","box1")
    }

         

}
function updatePoint(point_id,sum){
    
        var point1 = parseInt(document.getElementById('point1').textContent);
        var point2 = parseInt(document.getElementById('point2').textContent);
       
        if(point_id == "point_id1"){
            point1 += sum;
            document.getElementById('point1').innerHTML = point1;
        }else{
            point2 += sum;
            document.getElementById('point2').innerHTML = point2;
        }

    if(point1 >=100){
        document.getElementById('win').style.zIndex = 1;
        document.getElementById('player1').style.visibility = "visible";
    }
    if(point2 >= 100){
        document.getElementById('win').style.zIndex = 1;
        document.getElementById('player2').style.visibility = "visible";
    }

        
   
}
function cancel(){
    document.getElementById('win').style.zIndex = -1;
    document.getElementById('player1').style.visibility = "hidden";
    document.getElementById('player2').style.visibility = "hidden";
    newGame();
}

function newGame(){
    document.getElementById('point1').innerHTML=0;
    document.getElementById('point2').innerHTML=0;
    document.getElementById(point_id).innerHTML=0;
    swapBackground("box2","box1")
    removeDot("cham");
    document.getElementById("dot4").style.visibility = "visible";
    if(point_id == "point_id1"){
       
    }
    else{
        point_id = "point_id1";
        document.getElementById('point1').innerHTML=0;
        document.getElementById('point2').innerHTML=0;
        document.getElementById(point_id).innerHTML=0;
        swapDot("dot_id2","dot_id1");
        document.getElementById("dot4").style.visibility = "visible";
        
    }
}

function swapDot(hidden,visible){
    document.getElementById(hidden).style.visibility="hidden";
    document.getElementById(visible).style.visibility="visible";
}
function swapBackground(box1,box2){
    document.getElementById(box1).style.background = "none";
    document.getElementById(box1).style.color = "#c1c1c1";
    if(box2 == "box1"){
        document.getElementById(box2).style.backgroundImage = "linear-gradient(to right, #fefefe , #f6f6f8)";
        document.getElementById(box2).style.color ="#000000";
    }else{
        document.getElementById(box2).style.backgroundImage = "linear-gradient(to left, #fefefe , #f6f6f8)";
        document.getElementById(box2).style.color = "#000000";

    }

}
