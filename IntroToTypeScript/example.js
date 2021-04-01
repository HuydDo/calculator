"use strict";
// let example: (number | boolean) [] = [1,2,3,4,5,true]
exports.__esModule = true;
function add(nums) {
    return nums.num1 + nums.num2 + nums.num3 + nums.num4;
}
console.log(add({ num1: 1, num2: 2, num3: 3, num4: 3 }));
