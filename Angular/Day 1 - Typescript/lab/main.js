var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
// 1.	Try the following Typescript features:
// a.	Types 
var v1 = "Hello World";
console.log(v1);
// b.	union types 
var v2;
v2 = 20;
console.log(v2);
// c.	Function with typed arguments and return type.
function add(a, b) {
    return a + b;
}
console.log(add(10, 20));
// d.	Enum in typescript
var MaritalStatus;
(function (MaritalStatus) {
    MaritalStatus[MaritalStatus["Single"] = 0] = "Single";
    MaritalStatus[MaritalStatus["Married"] = 1] = "Married";
    MaritalStatus[MaritalStatus["Divorced"] = 2] = "Divorced";
})(MaritalStatus || (MaritalStatus = {}));
console.log(MaritalStatus[0]);
var Student = /** @class */ (function () {
    function Student(name) {
        this.name = name;
    }
    Student.prototype.print = function () {
        console.log("Hello, my name is ".concat(this.name));
    };
    return Student;
}());
var student = new Student("Mahmoud");
student.print();
// f.	Generics
function printValue(arg) {
    console.log(arg);
}
printValue(70);
// g.	Search for Typescript Decorator and make demo
var changeValue = function (value) { return function (target, propertyKey) {
    Object.defineProperty(target, propertyKey, { value: value });
}; };
var Test = /** @class */ (function () {
    function Test() {
    }
    __decorate([
        changeValue(200)
    ], Test.prototype, "num", void 0);
    return Test;
}());
var test = new Test();
console.log(test.num);
// h.	Modules
import validator from "./module.js";
var myValidator = new validator();
console.log(myValidator.isAcceptable("11571"));
// 2-Create class point2D that has x and y and then create constructor in the class and then implement method to calculate  length between two points  .
// And calculate length as following  mathematic operation:
var Point2D = /** @class */ (function () {
    function Point2D(x, y) {
        this.x = x;
        this.y = y;
    }
    Point2D.prototype.distance = function (other) {
        var dx = this.x - other.x;
        var dy = this.y - other.y;
        return Math.sqrt(dx * dx + dy * dy);
    };
    return Point2D;
}());
var p1 = new Point2D(10, 10);
var p2 = new Point2D(20, 20);
console.log(p1.distance(p2));
// 3- Make class point3D inherit class point2D and class point3D has z point and then calculate length with three points.
var Point3D = /** @class */ (function (_super) {
    __extends(Point3D, _super);
    function Point3D(x, y, z) {
        var _this = _super.call(this, x, y) || this;
        _this.z = z;
        return _this;
    }
    Point3D.prototype.distanceTo = function (other) {
        var dx = this.x - other.x;
        var dy = this.y - other.y;
        var dz = this.z - other.z;
        return Math.sqrt(dx * dx + dy * dy + dz * dz);
    };
    return Point3D;
}(Point2D));
var p10 = new Point3D(10, 10, 10);
var p20 = new Point3D(20, 20, 20);
console.log(p10.distance(p20));
var MyClass = /** @class */ (function () {
    function MyClass(value) {
        this.value = value;
    }
    MyClass.prototype.getValue = function () {
        return this.value;
    };
    return MyClass;
}());
var a = new MyClass(50).getValue();
console.log(a);
