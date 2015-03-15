"use strict";



function getCylinderVolume(getAray) {
    var volume = Math.PI * Math.pow(getAray[0], 2) * getAray[1];
    console.log(volume.toFixed(3));
}

getCylinderVolume([2, 4]);      // 50.265
getCylinderVolume([5, 8]);      // 628.319
getCylinderVolume([12, 3]);     // 1357.168