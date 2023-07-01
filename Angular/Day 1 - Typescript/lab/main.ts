// 1.	Try the following Typescript features:
// a.	Types 
let v1: string = "Hello World";
console.log(v1);

// b.	union types 
let v2: string | number;
v2 = 20;
console.log(v2);

// c.	Function with typed arguments and return type.
function add(a: number, b: number): number {
    return a + b;
}
console.log(add(10, 20));


// d.	Enum in typescript
enum MaritalStatus {
    Single,
    Married,
    Divorced,
}
console.log(MaritalStatus[0]);


// e.	Interfaces & classes & inheritance
interface Person {
    name: string;
    print(): void;
}
class Student implements Person {
    name: string;
    constructor(name: string) {
      this.name = name;
    }
    print() {
      console.log(`Hello, my name is ${this.name}`);
    }
}
var student = new Student("Mahmoud");
student.print();

// f.	Generics
function printValue<T>(arg: T) {
    console.log(arg);
}
printValue<number>(70);

// g.	Search for Typescript Decorator and make demo
const changeValue = (value) => (target:Object, propertyKey:string) =>
{
    Object.defineProperty(target,propertyKey, {value});
}
class Test 
{
    @changeValue(200)
    num:number;
}
const test = new Test();
console.log(test.num);

// h.	Modules
import validator from "./module.js";
let myValidator = new validator();
console.log(myValidator.isAcceptable("11571"));




// 2-Create class point2D that has x and y and then create constructor in the class and then implement method to calculate  length between two points  .
// And calculate length as following  mathematic operation:
class Point2D {
    constructor(public x: number, public y: number) {}
    distance(other: Point2D): number {
      const dx = this.x - other.x;
      const dy = this.y - other.y;
      return Math.sqrt(dx * dx + dy * dy);
    }
}
var p1 = new Point2D(10, 10);
var p2 = new Point2D(20, 20);
console.log(p1.distance(p2));




// 3- Make class point3D inherit class point2D and class point3D has z point and then calculate length with three points.
class Point3D extends Point2D {
    constructor(x: number, y: number, public z: number) {
      super(x, y);
    }
    distanceTo(other: Point3D): number {
      const dx = this.x - other.x;
      const dy = this.y - other.y;
      const dz = this.z - other.z;
      return Math.sqrt(dx * dx + dy * dy + dz * dz);
    }
}
var p10 = new Point3D(10, 10, 10);
var p20 = new Point3D(20, 20, 20);
console.log(p10.distance(p20));




// 4- Try  write demo that generic class can implement a generic interface.  
interface MyInterface<T> {
    getValue(): T;
}
class MyClass<T> implements MyInterface<T> {
    constructor(private value: T) {}
    getValue(): T {
        return this.value;
    }
}
var a = new MyClass<number>(50).getValue();
console.log(a);