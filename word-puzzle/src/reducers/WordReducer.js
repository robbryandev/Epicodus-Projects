import { createSlice } from "@reduxjs/toolkit";
import wordJson from "../assets/new_words.json";

const WordSlice = createSlice({
    name: "word",
    initialState: {
        currentWord: [],
        wordInput: "",
        words: [...wordJson.words],
        guess: 0,
        guessList: [],
        won: false
    },
    reducers: {
        setInput(state, action) {
            state.wordInput = action.payload
        },
        newWord(state, action) {
            state.currentWord = action.payload.toLowerCase().split("")
        },
        addGuess(state) {
            state.guess++
        },
        resetGuess(state) {
            state.guess = 0
            state.won = false
            state.guessList = []
            state.currentWord = []
        },
        newGuess(state, action) {
            const actionGuess = action.payload.toLowerCase().split("")
            let thisGuess = []
            for (let i = 0; i < actionGuess.length; i++) {
                if (actionGuess[i] === state.currentWord[i]) {
                    thisGuess.push({
                        letter: actionGuess[i],
                        status: "match"
                    })
                } else if (state.currentWord.includes(actionGuess[i])) {
                    thisGuess.push({
                        letter: actionGuess[i],
                        status: "exist"
                    })
                } else {
                    thisGuess.push({
                        letter: actionGuess[i],
                        status: "none"
                    })
                }
            }
            console.log(thisGuess)
            state.guessList.push(thisGuess)
        },
        checkWin(state) {
            const lastGuess = state.guessList[state.guessList.length - 1]
            state.won = lastGuess.filter(ch => ch.status !== "match").length === 0
        }
    }
})

export const { setInput, newWord, addGuess, resetGuess, newGuess, checkWin } = WordSlice.actions
export default WordSlice