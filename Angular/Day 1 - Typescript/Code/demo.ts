console.log("Hello world to type script started");

//data type
// Number , String , Boolean, any , void , array , object

var num1:Number = 20;
//num1 = 0b101;
//num1 = "Abc";
console.log(num1);

var str:string = "Hello";
str+=" World";
str = `New String : ${num1}`;
console.log(str);

var newBool:boolean = false;
console.log(newBool);

var person= 
{
    name : "Ali",
    age : 20
}
console.log(`Name : ${person.name}, age : ${person.age}`);


var arr:string[];
arr = ["new start", "new end"];
console.log(arr);

var arr2:Array<Number> = [1,2,3,4,5];
console.log(arr2);


//tuple
var tupleNew:[Number,string, boolean, string[]];
tupleNew = [12, "Hello", true, ["start","End"]];
console.log(tupleNew);

//union
var unionNew :(string | number);
unionNew = "New Union";
console.log(unionNew);

var union2 : string | number | boolean;
union2=true;


var unionArr: (string | number)[];
unionArr = [1,"hello", 34, 21, "text"];
console.log(unionArr);


var unionTest: string | string[];
unionTest=["1","2"];

var unionArr2: number[] | string[];
unionArr2= [1,2,3,4];
unionArr2=["1","2","3"];
console.log(unionArr2);


var testAny : any[];
testAny = [1,2,"ah",true];
console.log(testAny);



var newPerson = 
{
    name:"ali",
    age:30,
    print: function(){}
}
newPerson.print = function() {
    console.log(newPerson);
    
}

newPerson.print();


//enum
enum Role {
    Admin = "admin",
    User = "user"
}


enum DayWeek{
    sat,
    sun,
    mon,
    tues,
    wed,
    thurs,
    fri
}


function funName(x:(string | number))
{
    if(typeof(x)==="number")
    {
        console.log(x);
    }
    else if (typeof(x)==="string")
    {
        console.log(x);
    }
}
funName(2);


function subNumbers (num1: number, num2: number) : number
{
    return num1+num2;
}
console.log(subNumbers(2,10));


function sayHello(name:string) : void
{
    console.log(`Hello ${name}`);
    
}
sayHello("Asmaa");


function sum(num1:number, num2:number=3):number
{
    return num1+num2;
}
console.log(sum(2,5));


function sumWithOptionally(num1:number, num2:number, num3?:number):number
{
    if(num3 == undefined)
    {
        return num1+num2;
    }
    else
    {
        return num1 + num2 + num3;
    }
}
console.log(sumWithOptionally(1,2,3));


function sumWithArray(arr:number[])
{
    var sum:number=0;
    for(let i=0; i<arr.length;i++)
    {
        sum+= arr[i];
    }
    console.log(`Sum = ${sum}`);
    
}
sumWithArray([1,2,3,4]);


function sumArrayvalues(...arr:number[]):void 
{
    var sum:number=0;
    for(let i=0; i<arr.length;i++)
    {
        sum+= arr[i];
    }
    console.log(`Sum = ${sum}`);
}

sumArrayvalues(1,2,3,4);


var res = function ()
{
    return "Hello Anoymous Function";
}
console.log(res());


var sumNum = (num:number) => 10 + num;
console.log(sumNum(30));

var res2 = ()=> {console.log("testing");}
res2();

var res3 = num1 => {console.log(`the result three : ${num1}`);}
res3(true);


function funOverloadTest(str:string):void;
function funOverloadTest(num:number):void;
function funOverloadTest(num:number,str:string):void;
function funOverloadTest(num1:number, num2:number, num3:number):void;

function funOverloadTest(x:string|number, y?:string|number, z?:number)
{
    if(y!=undefined)
    {
        console.log(y);
    }
    if(z!=undefined)
    {
        console.log(z);
    }
}
funOverloadTest(3,4,3);









