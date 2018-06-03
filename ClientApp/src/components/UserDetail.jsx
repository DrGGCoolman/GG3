import React, { Component } from 'react';
import { render } from "react-dom";




class Button extends React.Component {
    render() {
        return (
            <button
                onClick={() => this.props.onClickFunction(this.props.incrementValue)}
            >
                +{this.props.incrementValue}
            </button>
        );
    }
}

const Result = (props) => {
    return (
        <div>{props.counter}</div>
    );
};

class App extends React.Component {

}
export class UserDetail extends Component {
    state = { counter: 0 };

    incrementCounter = (incrementValue) => {
        {
            this.setState((prevState) => ({
                counter: prevState.counter + incrementValue
            }));
        };
    };

    render() {
        return (
            <div>
                <Button incrementValue={1} onClickFunction={this.incrementCounter} />
                <Button incrementValue={10} onClickFunction={this.incrementCounter} />
                <Button incrementValue={50} onClickFunction={this.incrementCounter} />
                <Button incrementValue={100} onClickFunction={this.incrementCounter} />

                <Result counter={this.state.counter} />
            </div>
        );

    }

}
