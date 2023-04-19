import Schedule, { marketSchedule } from "./Schedule"
import Produce, { availableProduce } from "./Produce"
import PropTypes from "prop-types";
import { Component, useState } from "react";

// export default class MarketList extends Component {
//     constructor(props) {
//         super(props)
//         this.scheduleList = props.scheduleList != null ? PropTypes.scheduleList : marketSchedule
//         this.produceList = props.produceList != null ? props.produceList : availableProduce
//         this.date = props.date != null ? props.date : "test"
//     }

//     setDate(ev) {
//         this.date = ev.target.value
//     }

//     render() {
//         return (
//             <>
//                 <h3>{this.date}</h3>
//                 <input type="date" onChange={this.setDate} />
//                 <h1>Schedule</h1>
//                 {
//                     this.scheduleList.map((sch) => {
//                         return <Schedule day={sch.day} location={sch.location} hours={sch.hours} booth={sch.booth} />
//                     })
//                 }
//                 <h1>Produce</h1>
//                 {
//                     this.produceList.map((prod) => {
//                         return <Produce month={prod.month} selection={prod.selection} />
//                     })
//                 }
//             </>
//         )
//     }
// }

export default function MarketList(props) {
    const scheduleList = props.scheduleList != null ? PropTypes.scheduleList : marketSchedule;
    const produceList = props.produceList != null ? PropTypes.produceList : availableProduce;
    const [month, setMonth] = useState(props.date != null ? PropTypes.date : "January");
    const months = [
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December"
    ]
    const [day, setDay] = useState(props.date != null ? PropTypes.date : "Monday");
    const days = [
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday",
        "Sunday"
    ]
    function changeDate(ev) {
        const evDate = new Date(ev.target.value)
        setMonth(months[evDate.getMonth()])
        setDay(days[evDate.getDay()])
    }
    return (
        <>
            <h3>Day: {day}</h3>
            <h3>Month: {month}</h3>
            <center>
                <input type="date" onChange={changeDate} />
            </center>
            <h1>Schedule</h1>
            {
                scheduleList.map((sch) => {
                    if (sch.day !== day) {
                        return null;
                    }
                    return <Schedule day={sch.day} location={sch.location} hours={sch.hours} booth={sch.booth} />
                })
            }
            <h1>Produce</h1>
            {
                produceList.map((prod) => {
                    if (prod.month !== month) {
                        return null;
                    }
                    return <Produce month={prod.month} selection={prod.selection} />
                })
            }
        </>
    )
}

MarketList.propTypes = {
    scheduleList: PropTypes.arrayOf(PropTypes.object),
    produceList: PropTypes.arrayOf(PropTypes.object)
}