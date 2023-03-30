var x=3
x=10  //Value Type

var y=x
y*=10
console.log(x)
console.log(y)

var arr=[1,2]
arr.push(100) //ref Type 
var arr2=arr  //Copy of Address of arr
for (item in arr2) {
    arr2[item]+=10
}
console.log(arr)
console.log(arr2)




// arr=[10,20,30]

// for(item in arr)
// {
//     console.log(arr[item])
// }

// for(item of arr)
// {
//     console.log(item)
// }

// arr.forEach(element => {
    
// });
