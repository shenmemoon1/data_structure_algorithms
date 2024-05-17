/**
 * @param {number} x
 * @return {number}
 */
var reverse = function (x) {
  const MAX_INT = Math.pow(2, 31) - 1;
  const MIN_INT = Math.pow(-2, 31);
  let res = Math.abs(x).toString().split("").reverse().join("") * Math.sign(x);
  return res <= MAX_INT && res >= MIN_INT ? res : 0;
};

let x = -123;

console.log(reverse(x));
