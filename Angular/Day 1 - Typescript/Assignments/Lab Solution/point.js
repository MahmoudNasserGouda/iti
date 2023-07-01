var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//P2
var Vector2 = /** @class */ (function () {
    function Vector2(x, y) {
        this._x = 0;
        this._y = 0;
        this._x = x;
        this._y = y;
        this.calculateLength();
    }
    Vector2.prototype.calculateLength = function () {
        this.length = Math.sqrt(this._x * 2 + this._y * 2);
    };
    return Vector2;
}());
//P3
var vector3 = /** @class */ (function (_super) {
    __extends(vector3, _super);
    function vector3(x, y, z) {
        var _this = _super.call(this, x, y) || this;
        _this._z = 0;
        _this._z = z;
        return _this;
    }
    vector3.prototype.calculateLength = function () {
        var xx = Math.sqrt(this._x * 2 + this._y * 2 + this._z * 2);
        return xx;
    };
    return vector3;
}(Vector2));
var v = new Vector2(1, 1);
console.log(v.length);
var v2 = new vector3(1, 2, 1);
console.log(v2.calculateLength());
;
var kvProcessor = /** @class */ (function () {
    function kvProcessor() {
    }
    kvProcessor.prototype.process = function (key, val) {
        console.log("Key = " + key + ", val = " + val);
    };
    return kvProcessor;
}());
var proc = new kvProcessor();
proc.process(1, 'Bill'); //Output: processKeyPairs: key = 1, value = Bill
