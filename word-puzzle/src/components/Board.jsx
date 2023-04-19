import { Component } from "react";
import "../styles/Board.css"
import {connect} from "react-redux"
import WordInput from "./WordInput";
import GuessList from "./GuessList";
import { newWord } from "../reducers/WordReducer";

class Board extends Component {
    render() {
        const {dispatch} = this.props
        const NEW_WORD = () => {
            const randWord = this.props.word.words[Math.floor(Math.random() * this.props.word.words.length - 1)]
            dispatch(newWord(randWord))
        }
        if (this.props.word.currentWord.length === 0) {
            NEW_WORD()
        }
        return (
            <div className="board">
                <div className="parent">
                    <WordInput/>
                    <GuessList/>
                </div>
            </div>
        )
    }
}

const mapStateToProps = (state) => {
    return {
        word: state.word
    }
}

export default connect(mapStateToProps)(Board)