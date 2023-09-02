var x = 2;
var y1 = 0,
  y2 = 0;
var a = 8;
for (var i = 0; i < a; i++) {
  y1 += x;
}
for (var j = 0; j < x; j++) {
  for (var i = 0; i < a; i++) {
    y2 += 1;
  }
}
console.log(y1);
console.log(y2);
