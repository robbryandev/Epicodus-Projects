import { Component } from "react";
import { connect } from "react-redux";
import "../styles/WordInput.css";
import {addGuess, newGuess, checkWin, resetGuess, setInput} from "../reducers/WordReducer"

class WordInput extends Component {
    render() {
        const {dispatch} = this.props
        const handleSubmit = (event) => {
            event.preventDefault()
            const currentGuess = this.props.word.wordInput;
            if (this.props.word.guess < 6) {
                console.log(this.props.word.won)
                dispatch(newGuess(currentGuess))
                dispatch(setInput(""))
                dispatch(addGuess())
                dispatch(checkWin())
            } else {
                dispatch(setInput(""))
                dispatch(resetGuess())
            }
        }
        const handleChange = (event) => {
            dispatch(setInput(event.target.value))
        }
        return(
            <>
                <form onSubmit={handleSubmit} className="word-input">
                    {
                        this.props.word.guess < 6 && !this.props.word.won ? (
                            <>                            
                                <input type="text" pattern="[a-zA-Z]{6}" 
                                maxLength={"6"} className="input" 
                                spellCheck="false" disabled={false} value={this.props.word.wordInput}
                                onChange={ev => handleChange(ev)} required/>
                                <button type="submit" className="submit">Guess</button>
                                <pre className="tries-left">{6 - this.props.word.guess} Tries left</pre>
                            </>
                        ) : (
                            <>
                                <input type="text" maxLength={"6"}
                                 className="input"  disabled={true}
                                value={
                                    this.props.word.won ? "You won" : "You lose"
                                } required/>
                                <button type="submit" className="submit">Play Again</button>
                            </>
                        )
                    }
                </form>
            </>
        )
    }
}

const mapStateToProps = (state) => {
    return {
        word: state.word
    }
}

export default connect(mapStateToProps)(WordInput)