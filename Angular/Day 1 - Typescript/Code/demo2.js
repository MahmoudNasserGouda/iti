function getArray(items) {
    return new Array().concat(items);
}
var numberValues = getArray([1, 2, 3, 4]);
var stringValues = getArray(["First", "Second", "Third", "Fourth"]);
console.log(numberValues);
stringValues.push(2);
console.log(stringValues);
//generic
function getArray2(items) {
    return new Array().concat(items);
}
var numberForGetArray = getArray2([1, 2, 3, 4]);
console.log(numberForGetArray);
var Employee = /** @class */ (function () {
    // private x;
    // protected y;
    // public z;
    // empName:string;
    // empId:number;
    // constructor(name:string, id:number)
    // {
    //     this.empName = name;
    //     this.empId = id;
    // }
    function Employee(name, id) {
        this.name = name;
        this.id = id;
    }
    Employee.prototype.calSalary = function () {
        return 3000;
    };
    Employee.prototype.print = function () {
        console.log("Employee Name : ".concat(this.name, " , ID : ").concat(this.id));
    };
    return Employee;
}());
var emp = new Employee("Ali", 12);
console.log(emp.calSalary());
emp.print();
var user = {
    name: "Mostafa",
    id: 100
};
console.log(user.name);
console.log(user.id);
var EmployeeWithInterface = /** @class */ (function () {
    function EmployeeWithInterface(name, empID, empAge) {
        this.name = name;
        this.empID = empID;
        this.empAge = empAge;
    }
    EmployeeWithInterface.prototype.printData = function () {
        console.log("Employee Name : ".concat(this.name, ", ID = ").concat(this.empID));
    };
    return EmployeeWithInterface;
}());
var newObjEmp = new EmployeeWithInterface("Marwa", 200, 20);
newObjEmp.printData();
