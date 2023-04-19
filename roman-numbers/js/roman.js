function getRoman(num) {
    let result = 0;
    switch (num) {
        case "i":
            result = 1;
            break;
        case "v":
            result = 5;
            break;
        case "x":
            result = 10;
            break;
        case "l":
            result = 50;
            break;
        case "c":
            result = 100;
            break;
        case "d":
            result = 500;
            break;
        case "m":
            result = 1000;
            break;
    }
    return result;
}

String.prototype.romanToInt = function() {
    const romanPattern = new RegExp("[ivxlcdm]", "gi");
    const romanChars = this.match(romanPattern);
    let result = 0;
    for (let i = romanChars.length - 1; i > -1; i--) {
        console.log(`val: ${romanChars[i]}`);
        console.log(`to: ${getRoman(romanChars[i])}`);
        if (i === romanChars.length - 1) {
            result = getRoman(romanChars[i]);
        } else {
            let tmpNum = getRoman(romanChars[i]);
            if (tmpNum >= getRoman(romanChars[romanChars.length - 1])) {
                result += tmpNum;
            } else {
                result -= tmpNum;
            }
        }
    }
    return result;
}