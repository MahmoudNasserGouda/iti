// class Shap{ // ==> Constructor function

//     #color="red" // Private Member
//     constructor(width,height)  // => Shap of Creation Of Object
//     {
//         this.width=width //Public Member
//         this.height=height
//     }
//     toString(){
//         return `Width: ${this.width} & Height: ${this.height} & Color: ${this.#color}`
//     }
//     Draw(mgs)
//     {
//       var div = document.createElement('div')
//       div.innerText = mgs
//       div.style.width = this.width
//       div.style.height = this.height
//       return div
//     }

// }

// class Circle extends Shap
// {
//     constructor(radius,c)  
//     {
//       super(radius,radius)
//       this.color=c
//     }
//     Area()
//     {
//         return this.width*this.width*3.14
//     }
// }
// var s=new Shap(100,200)
// console.log(s.height)
// var c=new Circle(10)
// console.log(c.Area())
// c.color