//Literal Object ===> Custom Object

var student = {
    // Key : Value => Number String Char bool array function Object ArrayofObject
    // stdName:"Nawal",
    stdName: "Ali", //OverWrite on Old Value change Nawal to Ali
    birthOfDate: 1988,
    grade: "A",
    GPA: 2.5,
    isGradu: true,
    courses: ["HTML", "CSS", "JS"],
    age: function () {
        return new Date().getFullYear() - student.birthOfDate
    },
    faculty: {
        Name: "FCI",
        UniverSity: "Minia",
        arr:[1,2,3],
        obj:{

        }
    },
    DesCourses: [
        {
            CourseName: "C#",
            CourseDegre: 100
        }, {
            CourseName: "OOP",
            CourseDegre: 70
        }, {
            CourseName: "DB",
            CourseDegre: 90
        }
    ]
}


// console.log(student.stdName)
// console.log(student["birthOfDate"])
// console.log(student.courses)

// for (var item of student.courses) {
//        console.log(item)
// }

// console.log(student.faculty.Name)
// console.log(student.faculty["UniverSity"])
// console.log(student["faculty"]["Name"])
// console.log(student["faculty"].Name)

// console.log(student.faculty.arr)

// console.log(student.DesCourses)
// console.log(student.DesCourses[0].CourseName)

// for (var item of student.DesCourses) {
//         console.log(item.CourseName)
// }

// console.log(student.age())

// var d=new Date()
// d.setFullYear(2019)