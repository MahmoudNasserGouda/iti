// // 5 •	Create a student class that contains: name, University, faculty, and final grade.
// class Student {
//     constructor(std_name, university, faculty, finalGrade) {
//         this.std_name = std_name
//         this.university = university
//         this.faculty = faculty
//         this.finalGrade = finalGrade
//     }
//     // 6 •	print student data in the console using template literals in this format:
//     // {Std_name} is a student in faculty of {fac_name} in university {Uni_name}
//     // And his final grad is {grad}.
//     display(){
//         return `${this.std_name} is a student in faculty of ${this.faculty} in university ${this.university} And his final grad is ${this.finalGrade}.`
//     }
// }
// var std = new Student("mahmoud", "ain-shams", "engineering", "d")
// document.writeln(std.display())


// // 7 •	Make a set that holds student names.
// const std_names = new Set(["mahmoud","ahmed","mohamed"]);
// console.log(std_names) //Set(3) [ "mahmoud", "ahmed", "mohamed" ]

// // 8 •	Try to add repeated names, will the set accept it?
// const std_names_repeated = new Set(["mahmoud","ahmed","mohamed","mahmoud"]);
// console.log(std_names) //Set(3) [ "mahmoud", "ahmed", "mohamed" ]

// // 9 •	Print the set values using spread operator and using for…of.
// console.log(...std_names)
// for (const std_name of std_names) {
//     console.log(std_name)
// }


// // 10 •	Make a page that displays a tip for user every 3 seconds, as the following:
// // Create a generator that has an array of 10 tips, and loops on the array and each time returns the next tip.
// // Make a button that loop on the generator and display all tips [Using for…of]
// // Make another button that uses setInterval (with arrow function) to display a tip every 3 seconds from the generator.[use next()].
// const tips = function*() {
//     var tipsarr = ["aaaaaa","bbbbbb","cccccc","dddddd","eeeeee","ffffff","gggggg","hhhhhh","iiiiii","jjjjjj"];
//     for (const tip of tipsarr) {
//         yield tip;
//     }
// };
// const tipg = tips();
// var inter = setInterval(() => {
//     var cur = tipg.next();
//     cur.done? clearInterval(inter) : document.writeln(cur.value);
// }, 300);
// // for (const tip of tipg) {
// //     document.writeln(tip);
// // }


// //1.	Create a function that using fetch and make an Ajax call to this URL
// // (https://jsonplaceholder.typicode.com/users), and after getting the users,
// // display them in a dropdownlist (<select> item)in your page.
// //a.	Make button besides the list (Show image), and make it disabled.
// //b.	After the user are retrieved from the server and filled in the drop-down list,
// // enable the button, and when clicked, it should display the user details.
// async function getUsers(target,finish)
// {
//     var XHR = new XMLHttpRequest();
//         await XHR.open("get", target, true);  
//         XHR.onreadystatechange = function () {
//             if (XHR.readyState == 4 && XHR.status == 200) {
//                 var users = XHR.responseText;
//                 finish(JSON.parse(users))
//             }
//         } 
//         XHR.send();
// }
// getUsers("https://jsonplaceholder.typicode.com/users",(data) => {
//     for (var user of data){
//         var op = document.createElement("option");
//         op.value = user.id;
//         op.innerText = user.name;
//         var drop = document.getElementById("users");
//         drop.appendChild(op)
//     }
//     document.getElementById("btn").disabled = false
// })
// async function getUser() {
//     var XHR = new XMLHttpRequest();
//     XHR.onreadystatechange = function () {
//         if (XHR.readyState == 4 && XHR.status == 200) {
//             var user = XHR.responseText;
//             user = JSON.parse(user);
//             // alert(user);
//             displayUser(user);
//         }
//     };
//     var url = "https://jsonplaceholder.typicode.com/users/" + document.getElementById("users").value;
//     await XHR.open("get", url, true);
//     XHR.send();
// }
// function displayUser(u) {
//     // document.getElementById("avatar").src = u.avatar;
//     document.getElementById("name").innerText = u.name;
//     document.getElementById("email").innerText = u.email;
// }


// // 3.	Use promises to implement a web page:
// // a.	When opens it shows welcome message after 3 seconds.
// // b.	After finishing the previous action, display the user image.
// // c.	And then, display a thanks message after 3 seconds.
// // d.	And finally, redirects to another page.
// function start() {
//     return new Promise((resolve, reject) => {
//         setTimeout(() => {
//             document.writeln("Welcome..............")
//             if (true)
//                 resolve("Success!");
//             else
//                 reject("Error");
//         }, 3000);
//     });
// }
// start().then((mg) => {
//     var img = document.createElement("img")
//     img.src = "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"
//     setTimeout(() => {
//         document.body.appendChild(img)
//     }, 3000);
// }).then((mg) => {
//     setTimeout(() => {
//         document.writeln("thanks..............")
//     }, 3000);
// })