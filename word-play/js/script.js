addEventListener("load", function() {
    const form = document.querySelector("form");
    form.addEventListener("submit", function(ev) {
        ev.preventDefault();
        let longWords = [];
        const sentence = document.getElementById("sentence").value;
        const senArray = sentence.split(" ");
        senArray.forEach(function(sen) {
            if (sen.length >= 3) {
                longWords.push(sen);
            }
        });
        longWords.reverse();
        const newSen = longWords.join(" ");
        const result = document.createElement("p");
        result.innerText = newSen;
        document.body.appendChild(result);

        
    })
});