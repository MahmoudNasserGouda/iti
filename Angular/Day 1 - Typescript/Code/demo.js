console.log("Hello world to type script started");
//data type
// Number , String , Boolean, any , void , array , object
var num1 = 20;
//num1 = 0b101;
//num1 = "Abc";
console.log(num1);
var str = "Hello";
str += " World";
str = "New String : ".concat(num1);
console.log(str);
var newBool = false;
console.log(newBool);
var person = {
    name: "Ali",
    age: 20
};
console.log("Name : ".concat(person.name, ", age : ").concat(person.age));
var arr;
arr = ["new start", "new end"];
console.log(arr);
var arr2 = [1, 2, 3, 4, 5];
console.log(arr2);
//tuple
var tupleNew;
tupleNew = [12, "Hello", true, ["start", "End"]];
console.log(tupleNew);
//union
var unionNew;
unionNew = "New Union";
console.log(unionNew);
var union2;
union2 = true;
var unionArr;
unionArr = [1, "hello", 34, 21, "text"];
console.log(unionArr);
var unionTest;
unionTest = ["1", "2"];
var unionArr2;
unionArr2 = [1, 2, 3, 4];
unionArr2 = ["1", "2", "3"];
console.log(unionArr2);
var testAny;
testAny = [1, 2, "ah", true];
console.log(testAny);
var newPerson = {
    name: "ali",
    age: 30,
    print: function () { }
};
newPerson.print = function () {
    console.log(newPerson);
};
newPerson.print();
//enum
var Role;
(function (Role) {
    Role["Admin"] = "admin";
    Role["User"] = "user";
})(Role || (Role = {}));
var DayWeek;
(function (DayWeek) {
    DayWeek[DayWeek["sat"] = 0] = "sat";
    DayWeek[DayWeek["sun"] = 1] = "sun";
    DayWeek[DayWeek["mon"] = 2] = "mon";
    DayWeek[DayWeek["tues"] = 3] = "tues";
    DayWeek[DayWeek["wed"] = 4] = "wed";
    DayWeek[DayWeek["thurs"] = 5] = "thurs";
    DayWeek[DayWeek["fri"] = 6] = "fri";
})(DayWeek || (DayWeek = {}));
function funName(x) {
    if (typeof (x) === "number") {
        console.log(x);
    }
    else if (typeof (x) === "string") {
        console.log(x);
    }
}
funName(2);
function subNumbers(num1, num2) {
    return num1 + num2;
}
console.log(subNumbers(2, 10));
function sayHello(name) {
    console.log("Hello ".concat(name));
}
sayHello("Asmaa");
function sum(num1, num2) {
    if (num2 === void 0) { num2 = 3; }
    return num1 + num2;
}
console.log(sum(2, 5));
function sumWithOptionally(num1, num2, num3) {
    if (num3 == undefined) {
        return num1 + num2;
    }
    else {
        return num1 + num2 + num3;
    }
}
console.log(sumWithOptionally(1, 2, 3));
function sumWithArray(arr) {
    var sum = 0;
    for (var i = 0; i < arr.length; i++) {
        sum += arr[i];
    }
    console.log("Sum = ".concat(sum));
}
sumWithArray([1, 2, 3, 4]);
function sumArrayvalues() {
    var arr = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        arr[_i] = arguments[_i];
    }
    var sum = 0;
    for (var i = 0; i < arr.length; i++) {
        sum += arr[i];
    }
    console.log("Sum = ".concat(sum));
}
sumArrayvalues(1, 2, 3, 4);
var res = function () {
    return "Hello Anoymous Function";
};
console.log(res());
var sumNum = function (num) { return 10 + num; };
console.log(sumNum(30));
var res2 = function () { console.log("testing"); };
res2();
var res3 = function (num1) { console.log("the result three : ".concat(num1)); };
res3(true);
function funOverloadTest(x, y, z) {
    if (y != undefined) {
        console.log(y);
    }
    if (z != undefined) {
        console.log(z);
    }
}
funOverloadTest(3, 4, 3);
