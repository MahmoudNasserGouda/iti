define(["require", "exports", "./Shapes"], function (require, exports, Shapes_1) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    function drawShapes(Shapes) {
        for (var _i = 0, Shapes_2 = Shapes; _i < Shapes_2.length; _i++) {
            var shape = Shapes_2[_i];
            shape.draw();
        }
    }
    var myShape = [new Shapes_1.Circle(), new Shapes_1.Rectangle()];
    drawShapes(myShape);
});
