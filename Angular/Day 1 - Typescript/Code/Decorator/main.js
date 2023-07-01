var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var changeValue = function (value) { return function (target, propertyKey) {
    Object.defineProperty(target, propertyKey, { value: value });
}; };
var Test = /** @class */ (function () {
    function Test() {
        this.num = 40;
    }
    __decorate([
        changeValue(200)
    ], Test.prototype, "num", void 0);
    return Test;
}());
var test = new Test();
console.log(test.num);
