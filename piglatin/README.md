Describe: toPigLatin();

Test: "Starts with a number"
Code: toPigLatin("30test");
Expected Output: "30test"

Test: "Input not a string"
Code: toPigLatin(30);
Expected Output: "30"

Test: "It recognizes a single character."
Code: toPigLatin("b");
Expected Output: "b"

Test: "It recognizes a single vowel."
Code: toPigLatin("a");
Expected Output: "ayay"

Test: "Word that starts with constinant"
Code: toPigLatin("bag");
Expected Output: "agbay"

Test: "Word that starts with a vowel"
Code: toPigLatin("ant");
Expected Output: "antyay"

