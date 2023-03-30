//Objects 
//1) Custom Object
//2) Built in Object
//3) DOM Object 
//4) BOM Object

// var student={
//     //Key:Value ==> Number String Array Object ArrayOfObjects Date Function
//     name:"Nawal",
//     age:24,
//     GPA:2.3,
//     courses:["HTML","CSS","JS"],
//     isGraduted:true
// }
// console.log(student.name)
// console.log(student["name"])

// Function Object
// Why to use Function?
//Reuse block of Code 

// Program take two Number from user and collect Sum of Two Number
// var number1,number2,result
// number1=parseInt(prompt("Enter Your Number1"))
// number2=parseInt(prompt("Enter Your Number2"))
// result=number1+number2
// alert(result)

// var str
// str="Nawal"
// console.log(str)
// alert("welcome "+ str)

// var number1,number2,result
// number1=parseInt(prompt("Enter Your Number1"))
// number2=parseInt(prompt("Enter Your Number2"))
// result=number1+number2
// alert(result)



//Types Of Functions
//1) Declerative Function


// function getValues() {
//     var number1, number2  //Local Variables
//     number1 = parseInt(prompt("Enter Your Number1"))
//     number2 = parseInt(prompt("Enter Your Number2"))
//    var x= sum(number1, number2)
//    return x
// }
// console.log(getValues())
// console.log(x)

// var y=getValues()
// console.log(y)


// function sum(num1, num2) {
//     var res = num1 + num2
//     return res
// }


// var x=sum(1,2)

//OutPut
//1) Alert()
//2) Doucment.write()
//3) Console.log()
//4) InnerHTML



// function sum() //Zero Parameter
// {
//     var number1, number2, result
//     number1 = parseInt(prompt("Enter Your Number1"))
//     number2 = parseInt(prompt("Enter Your Number2"))
//     result = number1 + number2
//     alert(result)
// }

// sum()


// Function must Make one event
// Function  must not contain any Statement for Output , Just Use Only Return

// console.log(printName())  //Hosting

// function printName()
// {
//    var UserName="nawal" // Local Varibale ==> Value "Nawal"
//    return UserName // Nawal
// }

// var x=printName()
// //x="Nawal"
// console.log(x)

// console.log(UserName)


//2) Dynamic anonymous Function
//  var d=new Date()
//  var reg=new RegExp()
//  var arr=new Array()
//  console.log(typeof(d))

// var printWelcome=new Function("return 'welcome';")

// console.log(printWelcome())

// var sum=new Function("x","y","return x+y;")

// console.log(sum(100,200))


//3) Litral anonymous Function

//  var sum=function()   //Parsed Once but not Hosting
//     {
//         return 2+3
//     }

//   console.log(sum())

//4) Self Invoking  (IIFF)

// for (var i = 0; i < 10; i++) {
//     var btn = document.createElement('input')
//     btn.setAttribute("value", i)
//     btn.setAttribute("type", "button")
//     console.log(i)
//     btn.onclick = (function (x) {
//         return function () {
//             alert(x)
//         }
//     })(i)
//     document.body.appendChild(btn)
// }
// function  showFun()
// {
//     return function()
//     {

//     }
// }

// console.log(showFun())


//5) Inner Function 
// function getValues() {
//     var number = parseInt(prompt("Enter Your Name"))
//     function ClacFact() {
//         var result = 1
//         // !5 !10 5*4*3*2*1
//         for (var i = number; i > 1; i--) {
//             result *= i;
//         }
//         return result
//     }
//     return ClacFact()
// }

//ClacFact() // Error As ClacFact is inner Function ==> Local

// console.log(getValues())


// function test()
// {
//     var x=3
//     function dotest()
//     {
//         var y=10
//         return x // Clouser  ==> InnerFunction / SelfInvoke
//     }
//     //console.log(y)
//     return dotest()
// }

// console.log(test())





