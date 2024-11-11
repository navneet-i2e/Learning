function OnetoN(n) {
  for (var i = 1; i <= n; i++) {
    console.log(i);
  }
}
OnetoN(10);

function sum(n) {
  let sum = 0;
  for (let i = 1; i <= n; i++) {
    sum += i;
  }
  return sum;
}
console.log(sum(10));

function eqn(a, b) {
  return a * a*a + b *b*b;
}
console.log(eqn(Math.abs(-2), 3));
