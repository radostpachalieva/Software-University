"use strict";

var knownValues = [2, 5, -3];       //X1 = -3 and X2 = 0.5
//var knownValues = [2, -4, 2];       // X = 1
//var knownValues = [4, 2, 1];        // No real roots

var a = knownValues[0];
var b = knownValues[1];
var c = knownValues[2];

var discriminant = Math.pow(b, 2) - 4 * a * c;
var x1 = (-b + Math.sqrt(discriminant)) / (2 * a);
var x2 = (-b - Math.sqrt(discriminant)) / (2 * a);

if (discriminant > 0) {
    console.log("X1 = " + x1 + "\n" + "X2 = " + x2);
} else if (discriminant === 0) {
    console.log("X = " + x1);
} else {
    console.log("No real roots");
}