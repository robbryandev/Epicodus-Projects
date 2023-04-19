import { Component } from "react";
import PropTypes from "prop-types";

export default class Schedule extends Component {
    constructor(props) {
        super(props);
        this.day = props.day != null ? props.day : "";
        this.location = props.location != null ? props.location : "";
        this.hours = props.hours != null ? props.hours : "";
        this.booth = props.day != null ? props.booth : "";
    }

    render() {
        return (
            <ul>
                <li>{this.day}</li>
                <li>{this.location}</li>
                <li>{this.hours}</li>
                <li>{this.booth}</li>
            </ul>
        )
    }
}

Schedule.propTypes = {
    day: PropTypes.string,
    location: PropTypes.string,
    hours: PropTypes.string,
    booth: PropTypes.string
}

export const marketSchedule = [
    {
        day: "Sunday",
        location: "Lents International",
        hours: "9:00am - 2:00pm",
        booth: "4A"
    },
    {
        day: "Monday",
        location: "Pioneer Courthouse Square",
        hours: "10:00am - 2:00pm",
        booth: "7C"
    },
    {
        day: "Tuesday",
        location: "Hillsboro",
        hours: "5:00pm - 8:30pm",
        booth: "1F"
    },
    {
        day: "Wednesday",
        location: "Shemanski Park",
        hours: "10:00am - 2:00pm",
        booth: "3E"
    },
    {
        day: "Thursday",
        location: "Northwest Portland",
        hours: "2:00pm - 6:00pm",
        booth: "6D"
    },
    {
        day: "Saturday",
        location: "Beaverton",
        hours: "10:00am - 1:30pm",
        booth: "9G"
    }
];
