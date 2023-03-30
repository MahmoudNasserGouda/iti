// // function getProducts(callback){
// //     var xhr=new XMLHttpRequest()
// //     xhr.open("get","https://fakestoreapi.com/products",true)  
// //     xhr.onreadystatechange=function()
// //     {
// //         if(xhr.readyState==4&&xhr.status==200)
// //         {
// //             var data=JSON.parse(xhr.responseText)
// //             callback(data)
// //         }
// //     } 
// //     xhr.send()
// // }

// // //getProducts()
// // getProducts((data)=>{

// //     for (var item of data) {
// //         var div=document.createElement("div")
// //         div.innerHTML=item.title
// //         document.body.appendChild(div)
// //     }
// // })


// function getStudent(target,finish)
// {
//     var xhr=new XMLHttpRequest()
//         xhr.open("get",target,true)  
//         xhr.onreadystatechange=function()
//         {
//             if(xhr.readyState==4&&xhr.status==200)
//             {
//                 var data=JSON.parse(xhr.responseText)
//                 finish(data)
//             }
//         } 
//         xhr.send()
// }
// getStudent("students.json",(data)=>{

//      console.log(data);
//      getStudent("students.json",(data)=>{

//         console.log(data)
//        })
// })

