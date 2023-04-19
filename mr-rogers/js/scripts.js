// Buisiness logic

// Classes

// ReplaceObject class contains a number array with numbers marked for replacement.
// A string array with strings used to replace the corresponding number in the number array.
// And a method to validate if both arrays have the same length.
class ReplaceObject {
  constructor(numArray, strArray) {
    this.numArray = numArray.map(function (num) {
      return Number(num);
    });
    this.strArray = strArray.map(function (str) {
      return String(str);
    });
  }

  isValid() {
    return this.numArray.length === this.strArray.length;
  }
}

// RogerArray class takes an array of numbers.
// A ReplaceObject containing the rules for how the numbers should be replaced.
// And a replace method to conditionally replace numbers in the number array with strings provided.
class RogerArray {
  constructor(numCountArray, repObject) {
    this.numCountArray = numCountArray.map(function (num) {
      return Number(num);
    });
    this.repObject = typeof repObject === "object" ? repObject : new ReplaceObject([0], [""]);
  }
}

RogerArray.prototype.replace = function() {
  let self = this;
  let res = [];
  this.numCountArray.forEach(function (num) {
    const rep = self.repObject;
    let replaced = false;
    for (let i = rep.numArray.length - 1; i >= 0; i--) {
      if (`${num}`.includes(`${rep.numArray[i]}`) && !replaced) {
        replaced = true;
        res.push(rep.strArray[i]);
      }
    }
    if (!replaced) {
      res.push(num);
    }
  });
  return res;
};

// Methods for Standard objects

// String method that returns provided string as a number or 0 instead of NaN
String.prototype.parseInt = function() {
  return !Number(this.trim()) ? 0 : parseInt(this.trim());
};

// Number method that gets an array from 0 to the number provided
Number.prototype.countArray = function() {
  let res = [];
  for (let i = 0; i <= this; i++) {
    res.push(i);
  }
  return res.length > 0 ? res : [0];
};

// Number method that uses the provided number as a max for Math.random
Number.prototype.random = function() {
  return Math.floor(Math.random() * this);
}

// User interface logic

// HtmlInputElement Method that returns an expanded number array with string replacements
HTMLInputElement.prototype.getTextArray = function(userName = "") {
  const numReplace = [1, 2, 3];
  let question;
  if (userName) {
    question = `Won't you be my neighbor, ${userName}?`
  } else {
    question = "Won't you be my neighbor?"
  }
  const strReplace = ["Beep!", "Boop!", question];
  const replaceVar = new ReplaceObject(numReplace, strReplace);
  return replaceVar.isValid() ? new RogerArray(this.value.parseInt().countArray(), replaceVar).replace() : null;
}

// HtmlDivElement Method that removes add child elements

HTMLDivElement.prototype.removeChildAll = function() {
  while (this.lastChild) {
    this.removeChild(this.lastChild);
  }
}

// handle form submission
function submitForm(event) {
  event.preventDefault();
  const formNum = document.getElementById("user-number");
  const resElement = document.querySelector(".results");
  const reversed = document.getElementById("reverse-box").checked;
  resElement.removeChildAll();
  let textArray = formNum.getTextArray(document.getElementById("user-name").value);
  if (reversed) {
    textArray.reverse();  
  }
  if (textArray) {
    textArray.forEach(function(val) {
      let word = document.createElement("li");
      word.setAttribute("class", "list-group-item w-75 m-auto");
      word.innerText = val;
      resElement.appendChild(word);
    });
  }
}

// Page load
addEventListener("load", function() {
  document.querySelector("form").addEventListener("submit", function(event) {
    event.preventDefault();
  });
  document.getElementById("btn-submit").addEventListener("click", submitForm)
  document.getElementById("btn-rand").addEventListener("click", function() {
    const max = 100;
    document.getElementById("user-number").value = max.random();
    document.querySelector(".results").removeChildAll();
  });
  document.getElementById("user-number").addEventListener("change", function() {
    document.querySelector(".results").removeChildAll();
  });
  document.getElementById("btn-reset").addEventListener("click", function() {
    document.querySelector(".results").removeChildAll();
  });
});
