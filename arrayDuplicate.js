// https://codippa.com/how-to-check-if-array-contains-duplicate-values-in-javascript/
// Method 1 Using an Object
// checkDuplicate();
   function checkDuplicate() {
      let arr = ["abc","xy","bb", "axz", "abc"];
      // empty object
      let map = {};
      let result = false;
      for(let i = 0; i < arr.length; i++) {
         // check if object contains entry with this element as key
         if(map[arr[i]]) {
            result = true;
            // terminate the loop
            break;
         }
         // add entry in object with the element as key
         map[arr[i]] = true;
      }
      if(result) {
         console.log('Array contains duplicate elements');
      } else {
         console.log('Array does not contain duplicate elements');
      }
   }

   //Method 2 Using a Set
   checkDuplicate2();
   function checkDuplicate2() {
      let arr = ["abc","xy","bb", "abc"];
      let result = false;
      // create a Set with array elements
      const s = new Set(arr);
      // compare the size of array and Set
      if(arr.length !== s.size){
         result = true;
      }
      if(result) {
         console.log('Array contains duplicate elements');
      } else {
         console.log('Array does not contain duplicate elements');
      }
   }