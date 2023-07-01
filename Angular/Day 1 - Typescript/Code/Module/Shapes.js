define(["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Rectangle = exports.Circle = void 0;
    var Circle = /** @class */ (function () {
        function Circle() {
        }
        Circle.prototype.draw = function () {
            console.log("Draw circle");
        };
        return Circle;
    }());
    exports.Circle = Circle;
    var Rectangle = /** @class */ (function () {
        function Rectangle() {
        }
        Rectangle.prototype.draw = function () {
            console.log("Draw rectangle");
        };
        return Rectangle;
    }());
    exports.Rectangle = Rectangle;
});
