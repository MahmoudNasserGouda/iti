import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'converBorder'
})
export class ConverBorderPipe implements PipeTransform {

  transform(value: string): string {
    return "| " + value + " |";
  }
}
