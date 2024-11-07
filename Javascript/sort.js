let arr = [1, 4, 2, 3, 6, 8, 9, 7, 10, 5];
console.log(arr);

//by using comparator function we can sort in descending/ascending order numerically

// arr = arr.sort((a, b) => b - a); //arrow function implicitly returns the result
// console.log(arr); //descending order
// arr = arr.sort((a, b) => a - b);
// console.log(arr); //ascending order

// arr = arr.sort((a, b) => {
//   return b - a; //return word is necessary in this case to return the result
// });
// console.log(arr);

arr = arr.sort();
console.log(arr); //lexicographically sort ho jayega naki numerically in short galat sort deta hai

let brr = [1, -8, -5, 6];
brr = brr.sort((a, b) => Math.abs(a) - Math.abs(b)); //irrespective of sign, sort in ascending order
console.log(brr);
