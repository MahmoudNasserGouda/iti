// Task 1
// var numbers = []
// for (let i = 0; i < 3; i++) {
//     numbers[i] = parseFloat(prompt("Enter a number"))
// }
// document.writeln("Sum of the three values" + numbers.join("+") + " = " + eval(numbers.join("+")) + "<br>")
// document.writeln("Multiplication of the three values" + numbers.join("*") + " = " + eval(numbers.join("*")) + "<br>")
// document.writeln("Division of the three values" + numbers.join("/") + " = " + eval(numbers.join("/")))


// Task 2
// var rad = parseInt(prompt("Enter circle radius"))
// alert("The area of the circle is" + Math.PI*rad*rad)
// var val = parseInt(prompt("Enter value to get square root"))
// alert("The square root of " + val + " is " + Math.sqrt(val))
// var angle = parseInt(prompt("Enter angle to get cos"))
// alert("The cos of " + angle + " is " + Math.cos(angle * Math.PI / 180).toFixed(3))


// Task 3
// var str = prompt("Enter string to count e")
// var count = 0
// if (isNaN(str)) {
//     for (let i = 0; i < str.length; i++) {
//         if (str[i] == "e") {
//             count++
//         } 
//     }
//     alert("The number of e is " + count)
// }

// Task 4
// var arr = [5,4,8,12,0]
// document.writeln("The arr is " + arr + "<br>")
// arr.sort((a, b) => a - b)
// document.writeln("The arr sorted asc is " + arr + "<br>")
// arr.sort((a, b) => b - a)
// document.writeln("The arr sorted desc is " + arr)