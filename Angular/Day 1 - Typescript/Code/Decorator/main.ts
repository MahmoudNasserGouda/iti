const changeValue = (value) => (target:Object, propertyKey:string) =>
{
    Object.defineProperty(target,propertyKey, {value});
}

class Test 
{
    @changeValue(200)
    num = 40;
}

const test = new Test();
console.log(test.num);


