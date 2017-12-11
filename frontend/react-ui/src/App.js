import React, { Component } from 'react';
import Header from './components/Header.jsx';
import Form from './components/Form.jsx';
import Display from './components/Display.jsx';
import { getAssets } from './helpers/APIService.js'
import logo from './logo.svg';
import './App.css';

// const stubData = [
//   {name: "Sam", id: 1},
//   {name: "Sam", id: 2},
//   {name: "Sam", id: 3},
//   {name: "Sam", id: 4}
// ]

class App extends Component {
  constructor() {
    super()
    this.state = []
  }

  componentWillMount() {
    const appData = getAssets();
    this.setState({ appData })
  }


  render() {
    return (
      <div className="App">
        <Header />
        <Form />
        <Display
          data={this.state.appData}
        />
      </div>
    );
  }
}

export default App;
