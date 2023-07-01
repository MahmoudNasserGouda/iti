import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'converSpace'
})
export class ConverSpacePipe implements PipeTransform {

  transform(value:string, charcter:string): string {
    return value.replace(charcter,' @ ');
  }

}
