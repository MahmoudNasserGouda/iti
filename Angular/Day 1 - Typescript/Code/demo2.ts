function getArray(items:any[]):any[]
{
    return new Array().concat(items);
}
var numberValues = getArray([1,2,3,4]);
var stringValues = getArray(["First", "Second", "Third", "Fourth"]);
console.log(numberValues);

stringValues.push(2);
console.log(stringValues);


//generic
function getArray2<T> (items:T[]): T[]
{
    return new Array().concat(items);
}

var numberForGetArray = getArray2<number>([1,2,3,4]);
console.log(numberForGetArray);


class Employee 
{
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
    constructor(private name:string, private id:number)
    {

    }
    calSalary():number
    {
        return 3000;
    }
    print()
    {
        console.log(`Employee Name : ${this.name} , ID : ${this.id}`);
        
    }
}

var emp = new Employee("Ali",12);
console.log(emp.calSalary());
emp.print();


interface User 
{
    name : string,
    id : number
}

let user:User = 
{
    name : "Mostafa",
    id : 100
}
console.log(user.name);
console.log(user.id);


interface IPerson {
    name : string,
    printData(): void;
}
interface IEmployee extends IPerson 
{
    empID : number
}

class EmployeeWithInterface implements IEmployee
{
    constructor(public name : string, public empID:number, public empAge:number)
    {
        
    }
    printData(): void {
        console.log(`Employee Name : ${this.name}, ID = ${this.empID}`);
        
    }
}
var newObjEmp = new EmployeeWithInterface ("Marwa", 200, 20);
newObjEmp.printData();






