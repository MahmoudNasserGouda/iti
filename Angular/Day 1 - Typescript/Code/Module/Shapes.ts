export interface IShape 
{
    draw:() => void;
}

export class Circle implements IShape
{
    draw() {
        console.log("Draw circle");  
    }  
} 
export class Rectangle implements IShape
{
    draw() {
        console.log("Draw rectangle");  
    }  
}