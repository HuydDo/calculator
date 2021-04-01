// let example: (number | boolean) [] = [1,2,3,4,5,true]

// let example: any[] = [1,2,3,4,5,true]
// example = ''

// let example: any[] = [1,2,3,4,5];

// let example: string = '';
// example.map((element) => {
//   // console.log( element + 1)
//   return ( element + 1)
// })


// function add(num1: number, num2: number): string {
//   return (num1 + num2).toString();
// }

// @ts-check

// function add(num1, num2) {
//   let y = 5;
//   y.map((element) => {
//     return true;
//   })

//   return (num1 + num2).toString();
// }

// import { NumsEnum} from './example.enum'
// function add(num1: NumsEnum, num2: NumsEnum): number {
//   return num1 + num2;
// }
// console.log(add(NumsEnum.Num1, NumsEnum.Num2))

// import { NumsEnum} from './example.enum'

// type numExample = {num1: number, num2: number};

// function add(nums: numExample): number {
//   return nums.num1 + nums.num2;
// }
// console.log(add({num1: 1, num2: 2}))

import { NumsEnum} from './example.enum'
import { INumsExample } from './num.Example.interface'

type numExample = {num1: number, num2: number};
type insection = INumsExample & numExample;

function add(nums: insection): number {
  return nums.num1 + nums.num2 + nums.num3 + nums.num4;
}

console.log(add({num1: 1, num2: 2, num3: 3, num4: 3}))
