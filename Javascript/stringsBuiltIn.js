// let str = " Navneet Anand ";
// console.log(str.length);
// console.log(str);
// //to print string with uppercase letters
// console.log(str.toUpperCase());
// //to print string with lowercase letters
// console.log(str.toLowerCase());
// //these above function will not change the original string

// //to remove extra spaces in string
// let str2 = str.trim();
// console.log(str2);
// console.log(str2.length); //not remove middle spaces only front and back

// //to check index of particular character
// console.log(str.indexOf("N"));
// console.log(str2.lastIndexOf("a"));

// //to check char at particular index
// console.log(str2.charAt(8));
// console.log(str2[8]);

// let s = "NavneetAnand";

// console.log(s.slice(5))  //returns substring from 0 to end
// console.log(s.slice(2,6))//return substring from index i to j-1
// //again original string will not change

let str = "Navneet Anand is a student at Techno NJR";
console.log(str); //return
//to contain each words of string in a array
let arr = str.split(" ");
console.log(arr);
for (let ele of arr) {
  console.log(ele);
}

let str2="a,b,c,d,e,f,g,h,i,j,k";
console.log(str2); //return
let arr2=str2.split(',');
for(let ele of arr2)
{
    console.log(ele)
}
