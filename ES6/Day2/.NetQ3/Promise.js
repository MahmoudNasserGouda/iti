// function getStudent()
// {
//     return new Promise((success,fail)=>{
//         var xhr=new XMLHttpRequest()
//         xhr.open("get","students.json",true)  
//         xhr.onreadystatechange=function()
//         {
//             if(xhr.readyState==4)
//             {
//                 if(xhr.status==200){
//                     success(JSON.parse(xhr.responseText))
//                 }
//                 else{
//                     fail("Something wrong")
//                 }  
//             }
//         } 
//         xhr.send()
//     })
    
// }
// // getStudent()
// // .then((data)=>{console.log(data)})
// // .catch((error)=>{console.log(error)})

// // getStudent()
// // .then((data)=>{
// //     data.sort((a,b)=>{return a.age-b.age})
// //     console.log(data)
// //     return data
// // })
// // .then((data)=>{
// //     var result=0
// //     for(item of data)
// //     {
// //         result+=item.age
// //     }
// //     return result
// // })
// // .then((data)=>{console.log(data)})
// // .catch((error)=>{console.log(error)})


// // async function Draw()
// // {
// //     var data=await getStudent()  //blocking
// //     console.log(data)
// // }
// // Draw()


fetch('https://fakestoreapi.com/products')//non block
            .then(respose=>respose.json())
            .then(data=>console.log(data))

document.write("lastttttttt")            


//Slef Study ==> set Map Genertor 
