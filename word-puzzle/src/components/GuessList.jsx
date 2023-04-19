import { Component } from "react";
import { connect } from "react-redux";
import {v4} from "uuid";
import "../styles/GuessList.css"

export class GuessList extends Component {
    render() {
        return (
            <div className="guess-list">
                {
                    this.props.word.guessList.map((gs) => {
                        return (
                            <pre className="guess" key={v4()}>
                                {
                                    gs.map((ch) => {
                                        if (ch.status === "match") {
                                            return (
                                                <span className="green" key={v4()}>
                                                    {ch.letter}
                                                </span>
                                            )
                                        } else if (ch.status === "exist") {
                                            return (
                                                <span className="yellow" key={v4()}>
                                                    {ch.letter}
                                                </span>
                                            )
                                        } else {
                                            return (
                                                <span key={v4()}>
                                                    {ch.letter}
                                                </span>
                                            )
                                        }
                                    })
                                }
                            </pre>
                        )
                    })
                }
            </div>
        )
    }
}

const mapStateToProps = (state) => {
    return {
        word: state.word
    }
}

export default connect(mapStateToProps)(GuessList)