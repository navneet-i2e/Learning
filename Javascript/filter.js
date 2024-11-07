function toEven(ele) {
  return ele % 2 == 0;
}

let arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
console.log(arr);

let brr = arr.filter(toEven);

console.log(brr);

let crr = arr.filter(function (ele) {
  return ele % 2 != 0;
});
console.log(crr);

let drr = arr.filter((ele) => {
  return ele > 5;
});
console.log(drr);

let err = arr.filter((ele) => ele < 5);
console.log(err);
