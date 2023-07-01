//P2
class Vector2 {
     _x = 0;
     _y = 0;
   length:number;
  
     calculateLength() {
        this.length = Math.sqrt(this._x * 2 + this._y * 2);
    }
  
    constructor(x: number, y: number) {
        this._x = x;
        this._y = y;
        this.calculateLength();
    }
 }


 //P3
  class vector3 extends Vector2{
      private _z = 0;
      constructor(x: number, y: number,z:number){
      super(x,y);
        this._z=z;
      }
       calculateLength() {
      let xx = Math.sqrt(this._x * 2 + this._y * 2 + this._z *2);
      return xx;
    }
  }
 const v = new Vector2(1, 1);
  
 console.log(v.length);
const v2=new vector3(1,2,1);
console.log(v2.calculateLength());

//P4

// Generic Class implements Generic Interface
interface IKeyValueProcessor<T, U>
{
    process(key: T, val: U): void;
};

class kvProcessor<T, U> implements IKeyValueProcessor<T, U>
{ 
    process(key:T, val:U):void { 
        console.log(`Key = ${key}, val = ${val}`);
    }
}

let proc: IKeyValueProcessor<number, string> = new kvProcessor();
proc.process(1, 'Bill'); //Output: processKeyPairs: key = 1, value = Bill