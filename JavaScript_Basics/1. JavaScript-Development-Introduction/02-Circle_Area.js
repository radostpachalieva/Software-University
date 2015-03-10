// First Solution
var pi = Math.PI;
function calcCircleArea(r) {
    return pi * Math.pow(r, 2);
}
document.writeln("r = 7; " + "area = " + calcCircleArea(7) + "<br>");
document.writeln("r = 1.5; " + "area = " + calcCircleArea(1.5) + "<br>");
document.writeln("r = 20; " + "area = " + calcCircleArea(20) + "<br>");

// Second Solution
function calculate() {
    var RADIUSINPUT = document.CircleArea.RADIUS.value;
    var CALC1 = Math.pow(RADIUSINPUT, 2);
    var CALC2 = pi*CALC1;
    document.CircleArea.AREA.value = CALC2;
}
