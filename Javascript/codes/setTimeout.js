// function hello() {
//   console.log("Hello World");
// }
// function mello() {
//   console.log("mello");
// }

// setTimeout(hello, 2 * 1000);
// setTimeout(mello, 1 * 1000);

// //run button dabane k baad jiska time kam hoga voh pehele chalega

// setTimeout(function () {
//   console.log("Hello World");
// }, 3 * 1000);

for (let i = 1; i <= 10; i++) {
  setTimeout(function () {
    console.log(Math.random());
  }, i * 2000);
}
