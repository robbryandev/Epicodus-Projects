class Entry {
  constructor(title, body) {
    this.title = title;
    this.body = body;
  }

  setTitle(value) {
    this.title = value;
  }

  setBody(value) {
    this.body = value;
  }

  wordCount() {
    const pattern = new RegExp("\\b\\S+\\b", "gi");
    const ittr = [...this.body.matchAll(pattern)];
    return ittr.length;
  }

  vowelCount() {
    const vowels = new RegExp("[aeiou]", "gi");
    const vCount = [...this.body.matchAll(vowels)];
    return vCount.length;
  }

  consonantCount() {
    const letterPattern = new RegExp("[a-z]", "gi");
    const letterArray = [...this.body.matchAll(letterPattern)];
    const consPattern = new RegExp("[^aeiou]", "gi");
    const consArray = [...letterArray.join("").matchAll(consPattern)];
    return consArray.length;
  }

  getTeaser() {
    const punctPattern = new RegExp("[!\\?\\.]");
    const sentence = this.body.split(punctPattern)[0];
    const words = sentence.split(" ");
    if (words.length <= 8) {
      return sentence + "."
    } else {
      return words.splice(0, 7).join(" ") + "...";
    }
  }
}

let test = new Entry("My Day", "Today was a super bad terrible awful day, and I hope I'll never have to think about it again!")

console.log(test.getTeaser())

export default Entry;