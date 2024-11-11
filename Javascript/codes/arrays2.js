// // // let arr=[1,2,3,4];
// // // arr[0]=10;
// // // console.log(arr); // [10,2,3,4]
// // // arr=90;
// // // console.log(arr); // 90          //-> in this case modification can be done to array

// // // const arr = [1, 2, 3, 4];
// // // arr[0] = 10;
// // // console.log(arr); // [10,2,3,4]

// // // arr = 90; //-< in this case modification can't be done to array
// // // console.log(arr); // [90,

// // //array can contain different data types
// // // let arr = [1, 2, 3, 4, "hello", true,[123]];
// // // console.log(arr);

// // //2d array
// // // brr = [
// // //   [1, 2, 3],
// // //   [4, 5, 6],
// // //   [7, 8, 9],
// // // ];

// // // console.log(brr);

// // //array can contain 2d array with different length
// // // arr = [
// // //   [1, 2, 3],
// // //   [4, 5, 6, 7],
// // //   [8, 9],
// // // ];
// // // console.log(arr);

// // let arr = [1, 2, 3, 4, "hello", true, [123]];
// // console.log(typeof arr);

// // // direct method ->
// // //console.log(arr);

// // //regular for loop

// // // for (let i = 0; i < arr.length; i++) {
// // //   console.log(i,arr[i]);
// // // }

// // //for of loop
// // brr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// // // for (const ele of brr) {
// // //   console.log(ele);
// // // }

// // //slight difference between for and forof
// // //suppose we want to double each element in brr array

// // //->using for loop
// // // console.log(brr);
// // // for (let i = 0; i < brr.length; i++) {
// // //   brr[i] = brr[i] * 2;
// // // }
// // // console.log(brr);

// // //but same thing using forof loop can't be done
// // // for (let ele of brr) {
// // //   ele = ele * 2;
// // //   console.log(ele); //element are doubled but not stored in array
// // // }
// // // console.log(brr);

// // //basically forof loop creates copy of each element in the array and does operation but not store in the array
// // //so forof loop is used when we don't want to modify the original array
// // //one more disadvantage of forof loop is that we can't get the index of the element

// //for each loop still it does modifiy original array like forof loop ,but it can get the index of the element
// // crr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// // //for each loop
// // crr.forEach((element, i) => {
// //   console.log(element, i);
// // });

// arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// arr.forEach((element, index) => {
//   console.log(element, index);
// });

//sum of n natural numbers using forof


