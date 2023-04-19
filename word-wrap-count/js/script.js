// [{"word": "hello", "count": 1}, {"word": "world", "count": 2}]

function wordExists(arrayVar, wordVar) {
    let res = false;
    arrayVar.forEach(function(val) {
        if (val.word === wordVar) {
            res = true;
        }
    })
    return res;
}

function wordInc(arrayVar, wordVar) {
    arrayVar.forEach(function(val) {
        if (val.word === wordVar) {
            val.count++;
        }
    })
}

addEventListener("load", function(){
    const form = document.querySelector("form");
    form.addEventListener("submit", function(ev) {
        ev.preventDefault();
        let words = [];
        const input = document.getElementById("words").value.split(" ");
        input.forEach(function(word) {
            if (!wordExists(words, word)) {
                words.push({"word": word, "count": 1});
            } else {
                wordInc(words, word);
            }
        });
        let ul = document.createElement("ul");
        words.forEach(function(wordListItem) {
            let li = document.createElement("li");
            li.innerText = `- ${wordListItem.word} ${wordListItem.count}`;
            ul.appendChild(li);
        });
        document.body.appendChild(ul);
    })
})