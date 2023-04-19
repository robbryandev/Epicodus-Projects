let text = "one two two three three three four four four four";


function checkAgainst (stringInput) {
  let textArray = stringInput.split(" ");
  let pushArray = [];
  let ranArray = [];
  textArray.forEach(function(wordIn){
    let wordCount = 0;
    if (!ranArray.includes(wordIn)) {    
      ranArray.push(wordIn);  
      textArray.forEach(function(wordThrough) {
        if (wordIn === wordThrough) {
          wordCount++;
        }
      });
      pushArray.push([wordIn, wordCount])
    }
  });
  return pushArray;
};

console.log(checkAgainst(text));