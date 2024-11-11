let arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
console.log(arr);
//isme bhi vhi 4 tarike use kr skte hai
let brr = arr.reduce((a, b) => a + b);
console.log(brr);
let crr = arr.reduce((a, b) => a * b);
console.log(crr);
