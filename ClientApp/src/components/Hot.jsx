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

    static renderGoals(goals) {
        return (
            <div>



                <table className='table'>
                    <thead>
                        <tr>
                            <th>Goal Name:</th>
                        </tr>
                    </thead>
                    <tbody>
                        {goals.map(goals =>
                            <tr key={goals.DateCreated}>
                                <td>{goals.Title}</td>
                                <td>{goals.DateCreated}</td>
                                <td>{goals.Desc}</td>

                            </tr>
                        )}
                    </tbody>
                </table>
            </div >

        );

    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Hot.renderGoals(this.state.goals);

        return (
            <div>
                <h1>Hot Goals</h1>
                {contents}
            </div>
        );
    }
}