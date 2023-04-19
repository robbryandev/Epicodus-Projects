# [Mr. Roger's Neighborhood](https://robbryandev.github.io/mr-rogers)

## Contributors

* Robert Bryan

## Description

A simple web app that creates a number list from x to y. and replacing the the number with a string based on the number contained inside.

## Technologies Used

* HTML
* CSS
* JS
* BOOTSTRAP

## Setup

Just download this repo and open up index.html in your browser of choice.

## Known bugs

* None

## Tests

#### RogerArray.prototype.replace()

```
Test: Check if a number returns desired array replacements
Code:
  const num = 5;
  const numReplace = [1, 2, 3];
  const strReplace = ["Beep!", "Boop!", "Won't you be my neighbor?"];
  const replaceValues = new ReplaceObject(numReplace, strReplace);
  const rogers = new RogerArray(num.countArray(), replaceValues);
  rogers.replace();
Expected Output: [0, "Beep!", "Boop!", "Won't you be my neighbor?", 4, 5]
```

```
Test: Check if replace order breaks with numbers higher than 10
Code:
  const num = 14;
  const numReplace = [1, 2, 3];
  const strReplace = ["Beep!", "Boop!", "Won't you be my neighbor?"];
  const replaceValues = new ReplaceObject(numReplace, strReplace);
  const Rogers = new RogerArray(num.countArray(), replaceValues);
  Rogers.replace();
Expected Output: [0, "Beep!", "Boop!", "Won't you be my neighbor?", 4, 5, 6, 7, 8, 9, "Beep!", "Beep!", "Boop!", "Won't you be my neighbor?", "Beep!"]
```

#### ReplaceObject.prototype.isValid()

```
Test: Check if a valid ReplaceObject passes
Code:
  const numReplace = [1, 2, 3];
  const strReplace = ["Beep!", "Boop!", "Won't you be my neighbor?"];
  const replaceValues = new ReplaceObject(numReplace, strReplace);
  replaceValues.isValid();
Expected Output: true
```

```
Test: Check if an invalid ReplaceObject passes
Code:
  const numReplace = [1, 2];
  const strReplace = ["Beep!", "Boop!", "Won't you be my neighbor?"];
  const replaceValues = new ReplaceObject(numReplace, strReplace);
  replaceValues.isValid();
Expected Output: false
```

#### String.prototype.parseInt()

```
Test: Check if a number in a string returns a number
Code:
  const test = "5";
  test.parseInt();
Expected Output: 5
```

```
Test: Check if a string returns 0 for a NaN string
Code:
  const test = "abc";
  test.parseInt();
Expected Output: 0;
```

## License info

MIT License

Copyright (c) 2022 Robert Bryan

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.