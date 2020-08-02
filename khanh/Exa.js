id_player="random1";
var time1=10;
var time2=10;
var clear1;
var clear2;
function swapTurn(hidden, visible){
    document.getElementById(hidden).style.visibility="hidden";
    document.getElementById(visible).style.visibility="visible";
}
function swapBackground(background1, background2){
    document.getElementById(background1).style.background="none";
    if(background2=="background1"){
        document.getElementById(background2).style.backgroundImage="linear-gradient(to right, #f2f2f2, #f6f6f8)";
    }else
    document.getElementById(background2).style.backgroundImage="linear-gradient(to left, #f2f2f2, #f6f6f8) ";
}
function swap(){
    document.getElementById(id_player).innerHTML = 0;
    if(id_player == "random1"){
        id_player = "random2";
        swapTurn("random1","random2");
        swapTurn("c1","c2");
        swapBackground("background1", "background2");
        start2();
        stop1();
    }
    else{
        id_player = "random1";
        swapTurn("random2","random1");   
        swapTurn("c2","c1");
        swapBackground("background2", "background1");
        start1();
        stop2();
    }
}
function hold(){
    var sum = parseInt(document.getElementById(id_player).textContent);
    document.getElementById(id_player).innerHTML=0;
    if(id_player == "random1"){
        id_player = "random2";
        swapTurn("random1","random2");
        swapTurn("c1","c2");
        score("random1",sum);
        swapBackground("background1", "background2");
        start2();
        stop1();
    }
    else{
        id_player = "random1";
        swapTurn("random2","random1");
        swapTurn("c2","c1");
        score("random2",sum);
        swapBackground("background2", "background1");
        start1();
        stop2();
    }
}
function random_player(){
    var a=Math.floor(Math.random()*6)+1;
    var imgs=["images/image1.png","images/image2.png","images/image3.png","images/image4.png","images/image5.png","images/image6.png" ];
    document.getElementById('img').src=imgs[a-1];
    if(a != 1){
        var sum = parseInt(document.getElementById(id_player).textContent);
        sum += a;
        document.getElementById(id_player).innerHTML = sum;
    }else{
        document.getElementById(id_player).innerHTML = 0;
            swap();
        }
}
function score(id_player, sum){
    var score1=parseInt(document.getElementById("score1").textContent);
    var score2=parseInt(document.getElementById("score2").textContent);
    if(id_player=="random1"){
        score1+=sum
        document.getElementById("score1").innerHTML=score1;
    }
    else{
        id_player = "random2";
        score2+=sum;
        document.getElementById("score2").innerHTML=score2;
    }
    win(score1,score2);
}

function newGame(){
    document.getElementById("score1").innerHTML=0;
    document.getElementById("score2").innerHTML=0;
    document.getElementById(id_player).innerHTML=0;
    id_player="random2";
    swap();
}
var getValue1=function (){
    time1--;
    if(time1==0){
        swap();
    }
    document.getElementById("time1").innerHTML=time1;
}
var getValue2=function(){
    var b=parseInt(document.getElementById("score2").textContent);
    time2--;
    if(time2==0){
        swap();
    }
    document.getElementById("time2").innerHTML=time2;
}
function start1(){  
    clear1=setInterval(getValue1, 1000);
}
function start2(){
    clear2=setInterval(getValue2, 1000);
}
function stop1(){
    clearInterval(clear1);
    time1=10;
    document.getElementById("time1").innerHTML=10;
}
function stop2(){
    clearInterval(clear2);
    time2=10;
    document.getElementById("time2").innerHTML=10;
}
function win(a,b){
    if(a>=100&&b<100){
        document.getElementById("div_tb").innerHTML="Player 1 Win!";
        setTimeout("f5()",3000);
    }else if(b>=100&&a<100){
        document.getElementById("div_tb").innerHTML="Player 2 Win!";
        setTimeout("f5()",3000);
    }
}
function f5(){
    location.reload();
}




  

