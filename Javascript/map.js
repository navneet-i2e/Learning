//it is the topic of array

//Map basically agar mujhe array se ek aur array banana hai usise related with some specific changes
function twice(ele) {
  return ele * 2;
}
function thrice(ele) {
  return ele * 3;
}
function square(ele) {
  return ele * ele;
}
function add10(ele) {
  return ele + 10;
}
let arr = [12, -13, -24, -45];

console.log(arr);
let brr = arr.map(add10); //map ke andar ek callback function pass karenge
let crr = arr.map(function (ele) {
  //andar bhi define kr skte

  return ele - 2;
});
let drr = arr.map(function cube(ele) {
  return ele ** 3;
});

let err = arr.map((ele) => {
  return Math.abs(ele); //arrow function
});

console.log(brr);
console.log(crr);
console.log(drr);
console.log(err);
//to transform given array to something
arr = arr.map((ele) => {
  return ele * 10;
});
arr = arr.map((ele) => ele ** 5);

console.log(arr);
console.log(arr);
