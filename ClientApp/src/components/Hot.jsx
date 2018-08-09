import React, { Component } from 'react';
import { render } from "react-dom";

export class Hot extends Component {
    displayName = Hot.name

    constructor(props) {
        super(props);
        this.state = { goals: [], loading: true };

        fetch('api/Goal/GetGoals')
            .then(response => response.json())
            .then(data => {
                this.setState({ goals: data, loading: false });
            });
    }

    static renderForecastsTable(goals) {
        return (
            <div><p>{JSON.stringify(this.goals)}</p></div>
        );

    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Hot.renderForecastsTable(this.state.goals);

        return (
            <div>
                <h1>Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
}