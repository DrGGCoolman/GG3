import React, { Component } from 'react';
import { render } from "react-dom";

export class UserDetail extends Component {

    render() {
        return <dir>
            <h2>User Details</h2><form action="get|post">
                <label htmlFor="1">User Name:</label>
                <input type="text" name="Username" id="1" />
            </form></dir>
    };
}