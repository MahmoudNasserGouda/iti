// // // // document.writeln("hello from external file")

// // // //primitive dataType(string,number,boolen ,null,undefiend)
// // // //Object dataType

// // // // variables in JS are loosely Typed
// // // var x=5

// // // // contianer={}
// // // // contianer=45
// // // // contianer=function(){}
// // // // contianer=undefined
// // // // contianer=[]
// // // // contianer=null
// // // // var contianer="ahmed";
// // // // console.log(contianer)
// // // // console.log(typeof contianer)

// // // console.log(x++)//x=x+1 //unary
// // // console.log(++x)
// // // console.log(x*4)//binary
// // // console.log(x>5)//coparation < > (==) !=
// // // console.log("ahmed"+ " "+"hamdy")//concationation

// // //condations stetment //if //switch

// // // if(//condation){
// // //     //stetment
// // // }else{
// // //      //stetment
// // // }

// // // var x=4
// // // if(x==5){
// // //     console.log("true")
// // // }else if(x>5){
// // //     console.log(">5")
// // // }else{
// // //     console.log("false")

// // // }

// // //false value in JS

// // // var z="false";
// // //undefined
// // //null
// // //0
// // // ""
// // // if(z!=undefined&&z!=0&&z!=""){
// // //     console.log("true")
// // // }else{
// // //     console.log("false")
// // // }

// // // if(z){
// // //     console.log("true")
// // // }else{
// // //     console.log("false")
// // // }

// // //coercion T/F=>number=>sting
// // // var x=5
// // // var y="5"
// // // console.log(x==y)//check value
// // // console.log(x===y)//check value and dataType
// // // console.log(6<5<4)
// // /**
// //  * 6<5
// //  * false<4
// //  * 0<4
// //  */
// // // var x = "RED";
// // // switch (x) {
// // //   case "red":
// // //   case "RED":
// // //     console.log("red");
// // //     break;
// // //   case "blue":
// // //     console.log("blue");
// // //     break;
// // //   default:
// // //     console.log("not found");
// // //     break;
// // // }

// // //loop //for  /while/ do while

// // // for(var i=0;i<3;++i){
// // //     console.log(i)
// // // }
// // console.log("----------------------")
// // var x=3
// // while (x<3) {
// //     console.log(x)
// //     x++
// // }
// // console.log("----------------------")

// // var y=3
// // do {
// //     console.log(y)
// //     y++
// // } while (y<3);
// /////////////////////////////////
// //function

// // function clac(num1,num2){
// //     var sum;
// //     sum=num1+num2
// //     return sum
// // }
// // // var ruselt=clac(5,6)
// // // console.log(ruselt)
// // alert("hello Ali")
// // var x=confirm("are you agree ??")
// // console.log(x)

// // if(x){
// //     alert("you are agree--- thanks")
// //    var fname= prompt("enter your name")
// //    console.log(fname)
// // }else{
// //     alert("you are Not agree--- thanks")
// // }

// // var num1= prompt("enter N1")
// // var num2= prompt("enter N2")

// // var num1int=parseInt(num1)
// // var num2int=parseInt(num2)
// // if(isNaN(num1))
// // {
// //     alert("plese enter number")
// // }else{

// // }
// // var num1int=parseFloat(num1)
// // var num2int=parseFloat(num2)

// // var result=clac(num1int,num2int)
// // alert(result)

// // var x="15.479"
// // // var y="ahmed"
// // console.log(parseInt(x));
// // console.log(parseFloat(x));

// // console.log(isNaN(y))
// // console.log(isFinite(y))

// function clacGrade(x) {
//   if (x >= 85) {
//     return "A+";
//   } else if (x < 85 && x >= 75) {
//     return "B";
//   } else if (x < 75 && x >= 65) {
//     return "C";
//   } else if (x < 65 && x >= 50) {
//     return "D";
//   } else {
//     return "F";
//   }
// }
// function printRuselt(userName,degreeeeee) {
//    document.writeln("hello "+userName+" your degree is "+ degreeeeee)
// }
// var fname = prompt("enter your name");
// var degreeinput = prompt("enter your degree (number)");
// var degree = parseFloat(degreeinput);
// var ruselt = clacGrade(degree);
// // printRuselt(fname,ruselt)
// alert("hello "+fname+" your degree is "+ ruselt)
