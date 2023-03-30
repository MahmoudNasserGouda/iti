//1 •	Alert the sum of 2 numbers, 
//and pass the sum as an argument to alert function (slef-invoking function).
(function (x, y) {
    alert(x + y)
})(4, 5)


// 2 • Try arrow function:
// • With Array.filter() function, to return the odd numbers from an array.
var arr = [0,1,2,3,4,5,6,7,8,9]
var arr2 = arr.filter((x) => {
    return x % 2 != 0;
})
console.log(arr2)
// • With array.forech() to print the even values.
var arr = [0,1,2,3,4,5,6,7,8,9]
var arr2 = []
arr.forEach((x) => {
    if (x % 2 == 0)
        arr2.push(x)
    return arr2;
 })
console.log(arr2)
// • With array.map() to print the square of each element.
var arr = [0,1,2,3,4,5,6,7,8,9]
var arr2 = arr.map((x) => {
        x = x * x
    return x;
 })
console.log(arr2)
// • “An arrow function does not create its own this context,
// unlike the normal literal function.” – Explain with demo.
var h1 = document.createElement("h1")
h1.innerText = "Mahmoud Nasser"
document.body.appendChild(h1)
h1.onclick = function () {
    console.log(this)  //h1
    window.setTimeout(function () {
        console.log(this) // window
    }, 3000)
}
h1.onclick = function () {
    console.log(this)  //h1
    window.setTimeout(() => {
        console.log(this) // h1
    }, 3000)
}


// 3 •	Try for…in, for…of and .foreach() with an array.
// •	What’re the differences between for…in, for…of and .foreach().
var arr = [0,10,20,30,40,50,60,70,80,90]
for (let i in arr) {
    console.log(i) //0,1,2,3,4,5,6,7,8,9
}
for (const v of arr) {
    console.log(v) //0,10,20,30,40,50,60,70,80,90
}
arr.forEach((v, i) => {
    console.log(v) //0,10,20,30,40,50,60,70,80,90
    console.log(i) //0,1,2,3,4,5,6,7,8,9
});


// 4 •	Try spread operator with any array of your implementation.
var arr=[1,2,3]
console.log([arr,4,5,6])     // [[1,2,3],4,5,6]
console.log([...arr,4,5,6])  // [1,2,3,4,5,6]