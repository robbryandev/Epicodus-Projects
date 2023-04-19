function newSuit(suit) {
    let nums = [1,2,3,4,5,6,7,8,9,10,11,12,13];
    let res = [];
    nums.forEach(function(num) {
        let card = num;
        if (num === 1) {
            card = "Ace";
        } else if (num === 11) {
            card = "Jack";
        } else if (num === 12) {
            card = "Queen";
        } else if (num === 13) {
            card = "King";
        }
        res.push(`${card} of ${suit}`);
    });
    return res;
}

addEventListener("load", function() {
    let cards = [];
    const suits = ["hearts", "spades", "clubs", "diamonds"];
    suits.forEach(function(suit) {
        let nSuit = newSuit(suit);
        nSuit.forEach(function(nc) {
            cards.push(nc);
        });
    });
    let ul = document.createElement("ul");
    cards.forEach(function(cardLi) {
        let li = document.createElement("li");
        li.innerText = cardLi;
        ul.appendChild(li);
    })
    document.body.appendChild(ul);
})