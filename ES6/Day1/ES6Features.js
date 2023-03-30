// Let
// function getValues() {
//     var number = parseInt(prompt("Enter Your Name"))
//     var result = 1
//     // !5 !10 5*4*3*2*1
//     for (let i = number; i > 1; i--) {
//         result *= i;
//     }
//     console.log(i)
//     return result
// }

// console.log(getValues())

//Template literals
// var x=3
// console.log(`res= ${x}`)  // Javascript with String

// document.getElementById('btn').onclick=function(){
//     console.log(this) //btn
//     window.setTimeout(function(){
//         console.log(this) //window
//         console.log(this.value)
//     },3000)
// }

// document.getElementById('btn').onclick=function(){
//     console.log(this)  //btn
//     window.setTimeout(()=>{
//         console.log(this) // btn
//         console.log(this.value)
//     },3000)
// }


var arr1=[1,2,3,100,200]
var arr2=[...arr1,4,5,6] 
console.log(arr2)  //1,2,3,4,5,6   [1,2,3],4,5,6


function sum(...values) //x,y,z
{
    var res=0;
    for(item of values)
    {
        res+=item
    }
    return res;
}
var arr=[1,5,1]
console.log(sum(...arr));
