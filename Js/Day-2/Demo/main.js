/**
 * built in object
 * object => propirties and methods
 *
 */

//var x={}
//var x=[]
// string object
//var str1="ahmed hamdy"//string primative letterla creation
//var str2 =new String("ahmed") //string object
// console.log(typeof str1,str1)
// console.log(typeof str2,str2)

// //prop
// console.log(str1,str1.length)
// console.log(str2,str2.length)
// //methods
// console.log(str1.charAt(10))
// console.log(str1.indexOf('y'))
// console.log(str1.split(" "))
// console.log(str1.split("I"))
// console.log(str1.split(""))
// // console.log(str1.split("",5))

// console.log(str1.substring(4))
// console.log(str1.substring(4,8))
// console.log(str1.substring(4,20))
/////////////////////////////////////////
//number Object
// var nb1=45.6894722589662775211
// // var nb2=new Number(44)
// // console.log(nb1,typeof nb1)
// // console.log(nb2,typeof nb2)

// console.log(nb1.toFixed())
// console.log(nb1.toFixed(3))
// console.log(nb1.toString())
// console.log(nb1.toExponential())
////////////////////////////////////
//Math object
// console.log(Math.PI)
// console.log(Math.pow(5,5))
// console.log(Math.sqrt(25))
// console.log(Math.random())
// console.log((Math.random()*10).toFixed())
////////////////////////////////////////////
//Boolen object
// var isallow=false
// var isallow2=new Boolean(true)
// console.log(isallow, typeof isallow)
// console.log(isallow2, typeof isallow2)
///////////////////////////////////////////
/**
 *
 *
 */
var arr = [1, "aly", 4.67, null, undefined, {}, [], function () {}, false]; //letral creation
var copyarry = [];
// console.log(arr)
// console.log(arr[1])

// var arr2=new Array()
// var arr3=new Array(1,2,3)
// arr2[0]="hamada"
// arr2[1]="15"
// console.log(arr2)
// console.log(arr3)
// console.log(arr)
// console.log(arr.length)
// console.log("-------------------")

// for(var i=0;i<arr.length;i++){
//     // console.log(arr[i])
//     // copyarry[i]=arr[i]
//     copyarry.push(arr[i])
// }

// console.log(arr)
// console.log(copyarry)

// console.log(arr)
// console.log("array befor pop")
// console.log(arr.pop())
// console.log("array after pop")
// console.log(arr)

// console.log(arr)
// console.log("array befor push")
// console.log(arr.push("mohamed"))
// console.log("array after push")
// console.log(arr)

// console.log(arr)
// console.log("array befor shift")
// console.log(arr.shift())
// console.log("array after shift")
// console.log(arr)

// console.log(arr)
// console.log("array befor shift")
// console.log(arr.unshift("mohamed"))
// console.log("array after shift")
// console.log(arr)

// var arrx=[1,5,[[999,455],6,7],
// function(){console.log("hello")}]
// var y=arrx[2]
// console.log(y[0])
// console.log(y[0][0])
// console.log(arrx[2][2])
// var myfun=arrx[3]
// console.log(myfun)
// myfun()

// console.log(arr)
// console.log(arr[1])
// arr[1]="hamada"
// console.log(arr)

// for(var x=0;x<arr.length;x++){
//     if(arr[x]==null){
//         delete arr[x]
//     }
// }
// // console.log(arr)
// var xx=[1,2,3,4]
// console.log(xx.join(" "))
/////////////////////////////////////////////////
// //date object
// var date=new Date()
// console.log(date)
// console.log(date.getDate())
// console.log(date.getMonth())
// console.log(date.getMonth()+1)
// console.log(date.getTime())
// console.log(date.getYear())
// console.log(date.getYear()+1900)
// console.log(date.getFullYear())
// console.log(date.getDay())
// console.log(date.getHours())
/////////////////////////
//scope

// var x = 5;
// function myfun(y, u) {
//   var z = 6;
//   console.log(x + y + u + z);
// }

// console.log(z);//error

// myfun(1, 2);
// var obj={}
// var obj2=new Object()
// console.log(obj , typeof obj)
// console.log(obj2 , typeof obj2)
//dot notation
// var emp={}
// emp.name="mohamed";
// emp.age=26;
// emp.myfunctionbta3ty=function(){console.log("hello")}

// // console.log(emp.myfunctionbta3ty())
// // console.log(emp.name)

// var emp2={}

// emp2["name"]="mohamed"
// emp2["age"]=26
// emp2["myfunctionbta3ty"]=function(){
//     console.log("hello")
// }

var abdo={
    "name":"abdelrahman ",
    "age":25,
    "adress":"alex",
    "myfun":function(){
        console.log("hello")
    } 
}


var x="ahmed";
