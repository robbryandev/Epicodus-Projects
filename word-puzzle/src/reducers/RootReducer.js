import { combineReducers } from "redux";
import WordReducer from "./WordReducer";

const Reducer = combineReducers({
    word: WordReducer.reducer
})

export default Reducer