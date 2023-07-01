import { Circle, IShape, Rectangle } from "./Shapes";

function drawShapes(Shapes : IShape[]): void {
    for(let shape of Shapes) {
        shape.draw();
    }
}

let myShape:IShape[] = [new Circle(), new Rectangle()];
drawShapes(myShape);