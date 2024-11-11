//write a code to generate random numbers between 0 and 9 (included)
let x = Math.floor(Math.random() * 10);
console.log(x);
//write a code to generate random integer between 0 and 10 (included)
let num = Math.floor(Math.random() * 11);
console.log(num);

//write a code to generate random integer between -10 and 10 (included)
let num2 = Math.floor(Math.random() * 21 - 10);
console.log(num2);

//Math.random() return value fro 0 to 1 and in which 0 is inclusive and 1 is exclusive
//so according to question if we multiply it by 21 its range will become 0 to 21 and 21 is excluse
//so subtracting -10 from both will give range -10 to 11 and 11 is inclusive
//therefor we will get our desired range i.e -10 to 10 (inclusive)

//Math.random can work with if-else

if (Math.random() < 0.5) {
  console.log("Heads");
} else console.log("Tails");