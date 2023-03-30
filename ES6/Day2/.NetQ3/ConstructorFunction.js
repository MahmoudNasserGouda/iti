// //JavaScript is not Fully OOP ==> 1) Can not Contain Classes
// // Function Constructor

// function Shap(width=10, height) {  //Default Value
//    //  var width=0
//    var age = 10
//    //   if(x>=10)
//    //   {
//    //      age=x
//    //   }
//    var color = "red" // Private Member Access Inside Shap //Encapsulation ==> Hide Data  ==> Private and Public Member
//    this.width = width||10  //Default Value to Width
//    this.height = height  //Public Member Access OutSide Shap
//    this.Area = function () {
//       return this.width * this.height
//    }
//    this.toString = function ()  //overWrite
//    {
//       return `Width: ${this.width} & Heigth: ${this.height} & Color: ${color} & Age: ${age} & NewWidth: ${width}`
//    }
//    this.Draw = function (mgs) {
//       var div = document.createElement('div')
//       div.innerText = mgs
//       div.style.width = this.width
//       div.style.height = this.height
//       div.style.backgroundColor = color
//       return div
//    }

//    // overloading overriding overwrite

// }

// function Circle(radius)
// {
//    // this.width=radius
//    // this.height=radius
//    Shap.call(this,radius,radius)
//    this.Area=function() //Keep Function Name but Change Functionalty
//    {
//        return 2*this.width*3.14   //"Ploymorphsim" ==>OverRiding  ==> The same Name and parameter ==> but change body of function
//    }
//    this.Draw=function(mgs)
//    {
//       var div = document.createElement('div')
//       div.innerText = mgs
//       div.style.width = this.width
//       div.style.height = this.height
//       div.style.backgroundColor = color
//       div.style.borderRadius="10px"
//       return div
//    }
// }
// Circle.prototype=new Shap()
// var c=new Circle(10)
// console.log(c.Area())
// console.log(c)

// //Circle is a Shap   // RelationShip  ( is a )  ==> Inhertance
// // Squre is a Shap
// //Ract is a Shap

// // var s1 = new Shap(100, 300, 100)
// // // console.log(s1.height)  //Get Value
// // // console.log(s1.width) //Get Value
// // // s1.height=1000
// // console.log(s1.height)
// // console.log(s1.toString())
// // console.log(s1.Area())
// // console.log(s1.color)
// // console.log(s1.Draw("Div1"))
// // document.body.appendChild(s1.Draw("NewDiv"))
// // var s2=new Shap(100,200)
// // console.log(s2.height)

// // console.log(s1.Area())



// // var s=new Shap(100)
// // console.log(s)
// // console.log(s.height)
// // console.log(s.width)