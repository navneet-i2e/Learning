// // let a = prompt("Enter the first number");

// // let b = prompt("Enter the second number");
// // let c = parseInt(a) + parseInt(b);
// // console.log(c);

// //above piece of code is simple example  of synchronous actions

// //now talking about asynchronous actions

// //any action that takes time to complete can be considered as asynchronous
// //ex- setTimeout

// // console.log("Start");

// // setTimeout(function () {
// //   console.log("Hello");
// // }, 3000);

// // console.log("End");

// // function loadScript(src, callback) {
// //   var script = document.createElement("script");
// //   script.src = src;
// //   script.onload = function () {
// //     console.log("Loaded src is ", src);
// //     callback(src);
// //   };
// //   document.body.appendChild(script);
// // }
// // function hello(src) {
// //   alert("Hello" + src);
// // }
// // loadScript(
// //   "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js",
// //   hello
// // );

// //pyramid of doom
// // loadScript(
// //   "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js",
// //   function () {
// //     loadScript(
// //       "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js",
// //       function () {
// //         loadScript(
// //           "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.esm.min.js",
// //           function () {
// //             console.log("All scripts are loaded");
// //           }
// //         );
// //       }
// // let promise = new Promise(function (resolve, reject) {
// //   alert("Hello");
// //   resolve(56);
// // });

// // console.log("Hello one");
// // setTimeout(function () {
// //   console.log("Hello two");
// // }, 2000);
// // console.log("Hello three");
// // console.log(promise)

// // let p1 = new Promise((resolve, reject) => {
// //   console.log("Promise 1 is pending...");
// //   setTimeo};ut(() => {
// //     console.log("I am a promise and I am fulfilled!");
// //     resolve("Promise 1 resolved successfully");
// //   }, 3000); // Resolves after 3 seconds
// // });

// // let p2 = new Promise((resolve, reject) => {
// //   console.log("Promise 2 is pending...");
// //   setTimeout(() => {
// //     console.log("I am a promise and I am rejected!");
// //     reject(new Error("Promise 2 rejected with an error"));
// //   }, 5000); // Rejects after 5 seconds
// // });

// // // console.log(p1, p2);

// // p1.then((value) => {
// //   console.log(value);
// // });

// // p2.catch((error) => {
// //   console.error("some error occurred in p2");
// // });

// // let p1 = new Promise((resolve, reject) => {
// //   setTimeout(() => {
// //     console.log("Resolve after 2 seconds");
// //     resolve(56);
// //   }, 2000);
// // });
// // p1.then((value) => {
// //   console.log(value);
// //   let p2 = new Promise((resolve, reject) => {
// //     setTimeout(() => {
// //       resolve("Promise 2");
// //     }, 2000);
// //   });
// //   return p2;
// // }).then((value) => {
// //   console.log("We are done");
// // });

// //load script using promise

// const loadScript = (src) => {
//   return new Promise((resolve, reject) => {
//     let script = document.createElement("script");
//     script.type = "text/javascript";
//     script.src = src;

//     document.body.appendChild(script);
//     script.onload = function () {
//       resolve("Script loaded successfully");
//     };
//     script.onerror = function () {
//       reject(0);
//     };
//   });
// };

// let p1 = loadScript(
//   "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"
// )
//   .then((value) => {
//     console.log(value);
//     return loadScript(
//       "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js"
//     );
//   })
//   .then((value) => {
//     console.log("Second script loaded successfully");
//   })
//   .catch((error) => {
//     console.log("Script cant be loaded");
//   });

//attaching multiple handler to a promise

// let p1 = new Promise((resolve, reject) => {
//   setTimeout(() => {
//     resolve(1);
//     console.log("Congratulations, promise is resolved");
//   });
// });
// let p2 = p1.then((value) => {
//   console.log("Hurray");
//   return new Promise((resolve, reject) => {
//     setTimeout(() => {
//       resolve(2);
//     }, 5000);
//   });
// });
// p2.then((value) => {
//   console.log(value);
// });

//inbuilt promise methods (have to do later)

//async and await concept is used to handle promise
//the concepts states that we can make any function async and use await to handle the promise inside it

async function weather() {
  let noidaWeather = new Promise((resolve, reject) => {
    setTimeout(function () {
      resolve("16 deg");
    }, 2000);
  });
  let udaipurWeather = new Promise((resolve, reject) => {
    setTimeout(function () {
      resolve("20 deg");
    }, 5000);
  });

  // noidaWeather.then(alert);
  // udaipurWeather.then(alert);
  console.log("Weather in Noida is Fetching...");
  let noidaW = await noidaWeather; //wait krta hai jabtk promise fulfill nhi hoti
  console.log("Weather in noida fetched " + noidaW);
  console.log("Weather in Udaipur is Fetching...");
  let udaipurW = await udaipurWeather;
  console.log("Weather in Udaipur fetched " + udaipurW);

  return [noidaW, udaipurW];
}
async function navneet() {
  console.log("Navneet is Waiting for weather...");
}
async function main() {
  console.log("Welcome to weather app");
  let result = await weather();
  console.log(result);
  let result2 = await navneet();
}

main();
